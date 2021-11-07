import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/widgets/my_drawer.dart';
import 'package:flutter/material.dart';

class Apartmani extends StatelessWidget {
  ApartmanSearch search;
  Apartmani({this.search});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(),
      drawer: MyDrawer(),
    );
  }
}
