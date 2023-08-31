using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");

            string numb1 = Console.ReadLine();

            int numb2= int.Parse(numb1);

            if (numb2% 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
