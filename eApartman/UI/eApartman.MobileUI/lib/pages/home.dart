// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  String username = APIService.username;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eApartman")),
      drawer: Drawer(
        child: ListView(
          // ignore: prefer_const_literals_to_create_immutables
          children: [
            DrawerHeader(child: Text("eApartman")),
            ListTile(
              title: Text("Moj nalog"),
            ),
            ListTile(
              title: Text("Moje rezervacije"),
            ),
            ListTile(
              title: Text("Moji utisci"),
            ),
          ],
        ),
      ),
      body: Padding(
        padding: const EdgeInsets.all(50),
        child: Text(
          "Dobrodošo $username",
          style: TextStyle(fontSize: 30),
        ),
      ),
    );
  }
}
