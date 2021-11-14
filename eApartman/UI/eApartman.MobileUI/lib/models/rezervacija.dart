import 'package:eapartman_mobile/Helpers/helpers.dart';
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
  bool izvrsena;
  bool otkazana;

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
    this.izvrsena,
    this.otkazana,
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
      otkazana: json["otkazana"],
      izvrsena: json["izvrsena"],
    );
  }
  Map<String, dynamic> toJson() => {
        "gostId": gostId.toString(),
        "apartmanId": apartmanId.toString(),
        "poruka": poruka,
        "brojOsoba": brojOsoba.toString(),
        "datumCheckIn": Helpers.DateOnly(checkIn).toIso8601String(),
        "datumCheckOut": Helpers.DateOnly(checkOut).toIso8601String(),
        "gostIme": gostIme,
        "gostPrezime": gostPrezime,
        "otkazana": otkazana,
        "izvrsena": izvrsena,
      };
  String Status() {
    DateTime checkin = Helpers.DateOnly(checkIn);
    bool JeLiIzvrsena = izvrsena;
    DateTime danas = Helpers.DateOnly(DateTime.now());
    bool jeLiUToku =
        (danas.isAtSameMomentAs(checkin) || danas.isAfter(checkin)) &&
            (!JeLiIzvrsena);
    if (otkazana)
      return "Otkazana";
    else if (JeLiIzvrsena)
      return "Izvrsena";
    else if (jeLiUToku)
      return "U toku";
    else
      return "Kreirana";
  }
}
