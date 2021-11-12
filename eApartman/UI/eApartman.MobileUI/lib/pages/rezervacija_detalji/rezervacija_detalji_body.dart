import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';

class RezervacijaDetaljiBody extends StatelessWidget {
  Rezervacija rezervacija;
  RezervacijaDetaljiBody(this.rezervacija);

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Center(
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Column(
            children: [
              Text(rezervacija.apartman.naziv, style: NaslovTextStyle),
              SizedBox(height: 20),
              Image(
                  image: MemoryImage(rezervacija.apartman.slikaProfilnaFile),
                  fit: BoxFit.cover,
                  height: 250,
                  width: 400),
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
                ],
              ),
              SizedBox(height: 20),
              Button(text: "Otkaži", handleClick: () {}),
            ],
          ),
        ),
      ),
    );
  }
}
