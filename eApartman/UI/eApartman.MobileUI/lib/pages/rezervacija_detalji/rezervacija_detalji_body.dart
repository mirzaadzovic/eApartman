import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/rezervacija.dart';
import 'package:eapartman_mobile/models/search_objects/rezervacija_update.dart';
import 'package:eapartman_mobile/pages/rezervacija_detalji/rezervacija_utisak.dart';
import 'package:eapartman_mobile/pages/utisci/utisak_dodaj.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:eapartman_mobile/widgets/button.dart';
import 'package:eapartman_mobile/widgets/poruka_dialog.dart';
import 'package:flutter/material.dart';

class RezervacijaDetaljiBody extends StatelessWidget {
  Rezervacija rezervacija;
  Function setRezervacija;
  RezervacijaDetaljiBody(this.rezervacija, this.setRezervacija);

  void handleOtkazi(BuildContext context) async {
    var request = RezervacijaUpdate(
      checkin: Helpers.DateOnly(rezervacija.checkIn),
      checkout: Helpers.DateOnly(rezervacija.checkOut),
      izvrsena: false,
      otkazana: true,
    );
    try {
      final response = await APIService.Update(
          "Rezervacije", rezervacija.rezervacijaId, request);

      if (response != null) {
        await PorukaDialog.poruka(
          msg: 'Rezervacija otkazana!',
          handleClick: () => Navigator.pop(context, 'OK'),
          context: context,
        );
        Navigator.pop(context);
      }
    } catch (e) {
      await PorukaDialog.poruka(
        msg: e.toString(),
        handleClick: () => Navigator.pop(context, 'OK'),
        context: context,
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Center(
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text(rezervacija.apartman.naziv, style: NaslovTextStyle),
              SizedBox(height: 20),
              Image(
                  image: MemoryImage(rezervacija.apartman.slikaProfilnaFile),
                  fit: BoxFit.cover,
                  height: 250,
                  width: 400),
              SizedBox(height: 20),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: [
                  Text("Grad: " + rezervacija.apartman.gradNaziv,
                      style: BodyTextStyle),
                  Text(
                      "Cijena: " + rezervacija.cijena.round().toString() + " €",
                      style: BodyTextStyle),
                  Text("Broj osoba: " + rezervacija.brojOsoba.toString(),
                      style: BodyTextStyle),
                  Text("Status: " + rezervacija.Status(), style: BodyTextStyle),
                ],
              ),
              SizedBox(height: 20),
              rezervacija.izvrsena
                  ? RezervacijaUtisakBody(context, rezervacija, setRezervacija)
                  : SizedBox(),
              rezervacija.otkazana || rezervacija.izvrsena
                  ? SizedBox()
                  : Button(
                      text: "Otkaži", handleClick: () => handleOtkazi(context)),
            ],
          ),
        ),
      ),
    );
  }
}
