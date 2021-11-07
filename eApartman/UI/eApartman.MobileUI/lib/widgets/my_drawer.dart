import 'package:flutter/material.dart';

class MyDrawer extends StatelessWidget {
  const MyDrawer({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Drawer(
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
    );
  }
}
