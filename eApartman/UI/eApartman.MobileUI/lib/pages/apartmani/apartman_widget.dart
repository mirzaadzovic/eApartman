import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_detalji.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';

Widget ApartmanWidget(
    Apartman apartman, BuildContext context, ApartmanSearch search) {
  void handlePogledaj() {
    apartman.search = search;
    Navigator.push(
        context,
        MaterialPageRoute(
            builder: (context) => ApartmanDetalji(apartman: apartman)));
  }

  double cijena = apartman.cijena *
      Helpers.DateDifferenceDays(search.checkIn, search.checkOut);
  return Card(
    child: Padding(
      padding: const EdgeInsets.fromLTRB(10, 20, 10, 20),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Expanded(
              flex: 2,
              child: Image(
                fit: BoxFit.cover,
                height: 200,
                image: MemoryImage(apartman.slikaProfilnaFile),
              )),
          Expanded(
            flex: 2,
            child: Container(
              height: 200,
              child: Column(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Text(
                      apartman.naziv,
                      style: NaslovTextStyle,
                      textAlign: TextAlign.center,
                    ),
                    Column(
                      mainAxisSize: MainAxisSize.min,
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text("Grad: " + apartman.gradNaziv,
                            style: BodyTextStyle),
                        Text("Cijena: " + cijena.toStringAsFixed(0) + " €",
                            style: BodyTextStyle),
                        Text("Max osoba: " + apartman.maxOsoba.toString(),
                            style: BodyTextStyle),
                      ],
                    ),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(10, 0, 0, 0),
                      child: Button(
                        text: "Pogledaj",
                        handleClick: handlePogledaj,
                      ),
                    ),
                  ]),
            ),
          ),
        ],
      ),
    ),
  );
}
