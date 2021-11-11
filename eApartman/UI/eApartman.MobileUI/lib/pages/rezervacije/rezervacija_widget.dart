import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class RezervacijaWidget extends StatelessWidget {
  Rezervacija rezervacija;
  DateFormat formatter = DateFormat("d/M/yyyy");
  RezervacijaWidget(this.rezervacija);

  void handlePogledaj() async {}

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
          padding: EdgeInsets.fromLTRB(10, 20, 10, 20),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Expanded(
                flex: 2,
                child: Image(
                  image: MemoryImage(rezervacija.apartman.slikaProfilnaFile),
                  fit: BoxFit.cover,
                  height: 200,
                  width: 200,
                ),
              ),
              Expanded(
                flex: 2,
                child: Container(
                  height: 200,
                  child: Column(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Column(
                          children: [
                            Text(
                              rezervacija.apartman.naziv,
                              style: NaslovTextStyle,
                              textAlign: TextAlign.center,
                            ),
                            Text(
                              formatter.format(rezervacija.checkIn) +
                                  "-" +
                                  formatter.format(rezervacija.checkOut),
                              style: PodNaslovTextStyle,
                            )
                          ],
                        ),
                        Column(
                          mainAxisSize: MainAxisSize.min,
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text("Grad: " + rezervacija.apartman.gradNaziv,
                                style: BodyTextStyle),
                            Text(
                                "Broj osoba: " +
                                    rezervacija.brojOsoba.toString(),
                                style: BodyTextStyle),
                            Text(
                                "Cijena: " +
                                    rezervacija.cijena.toString() +
                                    " €",
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
          )),
    );
  }
}
