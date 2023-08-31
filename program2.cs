using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            string number = Console.ReadLine();

            int numb = int.Parse(number);

            if (numb % 3 == 0 || numb % 7 == 0 || numb == 1)
            {
                if (numb % 3 == 0)
                {
                    Console.WriteLine("The chosen number is divisible by 3");
                }

                if (numb % 7 == 0)
                {
                    Console.WriteLine("The chosen number is divisible by 7");
                }

                if (numb == 1)
                {
                    Console.WriteLine("The chosen number is equal to 1");
                }
            }
            else
            {
                Console.WriteLine("The chosen number doesn't meet any of the specified conditions.");
            }

            Console.Read();
        }
    }
}

