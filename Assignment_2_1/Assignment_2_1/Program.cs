using System;

namespace Assignment_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
         

           
            Console.WriteLine("Please, choose a day of the week from 1-7: ");
            int dayOfTheWeek = Int32.Parse(Console.ReadLine());

            switch (dayOfTheWeek)
            {
                
                case 1:
                    Console.WriteLine("It is a working day");
                    break;
                case 2:
                    Console.WriteLine("It is a working day");
                    break;
                case 3:
                    Console.WriteLine("It is a working day");
                    break;
                case 4:
                    Console.WriteLine("It is a working day");
                    break;
                case 5:
                    Console.WriteLine("It is a working day");
                    break;
                case 6:
                    Console.WriteLine("It is holiday");
                    break;
                case 7:
                    Console.WriteLine("It is holiday");
                    break;

                default:
                    Console.WriteLine("Please enter the correct value.");
                    break;
            }
        }
    }
}
