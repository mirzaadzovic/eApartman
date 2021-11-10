import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/slike_carousel.dart';
import 'package:flutter/material.dart';

class ApartmanDetaljiBody extends StatefulWidget {
  Apartman apartman;

  ApartmanDetaljiBody({this.apartman});

  @override
  _ApartmanDetaljiBodyState createState() =>
      _ApartmanDetaljiBodyState(apartman: apartman);
}

class _ApartmanDetaljiBodyState extends State<ApartmanDetaljiBody> {
  Apartman apartman;
  List<List<int>> slike = [];

  _ApartmanDetaljiBodyState({this.apartman}) {
    loadSlike();
  }
  void loadSlike() {
    slike.add(apartman.slikaProfilnaFile);
    apartman.apartmanSlikas.forEach((element) {
      slike.add(element.slikaFile);
    });
  }

  Future<void> poruka() async {
    return showDialog(
      context: context,
      builder: (BuildContext context) => AlertDialog(
        title: const Text('Poruka'),
        content: Text('Rezervisali ste apartman ${apartman.naziv}!'),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context, 'OK'),
            child: const Text('OK'),
          ),
        ],
      ),
    );
  }

  void handleRezervisi() async {
    Rezervacija request = Rezervacija(
      apartmanId: apartman.apartmanId,
      gostId: APIService.korisnik.korisnikId,
      poruka: "Rezervisao gost",
      checkIn: apartman.search.checkIn,
      checkOut: apartman.search.checkOut,
      brojOsoba: apartman.search.osoba,
      gostIme: APIService.korisnik.ime,
      gostPrezime: APIService.korisnik.prezime,
    );
    try {
      var result = await APIService.Insert("Rezervacije", request);
      if (result != null) {
        await poruka();
        Navigator.popUntil(context, ModalRoute.withName("/home"));
      }
    } catch (e) {
      print(e.toString());
    }
  }

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Container(
        child: Padding(
            padding: EdgeInsets.all(20),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(apartman.naziv, style: NaslovTextStyle),
                SlikeCarousel(slike: slike),
                Column(
                  children: [
                    Text("Grad: " + apartman.gradNaziv, style: BodyTextStyle),
                    Text("Cijena: " + apartman.cijena.toString() + " €",
                        style: BodyTextStyle),
                    Text("Max osoba: " + apartman.maxOsoba.toString(),
                        style: BodyTextStyle),
                  ],
                ),
                Button(
                  text: "Rezerviši",
                  handleClick: handleRezervisi,
                ),
              ],
            )),
      ),
    );
  }
}
