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

            while(playerOne.score != 3 && playerTwo.score != 3)
            {
                ViewGestureOptions();
                //have players pick gestures
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
                DisplayWinner();
            }
            
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
            Console.WriteLine("Please enter 1 for HvC, or enter 2 for HvH");

            string userInput = Console.ReadLine();
            //what if they don't type in 1 or 2

            if (userInput == "1")
            {
                //HvC game
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (userInput == "2")
            {
                //HvH
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                //TODO: Try Again?
                Console.WriteLine("Better Luck Next Time, Let's Try That Again!");
                ChooseGameMode();
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
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("Tie Game");
            }
            else if (playerOne.chosenGesture == "Rock" && (playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Spock"))
            {
                //player2 won the round
                Console.WriteLine("Player2 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Rock" && (playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player1 has won the round");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Paper" && (playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player2 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Paper" && (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "Rock"))
            {
                Console.WriteLine("Player1 has won the round");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Scissors" && (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Spock"))
            {
                Console.WriteLine("Player2 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Scissors" && (playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Lizard"))
            {
                Console.WriteLine("Player1 has won the round");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Lizard" && (playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Rock"))
            {
                Console.WriteLine("Player2 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Lizard" && (playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Spock"))
            {
                Console.WriteLine("Player1 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Spock" && (playerTwo.chosenGesture == "Lizard" || playerTwo.chosenGesture == "Paper"))
            {
                Console.WriteLine("Player2 has won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "Spock" && (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Scissors"))
            {
                Console.WriteLine("Player1 has won the round");
                playerOne.score++;
            }


        }
        public void DisplayWinner()
        {
            if (playerOne.score == pointsNeededToWin)
            {
                Console.WriteLine("Player1 Wins! Game Over");
                Console.WriteLine("Wanna Play Again? Y/N?");
                string userInput = Console.ReadLine();

                if (userInput == "Y")
                {
                    ChooseGameMode();
                }

            }
            else if (playerTwo.score == pointsNeededToWin)
            {
                Console.WriteLine("Player2 Wins! Game Over");
                Console.WriteLine("Wanna Play Again? Y/N?");
                string userInput = Console.ReadLine();

                if (userInput == "Y")
                {
                    ChooseGameMode();
                }
            }
        }





    }
}
