using System;

namespace GCExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another nummber: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;

            Console.WriteLine("The Sum of {0} + {1} is {2}", a, b, sum);
            Console.ReadLine();
        }
    }
}

/*Description
Prompt the user to enter two numbers.After the user enters the numbers, add them together
and output the sum back to the console.
Example
>>Enter a number: <<12.2
>>Enter another number: <<17.3
>>The sum is 29.5
*/