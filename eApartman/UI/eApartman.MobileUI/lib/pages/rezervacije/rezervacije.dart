import 'package:eapartman_mobile/pages/rezervacije/rezervacije_body.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class Rezervacije extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Rezervacije"),
      body: RezervacijeBody(),
    );
  }
}
