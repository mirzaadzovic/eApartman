import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class ApartmanSlikaSearch implements ISearchObject {
  int apartmanId;
  ApartmanSlikaSearch({this.apartmanId});
  Map<String, dynamic> toJson() => {
        " apartmanId": apartmanId,
      };
}
