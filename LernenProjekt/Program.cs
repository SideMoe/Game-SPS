using System;

namespace AuthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            string spieler;
            string computer;

            while (playAgain)
            {
                spieler = "";
                computer = "";
                while (spieler != "STEIN" && spieler != "PAPIER" && spieler != "SCHERE")
                {
                    Console.WriteLine("Geben Sie \u001b[33mStein\u001b[0m, \u001b[33mPapier\u001b[0m oder \u001b[33mSchere\u001b[0m ein: ");
                    spieler = Console.ReadLine().ToUpper(); // Umwandlung zu Großbuchstaben hier
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "STEIN";
                        break;
                    case 2:
                        computer = "PAPIER";
                        break;
                    case 3:
                        computer = "SCHERE";
                        break;
                }

                Console.WriteLine("Spieler: " + spieler);
                Console.WriteLine("Computer: " + computer);

                switch (spieler)
                {
                    case "STEIN":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        else if (computer == "PAPIER")
                        {
                            Console.WriteLine("Du verlierst!");
                        }
                        else if (computer == "SCHERE")
                        {
                            Console.WriteLine("Du gewinnst!");
                        }
                        break;
                    case "PAPIER":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du gewinnst!");
                        }
                        else if (computer == "PAPIER")
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        else if (computer == "SCHERE")
                        {
                            Console.WriteLine("Du verlierst!");
                        }
                        break;
                    case "SCHERE":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du verlierst!");
                        }
                        else if (computer == "PAPIER")
                        {
                            Console.WriteLine("Du gewinnst!");
                        }
                        else if (computer == "SCHERE")
                        {
                            Console.WriteLine("Unentschieden!");
                        }
                        break;
                }

                Console.WriteLine("Möchtest du nochmal spielen? (ja/nein)");
                string playAgainResponse = Console.ReadLine().ToUpper();
                if (playAgainResponse != "JA")
                {
                    playAgain = false;
                }
            }

            Console.ReadKey();
        }
    }
}
