import 'dart:convert';

import 'package:eapartman_mobile/models/rezervacija.dart';

class Korisnik {
  int korisnikId;
  String username;
  String ime;
  final String prezime;
  String email;
  String telefon;
  DateTime datumRegistracije;
  List<Rezervacija> rezervacijas;
  List<int> slika;

  // List<Utisak> utisaks;
  Korisnik({
    this.korisnikId,
    this.username,
    this.ime,
    this.prezime,
    this.email,
    this.telefon,
    this.datumRegistracije,
    this.rezervacijas,
    this.slika,
  });
  factory Korisnik.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slika"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Korisnik(
      korisnikId: json["korisnikId"],
      username: json["username"],
      ime: json["ime"],
      prezime: json["prezime"],
      email: json["email"],
      telefon: json["telefon"],
      datumRegistracije: json["datumRegistracije"],
      rezervacijas: json["rezevacijas"],
      slika: bytes,
    );
  }
  Map<String, dynamic> toJson() => {
        "ime": ime,
        "username": username,
        "prezime": prezime,
        "email": email,
        "telefon": telefon,
        "slika": slika,
      };
}
