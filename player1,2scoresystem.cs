namespace playerscore
{

    class Program
    {
        static string player1;
        static string player2;


        static void Main(string[] args)
        {

            Exp();

        }

        public static void Exp()
        {
            Console.WriteLine("Chose the amount of exp for player 1");

            player1 = Console.ReadLine();

            Console.WriteLine("Chose the amount of exp for player 2");

            player2 = Console.ReadLine();

            int player1exp = int.Parse(player1);
            int player2exp = int.Parse(player2);


            if (player1exp >= player2exp)
            {

                Console.WriteLine("Player 1 got the highest score of {0}", player1);
            }
            else
            {

                Console.WriteLine("Player 2 got the highest score of {0}", player2);
            }

            Console.Read();

        }


    }

}