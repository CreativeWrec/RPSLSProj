using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    class Human : Player
    {
        //Variable (has a)
        

        //Construtor
        public Human()
        {
            
        }
        //Method (can do)
        public override void ChooseGesture()
        {
            //displaying choices
            //getting user input
            
            Console.WriteLine("What gesture would you like to choose? 0.Rock, 1. Paper, 2. Scissor, 3. Lizard, 4. Spock");
            string userInput = Console.ReadLine();
            int indexNumber = int.Parse(userInput);
            chosenGesture = gestures[indexNumber];

        }
    }
}
