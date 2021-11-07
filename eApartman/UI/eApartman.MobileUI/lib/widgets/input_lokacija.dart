import 'package:eapartman_mobile/models/grad.dart';
import 'package:eapartman_mobile/models/search_objects/grad_search.dart';
import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';
import 'package:flutter_typeahead/flutter_typeahead.dart';

class InputLokacija extends StatelessWidget {
  IconData icon;
  String text;
  String lokacija;
  TextEditingController controller;
  Function setLokacija;

  InputLokacija(
      {this.controller, this.lokacija, this.text, this.icon, this.setLokacija});
  @override
  Widget build(BuildContext context) {
    return TypeAheadField(
      textFieldConfiguration: TextFieldConfiguration(
          autofocus: true,
          enableInteractiveSelection: true,
          controller: controller,
          decoration: InputDecoration(
            icon: Icon(icon),
            labelText: this.text,
            border: UnderlineInputBorder(),
          )),
      debounceDuration: Duration(milliseconds: 500),
      suggestionsCallback: (pattern) async {
        GradSearch search = GradSearch(query: pattern);
        var gradovi = await APIService.Get("gradovi", search);
        setLokacija(pattern);
        return gradovi;
      },
      itemBuilder: (context, suggestion) {
        return ListTile(
          leading: Icon(Icons.location_city),
          title: Text(suggestion['naziv']),
          subtitle: Text('${suggestion['drzavaNaziv']}'),
        );
      },
      onSuggestionSelected: (suggestion) {
        controller.text = suggestion["naziv"];
        ScaffoldMessenger.of(context)
          ..removeCurrentSnackBar()
          ..showSnackBar(SnackBar(content: Text(suggestion["naziv"])));
        setLokacija(suggestion["naziv"]);
      },
      noItemsFoundBuilder: (context) => Center(
        child: Text("Lokacija nije pronađena.", style: BodyTextStyle),
      ),
      transitionBuilder: (context, suggestionsBox, controller) {
        return suggestionsBox;
      },
      // validator: (value) {
      //   if (value.isEmpty) {
      //     return 'Please select a city';
      //   }
      // },
      // onSaved: (value) => this.lokacija = value,
    );
  }
}
