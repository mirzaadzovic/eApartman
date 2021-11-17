class Helpers {
  static DateTime DateOnly(DateTime dt) => DateTime(dt.year, dt.month, dt.day);
  static int DateDifferenceDays(DateTime d1, DateTime d2) {
    return DateOnly(d2).difference(DateOnly(d1)).inDays;
  }
}
