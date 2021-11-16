import 'package:eapartman_mobile/models/search_objects/search_object.dart';
import 'package:eapartman_mobile/models/utisak.dart';

class UtisakSearch implements ISearch {
  int apartmanId;
  UtisakSearch({this.apartmanId});
  Map<String, dynamic> toJson() => {
        "apartmanId": apartmanId.toString(),
      };
}
