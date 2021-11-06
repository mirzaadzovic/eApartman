import 'package:flutter/material.dart';

class Input extends StatelessWidget {
  final TextEditingController? controller;
  final String text;
  bool passwordField;

  Input(this.controller, this.text, this.passwordField);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: controller,
      decoration: InputDecoration(
        labelText: text,
        border: UnderlineInputBorder(),
      ),
      obscureText: passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
