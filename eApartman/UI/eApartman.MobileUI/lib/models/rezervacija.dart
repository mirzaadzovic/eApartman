import 'package:eapartman_mobile/models/apartman.dart';
import 'package:eapartman_mobile/models/imodel.dart';
import 'package:flutter/cupertino.dart';

class Rezervacija implements IModel {
  int rezervacijaId;
  int gostId;
  int apartmanId;
  Apartman apartman;
  String poruka;
  int brojOsoba;
  int brojDana;
  double cijena;
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
    this.apartman,
    this.cijena,
  });
  factory Rezervacija.fromJson(Map<String, dynamic> json) {
    return Rezervacija(
      rezervacijaId: json["rezervacijaId"],
      apartmanId: json["apartmanId"],
      gostId: json["gostId"],
      poruka: json["poruka"],
      brojOsoba: json["brojOsoba"],
      checkIn: DateTime.parse(json["datumCheckIn"]),
      checkOut: DateTime.parse(json["datumCheckOut"]),
      gostIme: json["gostIme"],
      gostPrezime: json["gostPrezime"],
      apartman: Apartman.fromJson(json["apartman"]),
      cijena: json["cijena"],
    );
  }
  Map<String, dynamic> toJson() => {
        "gostId": gostId.toString(),
        "apartmanId": apartmanId.toString(),
        "poruka": poruka,
        "brojOsoba": brojOsoba.toString(),
        "datumCheckIn": checkIn.toIso8601String(),
        "datumCheckOut": checkOut.toIso8601String(),
        "gostIme": gostIme,
        "gostPrezime": gostPrezime,
      };
}
