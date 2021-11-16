import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/utisak_search.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_prosjek.dart';
import 'package:eapartman_mobile/pages/utisci/utisci_body.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/slike_carousel.dart';
import 'package:flutter/material.dart';

Widget ApartmanUtisciBody(Apartman apartman) {
  List<List<int>> slike = [];
  slike.add(apartman.slikaProfilnaFile);
  apartman.apartmanSlikas.forEach((element) {
    slike.add(element.slikaFile);
  });
  UtisakSearch search = UtisakSearch(
    apartmanId: apartman.apartmanId,
    gostId: 0,
    includeList: ["UtisakNavigation.Apartman", "Korisnik"],
  );

  return SingleChildScrollView(
    child: Container(
      child: Padding(
          padding: EdgeInsets.all(20),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Text(apartman.naziv, style: NaslovTextStyle),
              SlikeCarousel(slike: slike),
              ApartmanProsjek(apartman, () {}, false),
              UtisciBody(search)
            ],
          )),
    ),
  );
}
