import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/grad.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartmani/apartmani.dart';
import 'package:eapartman_mobile/pages/home/home_recommend.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/date_input.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:eapartman_mobile/widgets/icon_input_numbers.dart';
import 'package:eapartman_mobile/widgets/input_lokacija.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
import 'package:flutter/material.dart';
import '../../style.dart';

class HomeBody extends StatefulWidget {
  const HomeBody({Key key}) : super(key: key);

  @override
  _HomeBodyState createState() => _HomeBodyState();
}

class _HomeBodyState extends State<HomeBody> {
  TextEditingController _lokacijaController = TextEditingController();
  TextEditingController _osobaController = TextEditingController();
  DateTime checkin = Helpers.DateOnly(DateTime.now());
  DateTime checkout = Helpers.DateOnly(DateTime.now().add(Duration(days: 1)));
  String _lokacija;

  void setLokacija(String grad) {
    setState(() {
      _lokacija = grad;
    });
  }

  void handleCheckin(DateTime value) {
    //ako se ode cancel na datePickeru, da vrijednost ne ostane null
    DateTime date = value != null ? value : checkin;
    setState(() {
      checkin = date;
      if (date.isAfter(checkout) || date.isAtSameMomentAs(checkout))
        checkout = date.add(Duration(days: 1));
    });
  }

  void handleCheckout(DateTime value) {
    //ako se ode cancel na datePickeru, da vrijednost ne ostane null
    DateTime date = value != null ? value : checkout;
    setState(() {
      checkout = date;
      if (checkout.isAtSameMomentAs(Helpers.DateOnly(DateTime.now()))) {
        checkin = Helpers.DateOnly(DateTime.now());
        checkout = Helpers.DateOnly(checkin.add(Duration(days: 1)));
      } else if (date.isBefore(checkin) || date.isAtSameMomentAs(checkin))
        checkin = date.add(Duration(days: -1));
    });
  }

  void handleTrazi() {
    try {
      if (_osobaController.text != "") {
        Navigator.push(
          context,
          MaterialPageRoute(
              builder: (context) => Apartmani(
                    search: ApartmanSearch(
                      checkIn: checkin,
                      checkOut: checkout,
                      grad: _lokacijaController.text,
                      osoba: int.parse(_osobaController.text),
                      includeSlike: true,
                      includeUtisci: true,
                    ),
                  )),
        );
      } else {
        PorukaDialog.poruka(
          context: context,
          msg: "Broj osoba nije unesen!",
          handleClick: () => Navigator.pop(context, 'OK'),
        );
      }
    } catch (e) {
      print(e);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.fromLTRB(60, 20, 60, 20),
      child: Column(children: [
        Padding(
          padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
          child: Text("Kuda biste putovali?", style: PaleTextStyle),
        ),
        //IconInput(_lokacijaController, "Lokacija", false, Icons.search),
        InputLokacija(
          controller: _lokacijaController,
          lokacija: _lokacija,
          text: "Lokacija",
          icon: Icons.search,
          setLokacija: setLokacija,
        ),
        SizedBox(height: 20),
        IconInputNum(_osobaController, "Broj osoba", false, Icons.person),
        SizedBox(height: 20),
        DateInput(checkin, "Check-In", handleCheckin),
        SizedBox(height: 20),
        DateInput(checkout, "Check-Out", handleCheckout),
        SizedBox(height: 20),
        Button(text: "Traži", handleClick: handleTrazi),
      ]),
    );
  }
}
