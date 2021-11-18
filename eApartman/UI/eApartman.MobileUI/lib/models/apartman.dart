import 'dart:convert';
import 'dart:core';
import 'dart:core';

import 'package:eapartman_mobile/models/apartman_ocjene.dart';
import 'package:eapartman_mobile/models/apartman_slika.dart';
import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/models/utisak.dart';
import 'package:eapartman_mobile/services/apiservice.dart';

class Apartman {
  int apartmanId;
  String naziv;
  int vlasnikId;
  String adresaNaziv;
  String gradNaziv;
  int maxOsoba;
  bool imaBalkon;
  bool imaParking;
  bool petFriendly;
  double cijena;
  DateTime datumSlobodan;
  List<int> slikaProfilnaFile;
  List<ApartmanSlika> apartmanSlikas;
  List<Utisak> utisci;
  ApartmanSearch search;
  Apartman(
      {this.apartmanId,
      this.naziv,
      this.vlasnikId,
      this.adresaNaziv,
      this.gradNaziv,
      this.maxOsoba,
      this.imaBalkon,
      this.imaParking,
      this.petFriendly,
      this.cijena,
      this.slikaProfilnaFile,
      this.apartmanSlikas,
      this.utisci,
      this.datumSlobodan});

  factory Apartman.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaProfilnaFile"] as String;
    List<int> bytes = base64.decode(stringByte);
    List<ApartmanSlika> slike = (json["apartmanSlikas"] as List)
        .map((s) => ApartmanSlika.fromJson(s))
        .toList();
    List<Utisak> utisaks;
    try {
      utisaks =
          (json["utisaks"] as List).map((u) => Utisak.fromJson(u)).toList();
    } catch (e) {
      utisaks = [];
    }

    return Apartman(
      apartmanId: json["apartmanId"],
      naziv: json["naziv"],
      vlasnikId: json["vlasnikId"],
      adresaNaziv: json["adresaNaziv"],
      gradNaziv: json["gradNaziv"],
      maxOsoba: json["maxOsoba"],
      imaBalkon: json["imaBalkon"],
      imaParking: json["imaParking"],
      petFriendly: json["petFriendly"],
      cijena: json["cijena"],
      slikaProfilnaFile: bytes,
      apartmanSlikas: slike,
      utisci: utisaks,
      datumSlobodan: DateTime.parse(json["datumSlobodan"]),
    );
  }

  Map<String, dynamic> toJson() {
    return {
      //"apartmanId": apartmanId,
      "naziv": naziv,
      "vlasnikId": vlasnikId,
      "adresaNaziv": adresaNaziv,
      "gradNaziv": gradNaziv,
      "maxOsoba": maxOsoba,
      "imaBalkon": imaBalkon,
      "imaParking": imaParking,
      "petFriendly": petFriendly,
      "cijena": cijena,
      "slikaProfilnaFile": slikaProfilnaFile,
    };
  }

  ApartmanOcjene OcjeneProsjek() {
    double wifi = WiFiProsjek();
    double lokacija = LokacijaProsjek();
    double cistoca = CistocaProsjek();
    double vlasnik = VlasnikProsjek();
    return ApartmanOcjene(
      cistoca: cistoca,
      lokacija: lokacija,
      wifi: wifi,
      vlasnik: vlasnik,
    );
  }

  double WiFiProsjek() {
    double wifi = 0;
    utisci.forEach((element) {
      wifi += element.ocjenaWiFi;
    });

    return wifi / utisci.length;
  }

  double LokacijaProsjek() {
    double lokacija = 0;
    utisci.forEach((element) {
      lokacija += element.ocjenaLokacija;
    });
    return lokacija / utisci.length;
  }

  double CistocaProsjek() {
    double cistoca = 0;
    utisci.forEach((element) {
      cistoca += element.ocjenaCistoca;
    });
    return cistoca / utisci.length;
  }

  double VlasnikProsjek() {
    double vlasnik = 0;
    utisci.forEach((element) {
      vlasnik += element.ocjenaVlasnik;
    });
    return vlasnik / utisci.length;
  }
}
