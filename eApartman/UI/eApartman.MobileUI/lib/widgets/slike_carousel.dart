import 'package:carousel_slider/carousel_slider.dart';
import 'package:flutter/material.dart';

class SlikeCarousel extends StatelessWidget {
  List<List<int>> slike;
  SlikeCarousel({this.slike});

  @override
  Widget build(BuildContext context) {
    return CarouselSlider.builder(
      options: CarouselOptions(
        enlargeCenterPage: true,
        enableInfiniteScroll: false,
        height: 250,
      ),
      itemCount: slike.length,
      itemBuilder: (BuildContext context, int itemIndex, int pageViewIndex) =>
          Container(
        child: Image(
          image: MemoryImage(slike[pageViewIndex]),
          fit: BoxFit.cover,
          width: double.infinity,
        ),
      ),
    );
  }
}
