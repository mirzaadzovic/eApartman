import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';

class IconInput extends Input {
  IconData _icon;
  IconInput(TextEditingController controller, String hint, bool passwordField,
      this._icon)
      : super(controller, hint, passwordField);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: this.controller,
      decoration: InputDecoration(
        icon: Icon(_icon),
        labelText: this.hint,
        border: UnderlineInputBorder(),
      ),
      obscureText: this.passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
