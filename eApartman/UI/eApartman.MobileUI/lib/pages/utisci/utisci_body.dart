import 'dart:convert';

import 'package:eapartman_mobile/models/search_objects/utisak_search.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/pages/utisci/utisak_widget.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';

class UtisciBody extends StatefulWidget {
  UtisakSearch search;
  UtisciBody(this.search);

  @override
  _UtisciBodyState createState() => _UtisciBodyState(search);
}

class _UtisciBodyState extends State<UtisciBody> {
  UtisakSearch search;
  void reset() {
    setState(() {});
  }

  _UtisciBodyState(this.search);
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: body(search, reset),
    );
  }
}

Widget body(UtisakSearch search, Function reset) {
  return FutureBuilder(
      future: getUtisci(search),
      builder: (BuildContext context, AsyncSnapshot<List<Utisak>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting)
          return Loading();
        if (snapshot.hasData) {
          if (snapshot.data.isNotEmpty) {
            print(snapshot.data);
            return SingleChildScrollView(
                child: ListView(
                    shrinkWrap: true,
                    scrollDirection: Axis.vertical,
                    physics: ClampingScrollPhysics(),
                    children: [
                  ...snapshot.data.map((u) => UtisakWidget(u, search))
                ]));
          }
        }
        return Padding(
          padding: const EdgeInsets.all(10),
          child: Text("Nema utisaka...", style: BodyTextStyle),
        );
      });
}

Future<List<Utisak>> getUtisci(UtisakSearch search) async {
  try {
    var result = await APIService.Get("Utisci", search);
    if (result != null) {
      print("Evo ga");
      var list = (result as List).map((u) => Utisak.fromJson(u)).toList();
      return list;
    }
  } catch (e) {
    print(e);
    return [];
  }

  return [];
}
