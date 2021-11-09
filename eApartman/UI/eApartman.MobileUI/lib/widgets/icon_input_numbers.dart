import 'package:eapartman_mobile/widgets/input.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class IconInputNum extends Input {
  IconInputNum(TextEditingController controller, String text,
      bool passwordField, IconData icon)
      : super(
            controller: controller,
            text: text,
            passwordField: passwordField,
            icon: icon);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: this.controller,
      decoration: InputDecoration(
        icon: Icon(this.icon),
        labelText: this.text,
        border: UnderlineInputBorder(),
      ),
      obscureText: this.passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
      keyboardType: TextInputType.number,
      inputFormatters: <TextInputFormatter>[
        FilteringTextInputFormatter.digitsOnly
      ],
    );
  }
}
