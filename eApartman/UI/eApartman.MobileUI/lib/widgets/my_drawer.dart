import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/avatar.dart';
import 'package:flutter/material.dart';

class MyDrawer extends StatelessWidget {
  List<int> slika = APIService.korisnik.slika;

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
            title: Text("Moj nalog", style: BodyTextStyle),
          ),
          ListTile(
            title: Text("Moje rezervacije", style: BodyTextStyle),
          ),
          ListTile(
            title: Text("Moji utisci", style: BodyTextStyle),
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
