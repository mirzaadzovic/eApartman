import 'package:flutter/material.dart';

class Avatar extends StatelessWidget {
  ClipRRect _slika;
  Avatar({List<int> slika = const []}) {
    _slika = getImage(slika);
  }
  @override
  Widget build(BuildContext context) {
    return _slika;
  }

  ClipRRect getImage(List<int> slika) {
    if (slika.isEmpty)
      return ClipRRect(
        borderRadius: BorderRadius.circular(1000),
        child: Image.asset(
          "assets/images/user-default-avatar.png",
          height: 100,
          width: 100,
          fit: BoxFit.cover,
        ),
      );
    else
      return ClipRRect(
        borderRadius: BorderRadius.circular(1000),
        child: Image(
          image: MemoryImage(slika),
          fit: BoxFit.cover,
          height: 100,
          width: 100,
        ),
      );
  }
}
