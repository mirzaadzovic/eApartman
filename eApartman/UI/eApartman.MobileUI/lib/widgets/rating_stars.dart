import 'package:eapartman_mobile/style.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'package:flutter_rating_bar/flutter_rating_bar.dart';

class RatingStars extends StatelessWidget {
  Function func;
  String title;
  RatingStars({this.func, this.title});
  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(title, style: BodyTextStyle),
          RatingBar.builder(
            initialRating: 3,
            minRating: 1,
            direction: Axis.horizontal,
            allowHalfRating: false,
            itemCount: 5,
            itemPadding: EdgeInsets.symmetric(horizontal: 4.0),
            itemBuilder: (context, _) => Icon(
              Icons.star,
              color: Colors.blue,
            ),
            onRatingUpdate: (rating) {
              int value = rating.round();
              func(value);
            },
          ),
        ],
      ),
    );
  }
}
