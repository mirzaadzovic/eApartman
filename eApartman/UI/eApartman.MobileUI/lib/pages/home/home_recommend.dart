import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_detalji.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class HomeRecommend extends StatefulWidget {
  _State createState() => _State();
}

class _State extends State<HomeRecommend> {
  List<Apartman> preporuka;

  @override
  Widget build(BuildContext context) {
    return body(() => this.setState(() {}));
  }
}

Widget body(Function setState) {
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
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  ...snapshot.data
                      .map((a) => apartmanPreporuka(a, context, setState))
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
    print(result);
    print(list[0].datumSlobodan);
    return list;
  } catch (e) {
    print(e.toString());
    return [];
  }
}

Widget apartmanPreporuka(
    Apartman apartman, BuildContext context, Function setState) {
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
            builder: (context) =>
                ApartmanDetalji(apartman: apartman, setState: setState)));
  }

  return Expanded(
    flex: 2,
    child: Padding(
      padding: const EdgeInsets.all(10),
      child: Column(
        children: [
          GestureDetector(
            onTap: handleTap,
            child: Image(
              fit: BoxFit.cover,
              height: 100,
              width: 150,
              image: MemoryImage(apartman.slikaProfilnaFile),
            ),
          ),
          Text(
            apartman.naziv,
            style: PreporukaTextStyle,
            textAlign: TextAlign.center,
          ),
          Text(
            formatter.format(apartman.datumSlobodan) +
                "\n" +
                formatter.format(apartman.datumSlobodan.add(Duration(days: 1))),
            style: PodNaslovTextStyle,
          ),
        ],
      ),
    ),
  );
}
