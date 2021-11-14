import 'package:flutter/material.dart';

class TextArea extends StatelessWidget {
  String text;
  TextEditingController controller;
  TextArea(this.text, this.controller);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: <Widget>[
        Card(
            borderOnForeground: true,
            color: Color.fromRGBO(250, 250, 250, 1),
            child: Padding(
              padding: EdgeInsets.all(10),
              child: TextField(
                style: TextStyle(fontSize: 20),
                maxLines: 4,
                decoration: InputDecoration.collapsed(
                  hintText: text,
                ),
                controller: controller,
              ),
            ))
      ],
    );
  }
}
