import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';

Widget ApartmanWidget(Apartman apartman) {
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
                      children: [
                        Text("Grad: " + apartman.gradNaziv,
                            style: BodyTextStyle),
                        Text("Cijena: " + apartman.cijena.toString() + " €",
                            style: BodyTextStyle),
                        Text("Max osoba: " + apartman.maxOsoba.toString(),
                            style: BodyTextStyle),
                      ],
                    ),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(10, 0, 0, 0),
                      child: Button(
                        text: "Pogledaj",
                        handleClick: () {},
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
