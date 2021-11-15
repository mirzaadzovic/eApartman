import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/avatar.dart';
import 'package:flutter/material.dart';

Widget komentarWidget(List<int> slika, String komentar, String username) {
  return Card(
    child: Padding(
      padding: EdgeInsets.all(20),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Expanded(
            flex: 2,
            child: Row(
              children: [
                Avatar(slika: slika, radius: 50),
                Padding(
                  padding: const EdgeInsets.all(10),
                  child: Container(
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Text(username, style: BoldBodyTextStyle),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
          Expanded(
            flex: 2,
            child: Padding(
              padding: const EdgeInsets.all(10),
              child: Container(
                child: Text('$komentar', style: KomentarTextStyle),
              ),
            ),
          ),
        ],
      ),
    ),
  );
}
