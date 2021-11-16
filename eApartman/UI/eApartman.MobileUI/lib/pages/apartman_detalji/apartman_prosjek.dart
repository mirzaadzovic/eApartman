import 'dart:convert';

import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/apartman_ocjene.dart';
import 'package:eapartman_mobile/models/search_objects/utisak_search.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_utisci.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/pages/utisci/ocjena_prosjek.dart';
import 'package:eapartman_mobile/pages/utisci/ocjene_bar.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget ApartmanProsjek(
    Apartman apartman, Function setApartman, bool pregledaj) {
  return FutureBuilder(
      future: getUtisci(apartman.apartmanId),
      builder: (BuildContext context, AsyncSnapshot<List<dynamic>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting)
          return Loading();
        if (snapshot.hasData) {
          if (snapshot.data.isNotEmpty) {
            Apartman novi = apartman;
            novi.utisci = snapshot.data.map((u) => Utisak.fromJson(u)).toList();
            // setApartman(novi);
            return Column(
              children: [
                OcjenaProsjekBar(novi.OcjeneProsjek()),
                OcjeneBar(novi.OcjeneProsjek()),
                SizedBox(height: 5),
                pregledaj
                    ? GestureDetector(
                        onTap: () {
                          Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) =>
                                      ApartmanUtisci(apartman: apartman)));
                        },
                        child: Padding(
                          padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
                          child: Text("Pogledaj utiske...",
                              style: SmallLinkTextStyle),
                        ),
                      )
                    : SizedBox(),
              ],
            );
          }
          return Column(
            children: [
              OcjenaProsjekBar(
                  ApartmanOcjene(cistoca: 0, wifi: 0, lokacija: 0, vlasnik: 0)),
              OcjeneBar(
                  ApartmanOcjene(cistoca: 0, wifi: 0, lokacija: 0, vlasnik: 0)),
              SizedBox(height: 5),
              Padding(
                padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
                child: Text("Nema utisaka...", style: PodNaslovTextStyle),
              ),
            ],
          );
        }
        return Column(
          children: [
            OcjenaProsjekBar(
                ApartmanOcjene(cistoca: 0, wifi: 0, lokacija: 0, vlasnik: 0)),
            OcjeneBar(
                ApartmanOcjene(cistoca: 0, wifi: 0, lokacija: 0, vlasnik: 0)),
            SizedBox(height: 5),
            Padding(
              padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
              child: Text("Nema utisaka...", style: PodNaslovTextStyle),
            ),
          ],
        );
      });
}

Future<List<dynamic>> getUtisci(int apartmanId) async {
  try {
    var result = await APIService.Get(
        "Utisci", UtisakSearch(apartmanId: apartmanId, gostId: 0));
    if (result != null) {
      print(result);
      return result as List;
    }
    return [];
  } catch (e) {
    print("MIRZAAA " + e.toString());
    return [];
  }
}
