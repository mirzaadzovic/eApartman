import 'dart:convert';

import 'package:eapartman_mobile/models/imodel.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';

class Korisnik implements IModel {
  int korisnikId;
  String username;
  String ime;
  String prezime;
  String email;
  String telefon;
  String password;
  String passwordPotvrda;
  DateTime datumRegistracije;
  List<Rezervacija> rezervacijas;
  List<int> slika;
  List<int> uloge;

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
    this.password,
    this.passwordPotvrda,
    this.uloge,
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
      datumRegistracije: DateTime.parse(json["datumRegistracije"]),
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
        "password": password,
        "passwordPotvrda": passwordPotvrda,
        "uloge": uloge,
      };
}
