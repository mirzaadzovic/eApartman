import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_detalji.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class HomeRecommend extends StatelessWidget {
  List<Apartman> preporuka;
  HomeRecommend();
  @override
  Widget build(BuildContext context) {
    return body();
  }
}

Widget body() {
  return FutureBuilder(
    future: getPreporuke(),
    builder: (BuildContext context, AsyncSnapshot<List<Apartman>> snapshot) {
      if (snapshot.connectionState == ConnectionState.waiting) return Loading();
      if (snapshot.hasError) return Text("${snapshot.error.toString()}");
      if (snapshot.hasData) {
        if (snapshot.data.isEmpty) return SizedBox();
        return Padding(
          padding: const EdgeInsets.all(20),
          child: Column(
            children: [
              Padding(
                padding: EdgeInsets.all(10),
                child: Text("Preporuke", style: BodyTextStyle),
              ),
              Column(
                mainAxisAlignment: MainAxisAlignment.spaceAround,
                children: [
                  ...snapshot.data.map((a) => apartmanPreporuka(a, context))
                ],
              ),
            ],
          ),
        );
      }
      return SizedBox();
    },
  );
}

Future<List<Apartman>> getPreporuke() async {
  try {
    var result = await APIService.Get(
        "Apartmani/recommend/${APIService.korisnik.korisnikId}", null);
    var list = (result as List).map((a) => Apartman.fromJson(a)).toList();
    return list;
  } catch (e) {
    print(e.toString());
    return [];
  }
}

Widget apartmanPreporuka(Apartman apartman, BuildContext context) {
  DateFormat formatter = DateFormat("d/M/yyyy");
  void handleTap() {
    apartman.search = ApartmanSearch(
      checkIn: apartman.datumSlobodan,
      checkOut: apartman.datumSlobodan.add(Duration(days: 1)),
      grad: apartman.gradNaziv,
      osoba: apartman.maxOsoba,
    );
    Navigator.push(
        context,
        MaterialPageRoute(
            builder: (context) => ApartmanDetalji(apartman: apartman)));
  }

  return Center(
    child: Padding(
      padding: const EdgeInsets.all(10),
      child: Column(
        children: [
          Text(
            apartman.naziv,
            style: NaslovTextStyle,
            textAlign: TextAlign.center,
          ),
          Text(
            formatter.format(apartman.datumSlobodan) +
                "-" +
                formatter.format(apartman.datumSlobodan.add(Duration(days: 1))),
            style: PodNaslovTextStyle,
          ),
          GestureDetector(
            onTap: handleTap,
            child: Image(
              fit: BoxFit.cover,
              height: 100,
              image: MemoryImage(apartman.slikaProfilnaFile),
            ),
          ),
        ],
      ),
    ),
  );
}
