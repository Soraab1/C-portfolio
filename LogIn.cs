using System;

namespace LogIn
{

    //basic program that mimicks a login, program only works with with letter username & password

    public class exercise
    {


        static void Main(string[] args)
        {

            

            Console.WriteLine("Choose a username: ");

            string Username = Console.ReadLine();

            Console.WriteLine("Use a password: ");

            string Password = Console.ReadLine();


            Console.WriteLine("Fill in your username: ");

            string chosenUSR = Console.ReadLine();

            if(chosenUSR == Username)
            {

                Console.WriteLine("the filled in username is correct ");
            }
            else
            {

                Console.WriteLine("the username you filled in is incorrect");
            }
            
            Console.WriteLine("Fill in your password: ");

            string chosenPWD = Console.ReadLine();

            if (chosenPWD == Password)
            {

                Console.WriteLine("The filled in password is correct");

            }
            else
            {

                Console.WriteLine("The password you filled in is incorrect");
            }


            Console.Read();

        }

    } 

}



