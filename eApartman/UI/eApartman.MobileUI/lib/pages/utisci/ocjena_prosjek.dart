import 'package:eapartman_mobile/models/iutisak.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget OcjenaProsjekBar(IUtisak utisak) {
  return Row(
    mainAxisAlignment: MainAxisAlignment.center,
    children: [
      Text("Ocjena", style: BoldBodyTextStyle),
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
    ],
  );
}
