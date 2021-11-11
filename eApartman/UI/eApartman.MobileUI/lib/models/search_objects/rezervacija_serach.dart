import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class RezervacijaSearch implements ISearchObject {
  int gostId;
  List<String> includeList;
  RezervacijaSearch({this.gostId, this.includeList = const []});

  Map<String, dynamic> toJson() =>
      {"gostId": gostId.toString(), "includeList": includeList};
}
