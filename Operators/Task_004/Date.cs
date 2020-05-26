using System;

namespace Task_004
{
    public class Date
    {
        readonly DateTime _date;

        public Date(DateTime date)
        {
            _date = date;
        }

        public static Date operator -(Date date1, Date date2)
        {
            var timeSpan = date1._date - date2._date;
            var newDate = date1._date.AddDays(-timeSpan.Days);
            return new Date(newDate);
        }

        public static Date operator +(Date date1, Date date2)
        {
            var timeSpan = date1._date - date2._date;
            var newDate = date1._date.AddDays(timeSpan.Days);
            return new Date(newDate);
        }

        public override string ToString()
        {
            return "Дата: " + _date;
        }
    }
}