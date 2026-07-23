using System;
using System.Globalization;

namespace ClassLibrary
{
    public class Class1
    {
        /// <summary>
        /// Converts a Gregorian date to its Jalali representation in yyyy/MM/dd format.
        /// </summary>
        /// <param name="date">The date to convert.</param>
        /// <returns>The Jalali date formatted as yyyy/MM/dd.</returns>
        public static string ToJalaliDate(DateTime date)
        {
            var persianCalendar = new PersianCalendar();

            int year = persianCalendar.GetYear(date);
            int month = persianCalendar.GetMonth(date);
            int day = persianCalendar.GetDayOfMonth(date);

            return FormattableString.Invariant($"{year:D4}/{month:D2}/{day:D2}");
        }
    }
}
