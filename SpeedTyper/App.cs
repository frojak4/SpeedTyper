using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTyper
{
    internal class App
    {

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Typeracer!");
                Console.WriteLine("Press 1 to start, press 2 for instructions");
                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "1":
                        Game();
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey(true);
                        break;
                }

            }
        }

        private void Game()
        {
            Console.Clear();
            Word generator = new Word();
            int seconds = 30;
            int points = 0;
            string userInput = "";
            string word = generator.GetWord();
            while (seconds >= 0)
            {
                Console.Clear();
                Console.WriteLine($"seconds: {seconds}      points: {points}");
                Console.WriteLine(word);
                userInput = Console.ReadLine();

                if (userInput == word)
                {
                    points++;
                    word = generator.GetWord();
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                }
            }
        }
    }
}
