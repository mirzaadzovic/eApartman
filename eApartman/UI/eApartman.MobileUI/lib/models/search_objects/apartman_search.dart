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
      'checkin': checkIn,
      'checkout': checkOut,
      'includeSlike': includeSlike,
      'includeUtisci': includeUtisci,
      'osoba': osoba,
    };
  }
}
