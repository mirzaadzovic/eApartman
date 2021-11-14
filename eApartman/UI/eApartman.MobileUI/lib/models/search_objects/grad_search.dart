import 'package:eapartman_mobile/models/search_objects/search_object.dart';

class GradSearch implements ISearch {
  String query;
  String naziv;
  String drzava;

  GradSearch({this.naziv, this.drzava, this.query});

  Map<String, dynamic> toJson() => {
        'query': query,
        'naziv': naziv,
        'drzava': drzava,
      };
}
