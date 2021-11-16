import 'package:eapartman_mobile/models/iutisak.dart';

class ApartmanOcjene implements IUtisak {
  double wifi;
  double lokacija;
  double cistoca;
  double vlasnik;
  ApartmanOcjene({this.cistoca, this.lokacija, this.vlasnik, this.wifi});
  double Prosjek() {
    return (cistoca + lokacija + vlasnik + wifi) / 4;
  }

  @override
  double CistocaProsjek() {
    return cistoca;
  }

  @override
  double LokacijaProsjek() {
    return lokacija;
  }

  @override
  double VlasnikProsjek() {
    return vlasnik;
  }

  @override
  double WifiProsjek() {
    return wifi;
  }
}
