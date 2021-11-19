import 'package:flutter/material.dart';

const LargeTextSize = 26.0;
const MediumTextSize = 21.0;
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
  color: Colors.black54,
  fontSize: LargeTextSize,
  fontWeight: FontWeight.w300,
);

const BodyTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black54,
  fontSize: MediumTextSize,
);
const BoldBodyTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black54,
  fontSize: MediumTextSize,
  fontWeight: FontWeight.bold,
);
const OcjenaTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Color.fromRGBO(250, 250, 250, 100),
  fontSize: MediumTextSize,
  fontWeight: FontWeight.bold,
);
const KomentarTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black54,
  fontSize: MediumTextSize,
  fontStyle: FontStyle.italic,
);

const PodNaslovTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black54,
  fontSize: SmallTextSize,
);

const ErrorTextStyle = TextStyle(
  color: Colors.red,
  fontSize: SmallTextSize,
);

const LinkTextStyle = TextStyle(
  color: Colors.blue,
  fontSize: MediumTextSize,
  decoration: TextDecoration.underline,
);

const SmallLinkTextStyle = TextStyle(
  color: Colors.blue,
  fontSize: SmallTextSize,
  decoration: TextDecoration.underline,
);

const PreporukaTextStyle = TextStyle(
  fontFamily: FontNameDefault,
  color: Colors.black,
  fontSize: MediumTextSize,
  //fontWeight: FontWeight.bold,
);
