using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sides;
            string userInput;

            do
            {
                Random rnd = new Random();
                Console.WriteLine("How many sides do your dice have?");
                sides = int.Parse(Console.ReadLine());

                do // IF ENTER LESS THAN 2 SIDES (A COIN HAS 2 SIDES AND TECHNICALLY A DIE)
                {
                    if (sides < 2)
                    {
                        Console.WriteLine("You must enter 2 or more sides. How many sides do your dice have?");
                        sides = int.Parse(Console.ReadLine());
                    }
                } while (sides < 2);

                int die1 = rnd.Next(sides) + 1; // ADDED 1 SINCE 0 IS NOT A SIDE ON A DIE AND TO INCLUDE THE HIGHEST NUMBER ON THE DIE
                int die2 = rnd.Next(sides) + 1;

                Console.WriteLine("You rolled " + die1 + " and " + die2 + "!");

                Console.WriteLine("Would you like to roll again? Yes or no");
                userInput = string.Format(Console.ReadLine());

                if (userInput == "no")
                {
                    Console.WriteLine("Thanks for playing. See you next time.");
                }
                else if (userInput == "yes")
                {
                    Console.WriteLine("\nGreat! Roll and try your luck again sometime!");
                }
            } while (userInput == "yes");
        }
    }
}
