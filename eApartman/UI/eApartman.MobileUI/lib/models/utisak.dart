import 'package:eapartman_mobile/models/imodel.dart';
import 'package:eapartman_mobile/models/iutisak.dart';
import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';

class Utisak implements IModel, IUtisak {
  int utisakId;
  int korisnikId;
  int apartmanId;
  String komentar;
  int ocjenaWiFi;
  int ocjenaLokacija;
  int ocjenaCistoca;
  int ocjenaVlasnik;
  Rezervacija rezervacija;
  Korisnik korisnik;
  Utisak({
    this.utisakId,
    this.korisnikId,
    this.apartmanId,
    this.komentar,
    this.ocjenaCistoca,
    this.ocjenaLokacija,
    this.ocjenaVlasnik,
    this.ocjenaWiFi,
    this.korisnik,
    this.rezervacija,
  });
  factory Utisak.fromJson(Map<String, dynamic> json) {
    Korisnik korisnik;
    Rezervacija rezervacija;
    try {
      korisnik = Korisnik.fromJson(json["korisnik"]);
      rezervacija = Rezervacija.fromJson(json["utisakNavigation"]);
    } catch (e) {
      korisnik = null;
      rezervacija = null;
    }
    return Utisak(
      utisakId: json["utisakId"],
      korisnikId: json["korisnikId"],
      apartmanId: json["apartmanId"],
      komentar: json["komentar"],
      ocjenaCistoca: json["ocjenaCistoca"],
      ocjenaLokacija: json["ocjenaLokacija"],
      ocjenaVlasnik: json["ocjenaVlasnik"],
      ocjenaWiFi: json["ocjenaWiFi"],
      korisnik: korisnik,
      rezervacija: rezervacija,
    );
  }
  Map<String, dynamic> toJson() => {
        "utisakId": utisakId,
        "korisnikId": korisnikId,
        "apartmanId": apartmanId,
        "komentar": komentar,
        "ocjenaCistoca": ocjenaCistoca,
        "ocjenaLokacija": ocjenaLokacija,
        "ocjenaVlasnik": ocjenaVlasnik,
        "ocjenaWiFi": ocjenaWiFi,
      };
  double Prosjek() {
    return (ocjenaCistoca + ocjenaLokacija + ocjenaVlasnik + ocjenaWiFi) / 4;
  }

  @override
  int CistocaProsjek() {
    return ocjenaCistoca;
  }

  @override
  int LokacijaProsjek() {
    return ocjenaLokacija;
  }

  @override
  int VlasnikProsjek() {
    return ocjenaVlasnik;
  }

  @override
  int WifiProsjek() {
    return ocjenaWiFi;
  }
}
