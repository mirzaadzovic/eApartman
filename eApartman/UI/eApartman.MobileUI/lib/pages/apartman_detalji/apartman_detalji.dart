import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_detalji_body.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class ApartmanDetalji extends StatelessWidget {
  Apartman apartman;
  Function setState = () {};
  ApartmanDetalji({this.apartman, this.setState});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Apartman > Detalji"),
      body: ApartmanDetaljiBody(apartman: apartman, setHome: setState),
    );
  }
}
