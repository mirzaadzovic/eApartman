import 'package:flutter/material.dart';

Widget DropDown(Function setDropDown, String dropdownValue) {
  return DropdownButton<String>(
    value: dropdownValue,
    icon: const Icon(Icons.arrow_downward),
    iconSize: 24,
    elevation: 16,
    style: const TextStyle(color: Colors.black54),
    underline: Container(
      height: 2,
      color: Colors.blue,
    ),
    onChanged: (String newValue) {
      setDropDown(newValue);
    },
    items: <String>['Sve', 'Kreirana', 'Izvršena', 'U toku', 'Otkazana']
        .map<DropdownMenuItem<String>>((String value) {
      return DropdownMenuItem<String>(
        value: value,
        child: Text(value),
      );
    }).toList(),
  );
}
