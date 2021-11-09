import 'package:flutter/material.dart';

class Input extends StatelessWidget {
  IconData icon;
  final TextEditingController controller;
  final String text;
  bool passwordField;
  Input({
    this.controller,
    this.text,
    this.passwordField,
    this.icon = null,
  });

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: this.controller,
      decoration: InputDecoration(
        icon: Icon(icon),
        labelText: this.text,
        border: UnderlineInputBorder(),
      ),
      obscureText: this.passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
