import 'package:eapartman_mobile/models/imodel.dart';
import 'package:flutter/cupertino.dart';

class Rezervacija implements IModel {
  int rezervacijaId;
  int gostId;
  int apartmanId;
  String poruka;
  int brojOsoba;
  int brojDana;
  DateTime checkIn;
  DateTime checkOut;
  String gostIme;
  String gostPrezime;

  Rezervacija({
    this.rezervacijaId,
    this.gostId,
    this.apartmanId,
    this.poruka,
    this.brojOsoba,
    this.checkIn,
    this.checkOut,
    this.gostIme,
    this.gostPrezime,
  });
  factory Rezervacija.fromJson(Map<String, dynamic> json) {
    return Rezervacija(
      rezervacijaId: json["rezervacijaId"],
      apartmanId: json["apartmanId"],
      gostId: json["gostId"],
      poruka: json["poruka"],
      brojOsoba: json["brojOsoba"],
      checkIn: json["checkIn"],
      checkOut: json["checkOut"],
      gostIme: json["gostIme"],
      gostPrezime: json["gostPrezime"],
    );
  }
  Map<String, dynamic> toJson() => {
        "gostId": gostId,
        "apartmanId": apartmanId,
        "poruka": poruka,
        "brojOsoba": brojOsoba,
        "datumCheckIn": checkIn.toIso8601String(),
        "datumCheckOut": checkOut.toIso8601String(),
        "gostIme": gostIme,
        "gostPrezime": gostPrezime,
      };
}
