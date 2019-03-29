using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Game
    {
        //member variables (Has a)
        Player PlayerOne;
        Player PlayerTwo;
        int numberOfRounds;
        int currentRound;


        //constructor
        public Game()
        {
            PlayerOne = new human();
            PlayerTwo = new AI();
        }
        //member methods (Can Do)
        public void RunGame()
        {
            DefinePlayers();
            Console.WriteLine("Choose number of players, 1 or 2");
          
         }
        public void DefinePlayers()
        {
            
        }

        public void CompareGesture()
        {
            Rock > Scissors
            Scissors > Paper
            Paper > Rock
            Rock > Lizard
            Lizard > Spock
            Spock > Scissors
            Scissors > Lizard
            Lizard > Paper
            Paper > Spock
            Spock > Rock

        }

        public void AwardPoints()
        {
            //need a return
        }

             public void DisplayWinner()
        {
            //list steps of game
            RunGame();
            DefinePlayers();
            CompareGesture();
            AwardPoints();
            DisplayWinner();

      
            
        }



    }
}
