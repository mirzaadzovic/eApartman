// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/search_objects/korisnik_search.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/pages/register.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
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
  bool validacija() {}
  void handleClick() async {
    setState(() => _loading = true);
    APIService.username = usernameController.text;
    APIService.password = passwordController.text;
    try {
      var korisnici = await APIService.Get(
          "Korisnici", KorisnikSearch(username: usernameController.text));
      if (korisnici != null) {
        Korisnik korisnik =
            (korisnici as List).map((k) => Korisnik.fromJson(k)).toList().first;
        APIService.korisnik = korisnik;
        Navigator.of(context).pushReplacementNamed('/home');
      } else {
        throw Exception("Pogrešan username ili password.");
      }
    } catch (e) {
      setState(() => error = e.toString().substring(10));
      passwordController.text = "";
      setState(() => _loading = false);
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
                GestureDetector(
                  onTap: () {
                    Navigator.push(context,
                        MaterialPageRoute(builder: (context) => Register()));
                  },
                  child: Padding(
                    padding: const EdgeInsets.all(10),
                    child: Text("Nemaš nalog? Registruj se...",
                        style: SmallLinkTextStyle),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
