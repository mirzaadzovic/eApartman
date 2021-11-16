import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/utisci/komentar_widget.dart';
import 'package:eapartman_mobile/pages/utisci/ocjena_prosjek.dart';
import 'package:eapartman_mobile/pages/utisci/ocjene_bar.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget OcjeneWidget(Utisak utisak) {
  return Padding(
    padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
    child: Column(
      children: [
        OcjenaProsjekBar(utisak),
        OcjeneBar(utisak),
        KomentarWidget(
            APIService.korisnik.slika, utisak.komentar, APIService.username),
      ],
    ),
  );
}
