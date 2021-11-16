import 'package:eapartman_mobile/models/iutisak.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget OcjeneBar(IUtisak utisak) {
  return Row(
    mainAxisAlignment: MainAxisAlignment.spaceAround,
    children: [
      Text("Wi-Fi: ${utisak.WifiProsjek().toString()}",
          style: PodNaslovTextStyle),
      Text("Čistoća: ${utisak.CistocaProsjek().toString()}",
          style: PodNaslovTextStyle),
      Text("Lokacija: ${utisak.LokacijaProsjek().toString()}",
          style: PodNaslovTextStyle),
      Text("Vlasnik: ${utisak.VlasnikProsjek().toString()}",
          style: PodNaslovTextStyle),
      SizedBox(
        height: 20,
      )
    ],
  );
}
