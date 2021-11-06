import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';

class IconInput extends Input {
  IconData icon;
  IconInput(TextEditingController controller, String text, bool passwordField,
      this.icon)
      : super(controller, text, passwordField);

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
