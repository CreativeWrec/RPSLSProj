using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            Console.ReadLine();
        }

        //Welcome/Setup
        //1. Display rules to user / DisplayRules()
        //2. Prompt user to choose 1 to 2 players
        //3. Asker players to enter their names (optional)

        //A round of play
        //4. Display gesture options
        //5. Have playher one choose a gesture
        //6. Display gesture options(what if p2 is a computer?)
        //7. Have player two choose a gesture
        //8. Compare the gestures of the players
        //9. Give a point to winner of the round
        //10. Check to see if anyone has enough points to win (do-while loop?)

        //11. Loop back on round 4-10

        //Endgame
        //12. Display the winner of the game
        //13. Ask if player wants to play another game (optional)
        


    }
}
