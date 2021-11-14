import 'dart:convert';

import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:eapartman_mobile/widgets/rating_stars.dart';
import 'package:eapartman_mobile/widgets/text_area.dart';
import 'package:flutter/material.dart';

class UtisakDodajBody extends StatefulWidget {
  Rezervacija rezervacija;
  UtisakDodajBody(this.rezervacija);
  _UtisakState createState() => _UtisakState(rezervacija);
}

class _UtisakState extends State<UtisakDodajBody> {
  Rezervacija rezervacija;
  int cistoca = 0;
  int lokacija = 0;
  int wifi = 0;
  int vlasnik = 0;
  TextEditingController komentarController;

  void rateCistoca(int value) {
    setState(() {
      cistoca = value;
    });
  }

  void rateLokacija(int value) {
    setState(() {
      lokacija = value;
    });
  }

  void rateWiFi(int value) {
    setState(() {
      wifi = value;
    });
  }

  void rateVlasnik(int value) {
    setState(() {
      vlasnik = value;
    });
  }

  _UtisakState(this.rezervacija);
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Container(
        child: Center(
          child: Padding(
            padding: EdgeInsets.fromLTRB(40, 20, 40, 20),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Padding(
                  padding: const EdgeInsets.fromLTRB(0, 10, 0, 10),
                  child: Text("Dodaj utisak", style: NaslovTextStyle),
                ),
                Padding(
                  padding: const EdgeInsets.fromLTRB(0, 10, 0, 10),
                  child: Text("${rezervacija.apartman.naziv}",
                      style: BodyTextStyle),
                ),
                Column(
                  children: [
                    RatingStars(title: "Wi-Fi: ", func: rateWiFi),
                    RatingStars(title: "Cistoca: ", func: rateCistoca),
                    RatingStars(title: "Lokacija: ", func: rateLokacija),
                    RatingStars(title: "Vlasnik: ", func: rateVlasnik),
                  ],
                ),
                SizedBox(height: 10),
                Column(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    TextArea("Komentar", komentarController),
                    SizedBox(
                      height: 20,
                    ),
                    Button(
                      text: "Dodaj",
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
