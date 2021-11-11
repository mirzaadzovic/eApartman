import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class RezervacijaDetalji extends StatelessWidget {
  Rezervacija rezervacija;
  RezervacijaDetalji({this.rezervacija});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Rezervacije > Detalji"),
    );
  }
}
