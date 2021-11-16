import 'package:eapartman_mobile/models/search_objects/utisak_search.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/utisci/komentar_widget.dart';
import 'package:eapartman_mobile/pages/utisci/ocjene_bar.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

Widget UtisakWidget(Utisak utisak, UtisakSearch search) {
  DateFormat formatter = DateFormat("d/M/yyyy");
  String period = formatter.format(utisak.rezervacija.checkIn) +
      "-" +
      formatter.format(utisak.rezervacija.checkOut);
  print(search.apartmanId);
  return Padding(
    padding: EdgeInsets.all(10),
    child: Padding(
      padding: const EdgeInsets.all(10),
      child: Card(
        child: Column(
          children: [
            search.apartmanId == 0
                ? Padding(
                    padding: const EdgeInsets.fromLTRB(20, 20, 20, 5),
                    child: Text(utisak.rezervacija.apartman.naziv,
                        style: NaslovTextStyle),
                  )
                : SizedBox(),
            Padding(
              padding: const EdgeInsets.fromLTRB(20, 0, 20, 20),
              child: Text(period, style: BodyTextStyle),
            ),
            OcjeneBar(utisak),
            KomentarWidget(
              utisak.korisnik.slika,
              utisak.komentar,
              utisak.korisnik.username,
            ),
          ],
        ),
      ),
    ),
  );
}
