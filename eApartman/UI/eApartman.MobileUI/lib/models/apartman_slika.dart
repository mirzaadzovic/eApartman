import 'dart:convert';

class ApartmanSlika {
  int slikaId;
  List<int> slikaFile;
  int apartmanId;

  ApartmanSlika({this.slikaFile, this.slikaId, this.apartmanId});

  factory ApartmanSlika.fromJson(Map<String, dynamic> json) {
    String stringBytes = json["slikaFile"] as String;
    List<int> bytes = base64.decode(stringBytes);
    return ApartmanSlika(
      slikaId: json["slikaId"],
      slikaFile: bytes,
      apartmanId: json["apartmanId"],
    );
  }
}
