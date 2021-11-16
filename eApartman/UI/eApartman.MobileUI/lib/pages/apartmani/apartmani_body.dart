import 'dart:io';

import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartmani/apartman_widget.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class ApartmaniBody extends StatefulWidget {
  final ApartmanSearch search;
  ApartmaniBody({this.search});

  @override
  _ApartmaniBodyState createState() => _ApartmaniBodyState(search: search);
}

class _ApartmaniBodyState extends State<ApartmaniBody> {
  final ApartmanSearch search;
  String _naslov;
  final DateFormat formatter = DateFormat('d/M/yyyy');
  String grad;

  _ApartmaniBodyState({this.search, this.grad = ""}) {
    this.grad = search.grad != "" ? search.grad : "sve gradove";
    this._naslov =
        "Pretraga za ${grad} u periodu \n${formatter.format(search.checkIn)} - ${formatter.format(search.checkOut)}";
  }
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
          padding: EdgeInsets.all(10),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Center(
                  child: Text(
                _naslov,
                style: PaleTextStyle,
                textAlign: TextAlign.center,
              )),
              bodyWidget(search),
            ],
          )),
    );
  }

  Widget bodyWidget(ApartmanSearch search) {
    return FutureBuilder(
        future: GetApartmani(search),
        builder: (BuildContext context, AsyncSnapshot<List<dynamic>> snapshot) {
          try {
            if (snapshot.connectionState == ConnectionState.waiting)
              return Center(child: Loading());
            else if (snapshot.hasError)
              return Center(child: Text("${snapshot.error}"));
            else if (snapshot.hasData) {
              if (snapshot.data.isEmpty)
                return Padding(
                  padding: EdgeInsets.fromLTRB(0, 100, 0, 0),
                  child:
                      Text("Nema slobodnih apartmana.", style: BodyTextStyle),
                );
              return SingleChildScrollView(
                child: ListView(
                  shrinkWrap: true,
                  scrollDirection: Axis.vertical,
                  physics: ClampingScrollPhysics(),
                  children: snapshot.data
                      .map((a) =>
                          ApartmanWidget(Apartman.fromJson(a), context, search))
                      .toList(),
                ),
              );
            } else
              return (Text("No data"));
          } catch (e) {
            return (Text(e.toString()));
          }
        });
  }

  //Probati ispraviti povratni tip na Future<List<Apartman>>
  Future<List<dynamic>> GetApartmani(ApartmanSearch search) async {
    try {
      var apartmani = await APIService.Get("apartmani", search);
      print(apartmani);
      return apartmani;
    } catch (e) {
      print(e);
      return null;
    }
  }
}
