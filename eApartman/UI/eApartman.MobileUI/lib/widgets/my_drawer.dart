import 'package:eapartman_mobile/pages/rezervacije/rezervacije.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/avatar.dart';
import 'package:flutter/material.dart';

class MyDrawer extends StatelessWidget {
  List<int> slika = APIService.korisnik.slika;

  void toRezervacije(BuildContext context) {
    Navigator.push(
        context, MaterialPageRoute(builder: (context) => Rezervacije()));
  }

  void toHome(BuildContext context) {
    Navigator.popUntil(context, ModalRoute.withName("/home"));
  }

  void toUtisci(BuildContext context) {}

  void toNalog(BuildContext context) {}

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        // ignore: prefer_const_literals_to_create_immutables
        children: [
          DrawerHeader(
            child: Center(
              child: Column(
                children: [
                  Avatar(slika: slika, radius: 100),
                  Expanded(
                    flex: 10,
                    child: Padding(
                      padding: const EdgeInsets.fromLTRB(0, 10, 0, 0),
                      child: Text(APIService.username, style: NaslovTextStyle),
                    ),
                  ),
                ],
                mainAxisAlignment: MainAxisAlignment.center,
              ),
            ),
          ),
          ListTile(
            title: Text("Početna", style: BodyTextStyle),
            onTap: () => toHome(context),
          ),
          ListTile(
            title: Text("Moje rezervacije", style: BodyTextStyle),
            onTap: () => toRezervacije(context),
          ),
          ListTile(
            title: Text("Moji utisci", style: BodyTextStyle),
            onTap: () => toUtisci(context),
          ),
          ListTile(
            title: Text("Moj nalog", style: BodyTextStyle),
            onTap: () => toNalog(context),
          ),
          ListTile(
            title: Text("Logout", style: BodyTextStyle),
            onTap: () => APIService.logout(context),
          ),
        ],
      ),
    );
  }
}
