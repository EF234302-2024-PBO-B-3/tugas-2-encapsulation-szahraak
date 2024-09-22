using System;

namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int month, int day, int year)
        {
            if (day > 0 && day < 32 && month > 0 && month < 13)
            {
                Year = year;
                Month = month;
                Day = day;
            } else
            {
                Year = 1970;
                Month = 1;
                Day = 1;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
