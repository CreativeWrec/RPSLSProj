using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    class Game
    {
        //Variable (has a)
        public List<string> guestures = new List<string>();
        public Player playerOne;
        public Player playerTwo;
        public int pointsNeededToWin;

        //Construtor
        public Game()
        {
            pointsNeededToWin = 3;

            guestures.Add("Rock");
            guestures.Add("Paper");
            guestures.Add("Scissors");
            guestures.Add("Lizard");
            guestures.Add("Spock");
        }
        //Method (can do)

        public void RunGame()
        {
            Welcome();
            DisplayRules();
            ChooseGameMode();
            ViewGestureOptions();
            CompareGestures();
            DisplayWinner();

        }

        public void Welcome()
        {
            Console.WriteLine("Welcome To Rock, Paper, Scissor, Lizard, Spock!");
        }
        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }
        public void ChooseGameMode()
        {
            //If/Else
            //Display a message to user asking them to choose 1 player or 2
            //Grab user input
            //instantiate playerTwo as a human or Computer
            Console.WriteLine("Do you want a 1 or 2 Player game? Type 1 or 2");
            string input = Console.ReadLine();
            if (input == "1")
            {
                playerTwo = new Computer();
            }
            else if (input == "2")
            {
                playerTwo = new Human();
            }
        }
        public void ViewGestureOptions()
        {
            List<string> Gestures = new List<string>
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            };
        }
        public void CompareGestures()
        {
            //p1 gets a point
            //p2 gets a point
            //tied game
        }
        public void DisplayWinner()
        {
            if (playerOne.score == pointsNeededToWin)
            {
                Console.WriteLine("Player1 Wins! Game Over");
                Console.WriteLine("Wanna Play Again?");
                ChooseGameMode();
            }
            else if (playerTwo.score == pointsNeededToWin)
            {
                Console.WriteLine("Player2 Wins! Game Over");
                Console.WriteLine("Wanna Play Again?");
                ChooseGameMode();
            }
        }




    }
}
