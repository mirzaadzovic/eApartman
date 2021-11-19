import 'dart:convert';

import 'package:eapartman_mobile/Helpers/helpers.dart';
import 'package:eapartman_mobile/models/apartman.dart';
import 'package:http/http.dart' as http;

class PaymentService {
  static String _url =
      "http://10.0.2.2:5012/api/payments/create-payment-intent";
  static Future<dynamic> CreatePaymentContent(Apartman apartman) async {
    try {
      Map<String, dynamic> body = {
        "apartmanId": apartman.apartmanId,
        "brojDana": Helpers.DateDifferenceDays(
            apartman.search.checkIn, apartman.search.checkOut),
      };
      var bodyJson = jsonEncode(body);
      var response = await http.post(Uri.parse(_url), body: bodyJson, headers: {
        'Content-Type': 'application/json;charset=UTF-8',
      });
      print(response.body.toString());
      return jsonDecode(response.body.toString());
    } catch (e) {
      print("create: " + e.toString());
    }
  }
}
