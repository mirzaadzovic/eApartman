import 'package:eapartman_mobile/models/search_objects/utisak_search.dart';
import 'package:eapartman_mobile/pages/utisci/utisci_body.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/my_appbar.dart';
import 'package:flutter/material.dart';

class Utisci extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    UtisakSearch request = UtisakSearch(
        apartmanId: 0,
        gostId: APIService.korisnik.korisnikId,
        includeList: ["Korisnik", "UtisakNavigation.Apartman"]);
    return Scaffold(
        appBar: MyAppBar(title: "Apartman > Utisci"),
        body: SingleChildScrollView(
          child: Center(
              child: Padding(
            padding: const EdgeInsets.all(10),
            child: Column(
              children: [
                Padding(
                    padding: EdgeInsets.all(20),
                    child: Text("Moji utisci", style: NaslovTextStyle)),
                UtisciBody(request),
              ],
            ),
          )),
        ));
  }
}
