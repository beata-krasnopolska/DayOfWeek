using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program gets the day of the week for a specified date.");
            System.DateTime dayOfBirth = new DateTime(2019, 5, 17);
            Console.WriteLine("The day of the week {0} is: {1}", dayOfBirth, dayOfBirth.DayOfWeek);

            Console.ReadKey();
        }
    }
}
