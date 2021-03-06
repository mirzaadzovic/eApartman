// ignore_for_file: file_names
import 'dart:convert';
import 'dart:core';
import 'dart:io';
import 'package:eapartman_mobile/models/grad.dart';
import 'package:eapartman_mobile/models/imodel.dart';
import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/search_objects/search_object.dart';
import 'package:eapartman_mobile/pages/login.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class APIService {
  static String username = "";
  static String password = "";
  static String apiUrl = "http://10.0.2.2:5013/api/";
  static Korisnik korisnik;
  String route;

  APIService({this.route = ""});

  void setParameters(String uname, String pwd) {
    username = uname;
    password = pwd;
  }

  static Future<dynamic> Get(String route, ISearch search) async {
    String baseUrl = apiUrl + route;
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));
    if (search != null) baseUrl += "?${toQueryString(search)}";
    print(baseUrl);

    try {
      final response = await http.get(Uri.parse(baseUrl),
          headers: {HttpHeaders.authorizationHeader: basicAuth});

      if (response.statusCode == 200) {
        return JsonDecoder().convert(response.body) as List;
      } else
        return null;
    } catch (e) {
      return null;
    }
  }

  static Future<Map<String, dynamic>> GetById(String route, int id) async {
    String baseUrl = apiUrl + route + "/$id";
    String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));
    final response = await http.get(Uri.parse(baseUrl),
        headers: {HttpHeaders.authorizationHeader: basicAuth});
    if (response.statusCode == 200 && response.body != null) {
      return jsonDecode(response.body);
    }
    return null;
  }

  static Future<dynamic> Insert(String route, IModel request) async {
    String baseUrl = apiUrl + route;
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));
    final bodyJson = json.encode(request.toJson());
    try {
      final response = await http.post(Uri.parse(baseUrl),
          headers: {
            HttpHeaders.authorizationHeader: basicAuth,
            HttpHeaders.contentTypeHeader: 'application/json; charset=UTF-8',
          },
          body: bodyJson);

      print(response.statusCode);
      if (response.statusCode == 201 || response.statusCode == 200)
        return jsonDecode(response.body);
      else
        return null;
    } catch (e) {
      return null;
    }
  }

  static Future<dynamic> Update(String route, int id, IModel request) async {
    String baseUrl = apiUrl + route + "/$id";
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));
    final bodyJson = json.encode(request.toJson());
    try {
      final response = await http.put(
        Uri.parse(baseUrl),
        headers: {
          HttpHeaders.authorizationHeader: basicAuth,
          HttpHeaders.contentTypeHeader: 'application/json; charset=UTF-8',
        },
        body: bodyJson,
      );
      print(response);
      if (response.statusCode == 200 || response.statusCode == 201) {
        return jsonDecode(response.body);
      }
      return null;
    } catch (e) {
      print(e.toString());
      return null;
    }
  }

  static String toQueryString(ISearch search) {
    String queryString = Uri(queryParameters: search.toJson()).query;
    return queryString;
  }

  static void clear() {
    APIService.korisnik = null;
    APIService.username = null;
    APIService.password = null;
  }

  static void logout(BuildContext context) {
    APIService.clear();
    Navigator.of(context)
        .pushNamedAndRemoveUntil('/login', (Route<dynamic> route) => false);
  }
}
