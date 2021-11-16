import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/pages/apartman_detalji/apartman_prosjek.dart';
import 'package:eapartman_mobile/pages/utisci/ocjena_prosjek.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
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
  void setApartman(Apartman value) {
    setState(() {
      apartman = value;
    });
  }

  _ApartmanDetaljiBodyState({this.apartman}) {
    loadSlike();
  }
  void loadSlike() {
    slike.add(apartman.slikaProfilnaFile);
    apartman.apartmanSlikas.forEach((element) {
      slike.add(element.slikaFile);
    });
  }

  void handleRezervisi() async {
    Rezervacija request = Rezervacija(
      apartmanId: apartman.apartmanId,
      gostId: APIService.korisnik.korisnikId,
      poruka: "Rezervisao gost",
      checkIn: Helpers.DateOnly(apartman.search.checkIn),
      checkOut: Helpers.DateOnly(apartman.search.checkOut),
      brojOsoba: apartman.search.osoba,
      gostIme: APIService.korisnik.ime,
      gostPrezime: APIService.korisnik.prezime,
    );
    try {
      var result = await APIService.Insert("Rezervacije", request);
      if (result != null) {
        await PorukaDialog.poruka(
          msg: 'Rezervisali ste apartman ${apartman.naziv}!',
          handleClick: () => Navigator.pop(context, 'OK'),
          context: context,
        );
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
                ApartmanProsjek(apartman, setApartman, true),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    Text("Grad: " + apartman.gradNaziv, style: BodyTextStyle),
                    Text("Cijena: " + apartman.cijena.toStringAsFixed(0) + " €",
                        style: BodyTextStyle),
                    Text("Max osoba: " + apartman.maxOsoba.toString(),
                        style: BodyTextStyle),
                  ],
                ),
                SizedBox(height: 20),
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
