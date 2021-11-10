import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class KorisnikSearch implements ISearchObject {
  String username;

  KorisnikSearch({this.username});
  Map<String, dynamic> toJson() => {"username": username};
}
