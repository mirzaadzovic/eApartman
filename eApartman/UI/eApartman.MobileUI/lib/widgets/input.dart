import 'package:flutter/material.dart';

class Input extends StatelessWidget {
  TextEditingController? _controller;
  String _hint;
  bool _password;

  Input(this._controller, this._hint, this._password);

  @override
  Widget build(BuildContext context) {
    return TextField(
      controller: _controller,
      decoration: InputDecoration(
        hintText: _hint,
      ),
      obscureText: _password,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
