import 'package:flutter/material.dart';

class PorukaDialog {
  static Future<void> poruka(
      {String msg, Function handleClick, BuildContext context}) async {
    return showDialog(
      context: context,
      builder: (BuildContext context) => AlertDialog(
        title: const Text('Poruka'),
        content: Text(msg),
        actions: [
          TextButton(
            onPressed: handleClick,
            child: const Text('OK'),
          ),
        ],
      ),
    );
  }
}
