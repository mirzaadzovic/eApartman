import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/utisci/komentar_widget.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget OcjeneWidget(Utisak utisak) {
  return Padding(
    padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
    child: Column(
      children: [
        Padding(
          padding: EdgeInsets.all(20),
          child: Container(
            width: 50,
            height: 50,
            decoration: BoxDecoration(
              color: Colors.blue,
              shape: BoxShape.circle,
            ),
            child: Center(
              child: Text(
                utisak.Prosjek().toStringAsFixed(1),
                style: OcjenaTextStyle,
                textAlign: TextAlign.center,
              ),
            ),
          ),
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: [
            Text("Wi-Fi: ${utisak.ocjenaWiFi.toString()}",
                style: PodNaslovTextStyle),
            Text("Čistoća: ${utisak.ocjenaCistoca.toString()}",
                style: PodNaslovTextStyle),
            Text("Wi-Fi: ${utisak.ocjenaLokacija.toString()}",
                style: PodNaslovTextStyle),
            Text("Wi-Fi: ${utisak.ocjenaVlasnik.toString()}",
                style: PodNaslovTextStyle),
            SizedBox(
              height: 20,
            )
          ],
        ),
        komentarWidget(
            APIService.korisnik.slika, utisak.komentar, APIService.username),
      ],
    ),
  );
}
