using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    public abstract class Player
    {
        //Variable (has a)
        public string name;
        public int score;
        public string chosenGesture;
        public List<string> gestures = new List<string>();


        //Construtor
        public Player()
        {
            score = 0;
            name = "";

            guestures.Add("Rock");
            guestures.Add("Paper");
            guestures.Add("Scissors");
            guestures.Add("Lizard");
            guestures.Add("Spock");
        }
        //Method (can do)
        public abstract void ChooseGesture();
        
    }
}
