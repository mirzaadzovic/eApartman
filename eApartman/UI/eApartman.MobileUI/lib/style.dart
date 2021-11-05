import 'package:flutter/material.dart';

const LargeTextSize = 26.0;
const MediumTextSize = 20.0;
const SmallTextSize = 16.0;

const String FontNameDefault = 'Segoe UI';

const NaslovTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black,
  fontSize: LargeTextSize,
  //fontWeight: FontWeight.bold,
);

const PaleTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black26,
  fontSize: LargeTextSize,
  fontWeight: FontWeight.w300,
);

const BodyTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black26,
  fontSize: SmallTextSize,
);

const ErrorTextStyle = TextStyle(
  color: Colors.red,
  fontSize: SmallTextSize,
);
