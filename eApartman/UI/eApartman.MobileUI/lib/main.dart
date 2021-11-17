import 'package:eapartman_mobile/models/search_objects/apartman_search.dart';
import 'package:eapartman_mobile/pages/apartmani/apartmani.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'pages/home/home.dart';
import 'pages/login.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey =
      "pk_test_51JwnUmHsjqdF5wnu9tHsGr2tGBV6eRu4WugPXQbxCv5LY0SXwfCm9bJNtEGRmLSSnNFQ8G0ce3i7nOvEbV0O5HYu00tahSXp9R";

  await Stripe.instance.applySettings();
  runApp(const App());
}

class App extends StatelessWidget {
  const App({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eApartman',
      home: Login(),
      routes: {
        '/home': (context) => const Home(),
        '/apartmani': (context) => Apartmani(search: ApartmanSearch()),
        '/login': (context) => const Login(),
      },
    );
  }
}
