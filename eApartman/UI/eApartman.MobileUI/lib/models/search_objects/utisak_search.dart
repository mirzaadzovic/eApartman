import 'package:eapartman_mobile/models/search_objects/search_object.dart';
import 'package:eapartman_mobile/models/utisak.dart';

class UtisakSearch implements ISearch {
  int apartmanId;
  int gostId;
  List<String> includeList;
  UtisakSearch({this.apartmanId, this.gostId, this.includeList = const []});
  Map<String, dynamic> toJson() => {
        "apartmanId": apartmanId.toString(),
        "gostId": gostId.toString(),
        "includeList": includeList,
      };
}
