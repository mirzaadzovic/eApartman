import 'package:flutter/material.dart';

class Loading extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(10),
      child: Container(
        child: Image.asset(
          "assets/images/loading.gif",
          width: 100,
        ),
      ),
    );
  }
}
