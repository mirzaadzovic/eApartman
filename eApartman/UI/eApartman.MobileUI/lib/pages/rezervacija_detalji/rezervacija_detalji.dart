import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/pages/rezervacija_detalji/rezervacija_detalji_body.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:eapartman_mobile/widgets/my_drawer.dart';
import 'package:flutter/material.dart';

class RezervacijaDetalji extends StatefulWidget {
  Rezervacija rezervacija;
  RezervacijaDetalji({this.rezervacija});

  _RezervacijaDetaljiState createState() =>
      _RezervacijaDetaljiState(rezervacija);
}

class _RezervacijaDetaljiState extends State<RezervacijaDetalji> {
  Rezervacija rezervacija;
  void setRezervacija() {
    setState(() {});
  }

  _RezervacijaDetaljiState(this.rezervacija);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Rezervacije > Detalji"),
      body: RezervacijaDetaljiBody(rezervacija, setRezervacija),
    );
  }
}
