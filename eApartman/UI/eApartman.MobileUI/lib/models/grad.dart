import 'dart:convert';
import 'dart:io';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:http/http.dart' as http;

class Grad {
  int gradId;
  String naziv;
  int postanskiBroj;
  int drzavaId;
  String drzavaNaziv;

  Grad({
    this.gradId,
    this.naziv,
    this.postanskiBroj,
    this.drzavaId,
    this.drzavaNaziv,
  });

  factory Grad.fromJson(Map<String, dynamic> json) {
    return Grad(
      gradId: json["gradId"],
      naziv: json["naziv"],
      postanskiBroj: json["postanskiBroj"],
      drzavaId: json["drzavaId"],
      drzavaNaziv: json["drzavaNaziv"],
    );
  }

  Map<String, dynamic> toJson() => {
        "naziv": naziv,
        "drzavaId": drzavaId,
        "postanskiBroj": postanskiBroj,
      };
  static Future<dynamic> Get(String query) async {
    String username = APIService.username;
    String password = APIService.password;
    String baseUrl = APIService.apiUrl + "gradovi";

    if (query != null) {
      baseUrl += "?";
      if (!query.isEmpty && query != null) baseUrl += "query=${query}";
    }
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));

    try {
      final response = await http.get(Uri.parse(baseUrl),
          headers: {HttpHeaders.authorizationHeader: basicAuth});

      if (response.statusCode == 200) {
        print(response.body);
        return JsonDecoder().convert(response.body) as List;
      } else
        return null;
    } catch (e) {
      return null;
    }
  }
}
