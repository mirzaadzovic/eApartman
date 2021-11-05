// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/pages/home.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';
import '../main.dart';

class Login extends StatefulWidget {
  const Login({Key? key}) : super(key: key);

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  void handleClick() async {
    APIService.username = usernameController.text;
    APIService.password = passwordController.text;
    var korisnici = await APIService.Get("Korisnici");

    if (korisnici != null) {
      Navigator.of(context).pushReplacementNamed('/');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("eApartman"),
      ),
      body: Center(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(80, 60, 80, 0),
          child: Column(
            children: [
              Text("Login", style: TextStyle(fontSize: 30)),
              SizedBox(
                height: 40,
              ),
              Input(usernameController, "Username", false),
              SizedBox(
                height: 20,
              ),
              Input(passwordController, "Password", true),
              SizedBox(height: 20),
              Button("Login", handleClick),
            ],
          ),
        ),
      ),
    );
  }
}
