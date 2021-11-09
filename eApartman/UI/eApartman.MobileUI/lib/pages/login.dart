// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/error_text.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';

class Login extends StatefulWidget {
  const Login({Key key}) : super(key: key);

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  bool _loading = false;
  String error = "";

  void handleClick() async {
    setState(() => _loading = true);
    APIService.username = usernameController.text;
    APIService.password = passwordController.text;
    var korisnici = await APIService.Get("Korisnici", null);

    if (korisnici != null) {
      Navigator.of(context).pushReplacementNamed('/home');
    } else {
      setState(() => error = "Pogrešan username ili password.");
      passwordController.text = "";
    }
    setState(() => _loading = false);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("eApartman"),
      ),
      body: Center(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(60, 0, 60, 0),
          child: SingleChildScrollView(
            child: Column(
              children: [
                _loading ? Loading() : SizedBox(height: 20),
                Text("Login", style: TextStyle(fontSize: 30)),
                SizedBox(
                  height: 40,
                ),
                Input(
                    controller: usernameController,
                    text: "Username",
                    passwordField: false,
                    icon: Icons.person),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: passwordController,
                    text: "Password",
                    passwordField: true,
                    icon: Icons.lock),
                SizedBox(height: 20),
                Button(
                    text: "Login",
                    handleClick: _loading ? () => {} : handleClick),
                ErrorText(error),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
