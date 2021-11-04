import 'package:eapartman_mobile/services/apiservice.dart';
import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  String username = APIService.username;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eApartman")),
      drawer: Drawer(),
      body: Padding(
        padding: const EdgeInsets.all(50),
        child: Container(
          child: Text(
            "Dobrodošo $username",
            style: TextStyle(fontSize: 30),
          ),
        ),
      ),
    );
  }
}
