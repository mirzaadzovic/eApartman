import 'package:eapartman_mobile/style.dart';
import 'package:flutter/material.dart';

class ErrorText extends StatelessWidget {
  String text;
  ErrorText(this.text);

  @override
  Widget build(BuildContext context) {
    return Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        SizedBox(
          height: 20,
        ),
        Text(
          text,
          style: ErrorTextStyle,
          maxLines: 1,
        ),
      ],
    );
  }
}
