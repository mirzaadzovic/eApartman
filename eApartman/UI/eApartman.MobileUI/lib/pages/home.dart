// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/icon_input.dart';
import 'package:eapartman_mobile/widgets/my_drawer.dart';
import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  TextEditingController _lokacijaController = TextEditingController();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eApartman")),
      drawer: MyDrawer(),
      drawerEnableOpenDragGesture: true,
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(60, 0, 60, 0),
          child: Column(children: [
            SizedBox(height: 20),
            Text("Kuda biste putovali?", style: PaleTextStyle),
            IconInput(_lokacijaController, "Lokacija", false, Icons.search),
          ]),
        ),
      ),
    );
  }
}
