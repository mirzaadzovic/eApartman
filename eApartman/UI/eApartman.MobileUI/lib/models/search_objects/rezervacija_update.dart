import 'package:eapartman_mobile/models/imodel.dart';

class RezervacijaUpdate implements IModel {
  DateTime checkin;
  DateTime checkout;
  bool izvrsena;
  bool otkazana;
  RezervacijaUpdate(
      {this.checkin, this.checkout, this.izvrsena, this.otkazana});
  Map<String, dynamic> toJson() => {
        "DatumCheckIn": checkin.toIso8601String(),
        "DatumCheckOut": checkout.toIso8601String(),
        "Izvrsena": izvrsena,
        "Otkazana": otkazana,
      };
}
