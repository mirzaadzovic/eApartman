import 'package:eapartman_mobile/pages/apartmani/apartmani.dart';
import 'package:flutter/material.dart';
import 'pages/home/home.dart';
import 'pages/login.dart';

void main() => runApp(const App());

class App extends StatelessWidget {
  const App({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eApartman',
      home: Login(),
      routes: {
        '/home': (context) => const Home(),
        '/apartmani': (context) => const Apartmani(),
      },
    );
  }
}
