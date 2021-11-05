import 'package:flutter/material.dart';

class Input extends StatelessWidget {
  final TextEditingController? controller;
  final String hint;
  bool passwordField;

  Input(this.controller, this.hint, this.passwordField);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: controller,
      decoration: InputDecoration(
        labelText: hint,
        border: UnderlineInputBorder(),
      ),
      obscureText: passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
