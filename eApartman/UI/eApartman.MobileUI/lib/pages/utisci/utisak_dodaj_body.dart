import 'dart:convert';

import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
import 'package:eapartman_mobile/widgets/rating_stars.dart';
import 'package:eapartman_mobile/widgets/text_area.dart';
import 'package:flutter/material.dart';

class UtisakDodajBody extends StatefulWidget {
  Rezervacija rezervacija;
  Function setRezervacija;
  UtisakDodajBody(this.rezervacija, this.setRezervacija);
  _UtisakState createState() => _UtisakState(rezervacija, setRezervacija);
}

class _UtisakState extends State<UtisakDodajBody> {
  Rezervacija rezervacija;
  int cistoca = 3;
  int lokacija = 3;
  int wifi = 3;
  int vlasnik = 3;
  TextEditingController komentarController = TextEditingController();
  Function setRezervacija;

  void rateCistoca(int value) {
    setState(() {
      cistoca = value;
    });
  }

  void rateLokacija(int value) {
    setState(() {
      lokacija = value;
    });
  }

  void rateWiFi(int value) {
    setState(() {
      wifi = value;
    });
  }

  void rateVlasnik(int value) {
    setState(() {
      vlasnik = value;
    });
  }

  void handleDodaj(BuildContext context) async {
    Utisak request = Utisak(
      utisakId: rezervacija.rezervacijaId,
      apartmanId: rezervacija.apartmanId,
      komentar: komentarController.text,
      korisnikId: APIService.korisnik.korisnikId,
      ocjenaCistoca: cistoca,
      ocjenaLokacija: lokacija,
      ocjenaVlasnik: vlasnik,
      ocjenaWiFi: wifi,
    );
    try {
      var response = await APIService.Insert("Utisci", request);
      String poruka;
      if (response != null)
        poruka = "Utisak za apartman ${rezervacija.apartman.naziv} dodan!";
      else
        poruka = "Došlo je do greške...";
      await PorukaDialog.poruka(
        msg: poruka,
        context: context,
        handleClick: () => Navigator.pop(context, "OK"),
      );
      //update stanja rezervacije kad se vratimo na prethodni page
      setRezervacija();
      Navigator.pop(context);
    } catch (e) {
      await PorukaDialog.poruka(
        msg: e.toString(),
        context: context,
        handleClick: () => Navigator.pop(context, "OK"),
      );
    }
  }

  _UtisakState(this.rezervacija, this.setRezervacija);
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Container(
        child: Center(
          child: Padding(
            padding: EdgeInsets.fromLTRB(40, 20, 40, 20),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Padding(
                  padding: const EdgeInsets.fromLTRB(0, 10, 0, 10),
                  child: Text("Dodaj utisak", style: NaslovTextStyle),
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(0, 10, 0, 10),
                  child: Text("${rezervacija.apartman.naziv}",
                      style: BodyTextStyle),
                ),
                Column(
                  children: [
                    RatingStars(title: "Wi-Fi: ", func: rateWiFi),
                    RatingStars(title: "Cistoca: ", func: rateCistoca),
                    RatingStars(title: "Lokacija: ", func: rateLokacija),
                    RatingStars(title: "Vlasnik: ", func: rateVlasnik),
                  ],
                ),
                SizedBox(height: 10),
                Column(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    TextArea("Komentar", komentarController),
                    SizedBox(
                      height: 20,
                    ),
                    Button(
                      text: "Dodaj",
                      handleClick: () => handleDodaj(context),
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
