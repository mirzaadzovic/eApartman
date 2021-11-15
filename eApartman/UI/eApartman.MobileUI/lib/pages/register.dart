import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/search_objects/korisnik_search.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/error_text.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';

class Register extends StatefulWidget {
  const Register({Key key}) : super(key: key);

  @override
  _RegisterState createState() => _RegisterState();
}

class _RegisterState extends State<Register> {
  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController usernameController = TextEditingController();
  TextEditingController telefonController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController passwordPotvrdaController = TextEditingController();
  bool _loading = false;
  String error = "";
  dynamic validacija() {
    if (usernameController.text.length < 3) return "Username prekratan";
    if (imeController.text.length < 2) return "Ime prekratko";
    if (prezimeController.text.length < 3) return "Prezime prekratko";
    if (telefonController.text.length < 8) return "Pogrešan unos telefona";
    if (passwordController.text.length < 4) return "Prekratak password";
    return true;
  }

  void handleClick() async {
    setState(() => _loading = true);
    setState(() => error = "");
    APIService.username = usernameController.text;
    APIService.password = passwordController.text;
    try {
      if (validacija() is String) throw Exception(validacija());
      if (passwordController.text != passwordPotvrdaController.text)
        throw Exception("Password i potvrda se ne poklapaju.");
      Korisnik request = Korisnik(
        ime: imeController.text,
        prezime: prezimeController.text,
        username: usernameController.text,
        email: emailController.text,
        password: passwordController.text,
        passwordPotvrda: passwordPotvrdaController.text,
        telefon: telefonController.text,
        uloge: [1],
      );
      var korisnik = await APIService.Insert(
        "Korisnici",
        request,
      );

      if (korisnik != null) {
        APIService.korisnik = Korisnik.fromJson(korisnik);
        Navigator.of(context)
            .pushNamedAndRemoveUntil('/home', (Route<dynamic> route) => false);
      } else {
        throw Exception("Pogrešno unsesi podaci.");
      }
    } catch (e) {
      setState(() => error = e.toString().substring(10));
      passwordController.text = "";
      passwordPotvrdaController.text = "";
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
                Text("Registracija", style: TextStyle(fontSize: 30)),
                SizedBox(
                  height: 40,
                ),
                Input(
                    controller: imeController,
                    text: "Ime",
                    passwordField: false,
                    icon: Icons.person),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: prezimeController,
                    text: "Prezime",
                    passwordField: false,
                    icon: Icons.person),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: emailController,
                    text: "Email",
                    passwordField: false,
                    icon: Icons.email),
                SizedBox(
                  height: 20,
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
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: passwordPotvrdaController,
                    text: "Password potvrda",
                    passwordField: true,
                    icon: Icons.lock),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: telefonController,
                    text: "Telefon",
                    passwordField: false,
                    icon: Icons.phone),
                SizedBox(height: 20),
                Button(
                    text: "Registruj se",
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
