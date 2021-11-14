import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class RezervacijaSearch implements ISearch {
  int gostId;
  List<String> includeList;
  int rezervacijaId;
  RezervacijaSearch({this.gostId, this.includeList = const []});

  Map<String, dynamic> toJson() =>
      {"gostId": gostId.toString(), "includeList": includeList};
}
