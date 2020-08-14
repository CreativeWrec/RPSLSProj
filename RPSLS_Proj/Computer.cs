using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    class Computer : Player
    {
        //Variable (has a)
        Computer computer;
        //Construtor
        public Computer()
        {

        }
        //Method (can do)
        public override void ChooseGesture()
        {
            //Use random number to choose gesture
            Random rng = new Random();
            int randomIndex = rng.Next(0, 5);
            chosenGesture = gestures[randomIndex];
            
        }
    }
}
