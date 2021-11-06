// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/date_input.dart';
import 'package:eapartman_mobile/widgets/icon_input.dart';
import 'package:eapartman_mobile/widgets/icon_input_numbers.dart';
import 'package:eapartman_mobile/widgets/my_drawer.dart';
import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  TextEditingController _lokacijaController = TextEditingController();
  TextEditingController _osobaController = TextEditingController();
  DateTime checkin = DateTime.now();
  DateTime checkout = DateTime.now().add(Duration(days: 1));

  void handleCheckin(DateTime? value) {
    DateTime date = value as DateTime;
    setState(() {
      checkin = date;
      if (date.isAfter(checkout)) checkout = date.add(Duration(days: 1));
    });
  }

  void handleCheckout(DateTime? value) {
    DateTime date = value as DateTime;
    setState(() {
      checkout = value;
      if (date.isBefore(checkin)) checkin = date.add(Duration(days: -1));
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eApartman")),
      drawer: MyDrawer(),
      drawerEnableOpenDragGesture: true,
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(60, 20, 60, 20),
          child: Column(children: [
            Padding(
              padding: const EdgeInsets.fromLTRB(0, 0, 0, 20),
              child: Text("Kuda biste putovali?", style: PaleTextStyle),
            ),
            IconInput(_lokacijaController, "Lokacija", false, Icons.search),
            SizedBox(height: 20),
            IconInputNum(_osobaController, "Broj osoba", false, Icons.person),
            SizedBox(height: 20),
            DateInput(checkin, "Check-In", handleCheckin),
            SizedBox(height: 20),
            DateInput(checkout, "Check-Out", handleCheckout),
            SizedBox(height: 20),
            Button("Traži", () {})
          ]),
        ),
      ),
    );
  }
}
