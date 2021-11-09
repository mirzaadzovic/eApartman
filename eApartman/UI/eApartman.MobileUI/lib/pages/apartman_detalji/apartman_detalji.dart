import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_detalji_body.dart';
import 'package:flutter/material.dart';

class ApartmanDetalji extends StatelessWidget {
  Apartman apartman;
  ApartmanDetalji({this.apartman});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
          title: Text(
        "Apartmani > Detalji",
      )),
      body: ApartmanDetaljiBody(apartman: apartman),
    );
  }
}
