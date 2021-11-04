// ignore_for_file: file_names
import 'dart:convert';
import 'dart:core';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class APIService {
  static String username = "";
  static String password = "";
  String route;

  APIService({this.route = ""});

  void setParameters(String uname, String pwd) {
    username = uname;
    password = pwd;
  }

  static Future<dynamic> Get(String route) async {
    String baseUrl =
        "http://10.0.2.2:5000/api/" + route + "?username=$username";
    final String basicAuth =
        "basic " + base64Encode(utf8.encode("$username:$password"));

    try {
      final response = await http.get(Uri.parse(baseUrl),
          headers: {HttpHeaders.authorizationHeader: basicAuth});

      if (response.statusCode == 200) {
        print(response.body);
        return JsonDecoder().convert(response.body);
      }
    } catch (e) {
      return null;
    }
    return null;
  }
}
