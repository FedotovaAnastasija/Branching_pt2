using System;

namespace Assignment_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int day, month, year;

            Console.WriteLine("Please enter the day: ");
            if (!Int32.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31 )
            {
                Console.WriteLine("Incorrect input!");
                return;
            }

            Console.WriteLine("Please enter the month: ");
            if (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Incorrect input!");
                return;
            }

            Console.WriteLine("Please enter the year: ");
            if (!Int32.TryParse(Console.ReadLine(), out year) || year < 1900 || year > 2021)
            {
                Console.WriteLine("Incorrect input!");
                return;
            }

            Console.WriteLine("What format would you like to choose?");
            Console.WriteLine("1 - YYYY/MM/DD, 2- YYYY.MM.DD. Please enter a number: ");
            int format = Int32.Parse(Console.ReadLine());

            if (format == 1)
            {
                Console.WriteLine("Your date is: " + year + "/" + month + "/" + day + "/");
            }
            else if (format == 2)
            {
                Console.WriteLine("Your date is: " + year + "." + month + "." + day + ".");
            }

            else if (format < 1 || format > 2)
            {
                Console.WriteLine("Incorrect input!");
                return;
            }
        }
    }
}
