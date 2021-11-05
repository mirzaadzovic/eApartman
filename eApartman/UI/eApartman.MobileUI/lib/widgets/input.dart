import 'package:flutter/material.dart';

class Input extends StatelessWidget {
  final TextEditingController? _controller;
  final String _hint;
  bool _passwordField;

  Input(this._controller, this._hint, this._passwordField);

  @override
  Widget build(BuildContext context) {
    return TextField(
      controller: _controller,
      decoration: InputDecoration(
        hintText: _hint,
      ),
      obscureText: _passwordField,
      style: TextStyle(
        fontSize: 20,
      ),
    );
  }
}
