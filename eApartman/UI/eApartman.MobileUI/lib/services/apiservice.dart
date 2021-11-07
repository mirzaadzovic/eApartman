// ignore_for_file: file_names
import 'dart:convert';
import 'dart:core';
import 'dart:io';
import 'package:eapartman_mobile/models/grad.dart';
import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class APIService {
  static String username = "";
  static String password = "";
  static String apiUrl = "http://10.0.2.2:5000/api/";
  static Korisnik korisnik;
  String route;

  APIService({this.route = ""});

  void setParameters(String uname, String pwd) {
    username = uname;
    password = pwd;
  }

  static Future<dynamic> Get(String route, dynamic query) async {
    String baseUrl = apiUrl + route;
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));

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
}
