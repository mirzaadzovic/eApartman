import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/apartman_slika.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:flutter/material.dart';
import 'package:carousel_slider/carousel_slider.dart';

class ApartmanDetaljiBody extends StatefulWidget {
  Apartman apartman;

  ApartmanDetaljiBody({this.apartman});

  @override
  _ApartmanDetaljiBodyState createState() =>
      _ApartmanDetaljiBodyState(apartman: apartman);
}

class _ApartmanDetaljiBodyState extends State<ApartmanDetaljiBody> {
  Apartman apartman;
  int slikaIndex = 0;
  List<List<int>> slike = [];

  _ApartmanDetaljiBodyState({this.apartman}) {
    slike.add(apartman.slikaProfilnaFile);
    apartman.apartmanSlikas.forEach((element) {
      slike.add(element.slikaFile);
    });
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
                CarouselSlider.builder(
                  options: CarouselOptions(
                    enlargeCenterPage: true,
                    enableInfiniteScroll: false,
                    height: 250,
                  ),
                  itemCount: slike.length,
                  itemBuilder: (BuildContext context, int itemIndex,
                          int pageViewIndex) =>
                      Container(
                    child: Image(
                      image: MemoryImage(slike[pageViewIndex]),
                      fit: BoxFit.cover,
                      width: double.infinity,
                    ),
                  ),
                ),
                // Image(
                //   fit: BoxFit.cover,
                //   image: MemoryImage(apartman.slikaProfilnaFile),
                // ),
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
                  handleClick: () {},
                ),
              ],
            )),
      ),
    );
  }
}
