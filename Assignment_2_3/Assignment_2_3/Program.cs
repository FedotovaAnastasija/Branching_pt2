using System;

namespace Assignment_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Please, enter the first value: ");
            int val1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the second value: ");
            int val2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the operator you want to choose: ");
            char operatorChoice = Console.ReadLine()[0];

            switch(operatorChoice)
            {

                case '+':
                    int sum = val1 + val2;
                    Console.WriteLine(" Your choice is: " + val1 + " + " + val2);
                    Console.WriteLine("The result is: " + sum);
                    break;

                case '-':
                    int result = val1 - val2;
                    Console.WriteLine(" Your choice is: " + val1 + " - " + val2);
                    Console.WriteLine("The result is: " + result);
                    break;

                case '/':
                    int result2 = val1 / val2;
                    Console.WriteLine(" Your choice is: " + val1 + " / " + val2);
                    Console.WriteLine("The result is: " + result2);
                    break;

                case '*':
                    int result3 = val1 * val2;
                    Console.WriteLine(" Your choice is: " + val1 + " * " + val2);
                    Console.WriteLine("The result is: " + result3);
                    break;

                case '%':
                    int result4 = val1 % val2;
                    Console.WriteLine(" Your choice is: " + val1 + " % " + val2);
                    Console.WriteLine("The result is: " + result4); 
                    break;

                case 'p':
                     Console.WriteLine("Your values are: " + val1 + " and " + val2);
                    break;

                case 'b':
                   
                    Console.WriteLine("The minimum is: " + Math.Min(val1, val2));
                    break;

                case 's':
                    Console.WriteLine("The maximum is: " +Math.Max(val1,val2));
                    break;

                default:
                    Console.WriteLine("Please enter the correct operators and operands.");
                    break;
            }

        }
    }
}
