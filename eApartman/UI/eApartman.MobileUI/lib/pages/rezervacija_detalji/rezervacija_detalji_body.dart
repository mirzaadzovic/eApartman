import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';

class RezervacijaDetaljiBody extends StatelessWidget {
  Rezervacija rezervacija;
  RezervacijaDetaljiBody(this.rezervacija);

  String rezervacijaStatus() {
    DateTime checkin = Helpers.DateOnly(rezervacija.checkIn);
    bool JeLiIzvrsena = rezervacija.izvrsena;
    DateTime danas = Helpers.DateOnly(DateTime.now());
    bool jeLiUToku =
        (danas.isAtSameMomentAs(checkin) || danas.isAfter(checkin)) &&
            (!JeLiIzvrsena);
    if (rezervacija.otkazana)
      return "Otkazana";
    else if (JeLiIzvrsena)
      return "Izvrsena";
    else if (jeLiUToku)
      return "U toku";
    else
      return "Kreirana";
  }

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Center(
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text(rezervacija.apartman.naziv, style: NaslovTextStyle),
              SizedBox(height: 20),
              Image(
                  image: MemoryImage(rezervacija.apartman.slikaProfilnaFile),
                  fit: BoxFit.cover,
                  height: 250,
                  width: 400),
              SizedBox(height: 20),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: [
                  Text("Grad: " + rezervacija.apartman.gradNaziv,
                      style: BodyTextStyle),
                  Text("Cijena: " + rezervacija.cijena.toString() + " €",
                      style: BodyTextStyle),
                  Text("Broj osoba: " + rezervacija.brojOsoba.toString(),
                      style: BodyTextStyle),
                  Text("Status: " + rezervacijaStatus(), style: BodyTextStyle),
                ],
              ),
              SizedBox(height: 20),
              rezervacija.otkazana || rezervacija.izvrsena
                  ? null
                  : Button(text: "Otkaži", handleClick: () {}),
            ],
          ),
        ),
      ),
    );
  }
}
