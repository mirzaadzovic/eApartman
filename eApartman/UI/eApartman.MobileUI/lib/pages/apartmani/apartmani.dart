import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartmani/apartmani_body.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class Apartmani extends StatelessWidget {
  ApartmanSearch search;
  Apartmani({this.search});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: MyAppBar(title: "Apartmani"),
      body: ApartmaniBody(search: search),
      drawerEnableOpenDragGesture: true,
    );
  }
}
