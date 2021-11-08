import 'package:flutter/material.dart';

class ApartmaniBody extends StatefulWidget {
  const ApartmaniBody();

  @override
  _ApartmaniBodyState createState() => _ApartmaniBodyState();
}

class _ApartmaniBodyState extends State<ApartmaniBody> {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
          padding: EdgeInsets.all(20),
          child: Column(
            children: [
              Text("Apartmani"),
            ],
          )),
    );
  }
}
