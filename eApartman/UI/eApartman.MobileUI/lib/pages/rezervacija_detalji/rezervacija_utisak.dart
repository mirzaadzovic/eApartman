import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/pages/utisci/ocjene_widget.dart';
import 'package:eapartman_mobile/pages/utisci/utisak_dodaj.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

Widget RezervacijaUtisakBody(
    BuildContext context, Rezervacija rezervacija, Function setRezervacija) {
  return FutureBuilder(
      future: GetUtisak(rezervacija.rezervacijaId),
      builder: (BuildContext context, AsyncSnapshot<Utisak> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting)
          return Column(
            children: [Text("Utisak", style: BodyTextStyle), Loading()],
          );
        if (snapshot.hasError) return Text(snapshot.error.toString());
        if (snapshot.hasData) {
          if (snapshot.data != null) return OcjeneWidget(snapshot.data);
        }
        return GestureDetector(
          onTap: () {
            Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) =>
                        UtisakDodaj(rezervacija, setRezervacija)));
          },
          child: Padding(
            padding: const EdgeInsets.all(10),
            child: Text("Dodaj utisak...", style: LinkTextStyle),
          ),
        );
      });
}

Future<Utisak> GetUtisak(int id) async {
  try {
    var utisak = await APIService.GetById("utisci", id);
    print(utisak);
    return Utisak.fromJson(utisak);
  } catch (e) {
    return null;
  }
}
