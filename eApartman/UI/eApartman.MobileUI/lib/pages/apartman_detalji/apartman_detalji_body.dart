import 'dart:convert';
import 'package:eapartman_mobile/services/paymentservice.dart';
import 'package:http/http.dart' as http;
import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_prosjek.dart';
import 'package:eapartman_mobile/pages/utisci/ocjena_prosjek.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
import 'package:eapartman_mobile/widgets/slike_carousel.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

class ApartmanDetaljiBody extends StatefulWidget {
  Apartman apartman;

  ApartmanDetaljiBody({this.apartman});

  @override
  _ApartmanDetaljiBodyState createState() =>
      _ApartmanDetaljiBodyState(apartman: apartman);
}

class _ApartmanDetaljiBodyState extends State<ApartmanDetaljiBody> {
  Apartman apartman;
  Map<String, dynamic> paymentIntentData;
  List<List<int>> slike = [];
  void setApartman(Apartman value) {
    setState(() {
      apartman = value;
    });
  }

  _ApartmanDetaljiBodyState({this.apartman, this.paymentIntentData}) {
    loadSlike();
  }
  void loadSlike() {
    slike.add(apartman.slikaProfilnaFile);
    apartman.apartmanSlikas.forEach((element) {
      slike.add(element.slikaFile);
    });
  }

  void handleRezervisi() async {
    Rezervacija request = Rezervacija(
      apartmanId: apartman.apartmanId,
      gostId: APIService.korisnik.korisnikId,
      poruka: "Rezervisao gost",
      checkIn: Helpers.DateOnly(apartman.search.checkIn),
      checkOut: Helpers.DateOnly(apartman.search.checkOut),
      brojOsoba: apartman.search.osoba,
      gostIme: APIService.korisnik.ime,
      gostPrezime: APIService.korisnik.prezime,
    );
    try {
      var result = await APIService.Insert("Rezervacije", request);
      if (result != null) {
        await PorukaDialog.poruka(
          msg: 'Rezervisali ste apartman ${apartman.naziv}!',
          handleClick: () => Navigator.pop(context, 'OK'),
          context: context,
        );
        Navigator.popUntil(context, ModalRoute.withName("/home"));
      }
    } catch (e) {
      print(e.toString());
    }
  }

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Container(
        child: Padding(
            padding: EdgeInsets.all(20),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(apartman.naziv, style: NaslovTextStyle),
                SlikeCarousel(slike: slike),
                ApartmanProsjek(apartman, setApartman, true),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    Text("Grad: " + apartman.gradNaziv, style: BodyTextStyle),
                    Text("Osoba: " + apartman.search.osoba.toString(),
                        style: BodyTextStyle),
                    Text("Noćenja: " + calculateNocenja().toString(),
                        style: BodyTextStyle),
                    Text(
                        "Cijena: " +
                            calculateCijena().toStringAsFixed(0) +
                            " €",
                        style: BodyTextStyle),
                  ],
                ),
                SizedBox(height: 20),
                Button(
                  text: "Rezerviši",
                  handleClick: () async {
                    makePayment();
                  },
                ),
              ],
            )),
      ),
    );
  }

  Future<void> makePayment() async {
    try {
      String cijena = calculateCijena().toStringAsFixed(0);
      paymentIntentData = await PaymentService.CreatePaymentContent(apartman);
      await Stripe.instance
          .initPaymentSheet(
              paymentSheetParameters: SetupPaymentSheetParameters(
                  paymentIntentClientSecret: paymentIntentData["client_secret"],
                  applePay: true,
                  googlePay: true,
                  testEnv: true,
                  style: ThemeMode.dark,
                  merchantCountryCode: 'US',
                  merchantDisplayName: APIService.username))
          .then((value) {
        print("value");
      }).catchError((e) => print(e.toString()));
      setState(() {});
      displayPaymentSheet();
    } catch (e) {
      print("makePayment: " + e.toString());
    }
  }

  // dynamic createPaymentIntent(String amount, String currency) async {
  //   try {
  //     print(amount);
  //     Map<String, dynamic> body = {
  //       "amount": amount.toString(),
  //       "currency": currency,
  //       "payment_method_types[]": "card",
  //     };

  //     var response = await http.post(
  //         Uri.parse('https://api.stripe.com/v1/payment_intents'),
  //         body: body,
  //         headers: {
  //           'Authorization':
  //               'Bearer sk_test_51JwnUmHsjqdF5wnurCvQMqqHGLRSZ0zmyCFAtnz1LB50HwtLkTiKggyzh1cIjdFCXGGZlz4m4hzoWBcry6R3an5j00OmbqNz8P',
  //           'Content-Type': 'application/x-www-form-urlencoded',
  //         });
  //     print(response.body.toString());
  //     return jsonDecode(response.body.toString());
  //   } catch (e) {
  //     print("create: " + e.toString());
  //   }
  // }

  double calculateCijena() {
    return apartman.cijena * calculateNocenja();
  }

  int calculateNocenja() {
    return Helpers.DateDifferenceDays(
        apartman.search.checkIn, apartman.search.checkOut);
  }

  Future<void> displayPaymentSheet() async {
    try {
      await Stripe.instance.presentPaymentSheet(
        parameters: PresentPaymentSheetParameters(
          clientSecret: paymentIntentData['client_secret'],
          confirmPayment: true,
        ),
      );
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text("Uspješno plaćanje")));
      handleRezervisi();
    } catch (e) {
      print("display: " + e.toString());
    }
  }
}
