using System;

namespace Assignment_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Please, enter the grade: ");
            char studentGrade = Console.ReadLine()[0];

            switch (studentGrade)
            {
                case 'A':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'B':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;
                case 'D':
                    Console.WriteLine("It is not good!You should study!");
                    break;
                case 'E':
                    Console.WriteLine("It is not good!You should study!");
                    break;
                case 'F':
                    Console.WriteLine("Fail! You need to repeat the exam!");
                    break;
                default:
                    Console.WriteLine("Please enter the correct grade.");
                    break;
            }

        }
    }
}
