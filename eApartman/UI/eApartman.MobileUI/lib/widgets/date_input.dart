import 'package:eapartman_mobile/style.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class DateInput extends StatelessWidget {
  DateTime _date;
  String _text;
  Function setState;
  DateFormat formatter = DateFormat('d.M.yyyy.');

  DateInput(this._date, this._text, this.setState);
  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        Icon(Icons.calendar_today),
        Text(_text, style: BodyTextStyle),
        Container(
          child: ElevatedButton(
            child:
                Text(_date == null ? 'Odaberi datum' : formatter.format(_date),
                    style: TextStyle(
                      fontSize: 20,
                      color: Colors.black45,
                    )),
            style: ElevatedButton.styleFrom(
              primary: Color.fromRGBO(250, 250, 250, 1),
            ),
            onPressed: () {
              showDatePicker(
                      context: context,
                      initialDate: DateTime.now(),
                      firstDate: DateTime.now(),
                      lastDate: DateTime(3000))
                  .then((date) {
                setState(date);
              });
            },
          ),
        ),
      ],
    );
  }
}
