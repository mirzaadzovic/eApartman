import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/pages/utisci/utisak_dodaj_body.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class UtisakDodaj extends StatelessWidget {
  Rezervacija rezervacija;
  Function setRezervacija;
  UtisakDodaj(this.rezervacija, this.setRezervacija);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Rezervacije > Detalji > Utisak"),
      body: UtisakDodajBody(rezervacija, setRezervacija),
    );
  }
}
