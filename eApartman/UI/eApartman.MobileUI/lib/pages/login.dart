// ignore_for_file: prefer_const_constructors

import 'package:eapartman_mobile/pages/home.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
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
    if (korisnici != null) Navigator.of(context).pushReplacementNamed('/');
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
              TextField(
                controller: usernameController,
                decoration: InputDecoration(
                  hintText: "Username",
                ),
                style: TextStyle(
                  fontSize: 20,
                ),
              ),
              SizedBox(
                height: 20,
              ),
              TextField(
                controller: passwordController,
                decoration: InputDecoration(
                  hintText: "Password",
                ),
                obscureText: true,
                style: TextStyle(
                  fontSize: 22,
                ),
              ),
              SizedBox(height: 20),
              Container(
                width: double.infinity,
                height: 40,
                child: ElevatedButton(
                  onPressed: handleClick,
                  child: const Text(
                    "Login",
                    style: TextStyle(color: Colors.white, fontSize: 22),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
