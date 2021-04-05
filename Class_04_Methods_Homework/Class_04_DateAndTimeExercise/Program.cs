using System;

namespace Class_04_DateAndTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the date that is 3 days from now 
            //●Print the date that is one month from now
            //●Print the date that is one month and 3 days from now
            //●Print 1 year and 2 months ago from today
            //●Print only the current month of today
            //●Print only the current year of today
            DateTime today = DateTime.Today;
            //three days from now
            DateTime ThreeDaysFromNow = today.AddDays(3);
            Console.WriteLine(today);

            //1 month from now
            DateTime oneMonthFromNow = today.AddMonths(3);
            Console.WriteLine(oneMonthFromNow);

            // one month and 3 days from now
            DateTime oneMonthAndThreeDays = today.AddMonths(1).AddDays(3);
            Console.WriteLine(oneMonthAndThreeDays);

            //1 year and 2 months ago from today
            DateTime oneYearAndTwoMonthsAgo = today.AddMonths(-2).AddYears(-1);
            Console.WriteLine(oneYearAndTwoMonthsAgo);

            //Current month of today
            int month = today.Month;
            Console.WriteLine(month);

            //Current year
            int year = today.Year;
            Console.WriteLine(year);


            Console.ReadLine();

        }
    }
}
