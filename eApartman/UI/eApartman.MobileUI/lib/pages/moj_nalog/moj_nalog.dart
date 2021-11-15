import 'package:eapartman_mobile/models/korisnik.dart';
import 'package:eapartman_mobile/models/search_objects/korisnik_search.dart';
import 'package:eapartman_mobile/pages/loading/loading.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/avatar.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/error_text.dart';
import 'package:eapartman_mobile/widgets/input.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
import 'package:flutter/material.dart';

class MojNalog extends StatefulWidget {
  const MojNalog({Key key}) : super(key: key);

  @override
  _MojNalogState createState() => _MojNalogState();
}

class _MojNalogState extends State<MojNalog> {
  TextEditingController imeController =
      TextEditingController(text: APIService.korisnik.ime);
  TextEditingController prezimeController =
      TextEditingController(text: APIService.korisnik.prezime);
  TextEditingController telefonController =
      TextEditingController(text: APIService.korisnik.telefon);
  TextEditingController oldPasswordController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController passwordPotvrdaController = TextEditingController();
  bool _loading = false;
  String error = "";
  dynamic validacija() {
    if (oldPasswordController.text != APIService.password)
      return "Pogrešan stari password";
    if (imeController.text.length < 2) return "Ime prekratko";
    if (prezimeController.text.length < 3) return "Prezime prekratko";
    if (telefonController.text.length < 8) return "Pogrešan unos telefona";
    return true;
  }

  void handleClick() async {
    setState(() => _loading = true);
    setState(() => error = "");
    try {
      if (validacija() is String) throw Exception(validacija());
      if (passwordController.text != passwordPotvrdaController.text)
        throw Exception("Password i potvrda se ne poklapaju.");
      Korisnik request = Korisnik(
        ime: imeController.text,
        prezime: prezimeController.text,
        password: passwordController.text,
        passwordPotvrda: passwordPotvrdaController.text,
        telefon: telefonController.text,
        slika: APIService.korisnik.slika,
        uloge: [],
        status: true,
        oldPassword: oldPasswordController.text,
      );
      var korisnik = await APIService.Update(
        "Korisnici",
        APIService.korisnik.korisnikId,
        request,
      );

      if (korisnik != null) {
        APIService.korisnik = Korisnik.fromJson(korisnik);
        await PorukaDialog.poruka(
            context: context,
            msg: "Nalog ažuriran!",
            handleClick: () => Navigator.pop(context, 'OK'));
        Navigator.pop(context);
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
                Text("Moj nalog", style: TextStyle(fontSize: 30)),
                SizedBox(
                  height: 20,
                ),
                Padding(
                  padding: const EdgeInsets.all(20),
                  child: Avatar(slika: APIService.korisnik.slika, radius: 100),
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
                    controller: oldPasswordController,
                    text: "Stari password",
                    passwordField: true,
                    icon: Icons.lock),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: passwordController,
                    text: "Novi password",
                    passwordField: true,
                    icon: Icons.lock),
                SizedBox(
                  height: 20,
                ),
                Input(
                    controller: passwordPotvrdaController,
                    text: "Novi password potvrda",
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
                    text: "Sačuvaj",
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
