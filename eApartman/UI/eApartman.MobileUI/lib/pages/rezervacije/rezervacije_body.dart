import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/search_objects/rezervacija_serach.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/pages/rezervacije/rezervacija_widget.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

class RezervacijeBody extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Center(
          child: Column(
        children: [
          Padding(
            padding: EdgeInsets.all(20),
            child: Text("Moje rezervacije", style: PaleTextStyle),
          ),
          bodyWidget(),
        ],
      )),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder(
        future: GetRezervacije(),
        builder: (
          BuildContext context,
          AsyncSnapshot<List<Rezervacija>> snapshot,
        ) {
          if (snapshot.connectionState == ConnectionState.waiting)
            return Container(child: Loading());
          else if (snapshot.hasError)
            return Container(child: Text(snapshot.error.toString()));
          else if (snapshot.hasData) {
            if (snapshot.data.isNotEmpty)
              return SingleChildScrollView(
                child: ListView(
                  scrollDirection: Axis.vertical,
                  shrinkWrap: true,
                  physics: ClampingScrollPhysics(),
                  children:
                      snapshot.data.map((r) => RezervacijaWidget(r)).toList(),
                ),
              );
          }
          return Center(
            child: Padding(
                padding: EdgeInsets.all(20),
                child: Text(
                  "Još nema rezervacija",
                  style: BodyTextStyle,
                )),
          );
        });
  }

  Future<List<Rezervacija>> GetRezervacije() async {
    try {
      var include = ["Apartman.Adresa.Grad"];
      var rezervacije = await APIService.Get(
          "Rezervacije",
          RezervacijaSearch(
              gostId: APIService.korisnik.korisnikId, includeList: include));
      print(rezervacije);
      if (rezervacije != null)
        return (rezervacije as List)
            .map((r) => Rezervacija.fromJson(r))
            .toList();
      else
        throw Exception("Vraćena prazna lista.");
    } catch (e) {
      print("KURČINA -> " + e.toString());
      return [];
    }
  }
}
