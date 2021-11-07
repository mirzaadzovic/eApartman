import 'package:eapartman_mobile/pages/home/home_body.dart';
import 'package:eapartman_mobile/widgets/my_drawer.dart';
import 'package:flutter/material.dart';

class Home extends StatelessWidget {
  const Home({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("eApartman")),
      drawer: MyDrawer(),
      drawerEnableOpenDragGesture: true,
      body: HomeBody(),
    );
  }
}
