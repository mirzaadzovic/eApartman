import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class ApartmanSearch implements ISearchObject {
  String grad;
  DateTime checkIn;
  DateTime checkOut;
  bool includeSlike;
  bool includeUtisci;
  int osoba;

  ApartmanSearch({
    this.grad,
    this.checkIn,
    this.checkOut,
    this.includeSlike,
    this.includeUtisci,
    this.osoba,
  });
  Map<String, dynamic> toJson() {
    return {
      'grad': grad,
      'checkin': checkIn.toString(),
      'checkout': checkOut.toString(),
      'includeSlike': includeSlike.toString(),
      'includeUtisci': includeUtisci.toString(),
      'osoba': osoba.toString(),
    };
  }
}
