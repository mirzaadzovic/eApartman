import 'package:flutter/material.dart';

class Button extends StatelessWidget {
  String text;
  Function handleClick;
  Button(this.text, this.handleClick);
  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      height: 40,
      child: ElevatedButton(
        onPressed: () => handleClick(),
        child: const Text(
          "Login",
          style: TextStyle(color: Colors.white, fontSize: 22),
        ),
      ),
    );
  }
}
