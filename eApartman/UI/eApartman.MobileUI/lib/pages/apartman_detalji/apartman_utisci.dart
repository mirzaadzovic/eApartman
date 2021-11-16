import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_utisci_body.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class ApartmanUtisci extends StatelessWidget {
  Apartman apartman;
  ApartmanUtisci({this.apartman});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Apartman > Utisci"),
      body: ApartmanUtisciBody(apartman),
    );
  }
}
