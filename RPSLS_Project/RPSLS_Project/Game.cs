using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Game
    {
        //member variables (Has a)
        public Player PlayerOne;
        public Player PlayerTwo;
        int NumberOfWins;
        int currentRound;


        //constructor
        public Game()
        {
            
        }
        //member methods (Can Do)
        public void RunGame()
        {
            //Add rules
            DefinePlayers();
            PlayerOne.InputName();
            PlayerTwo.InputName();

            //loop
            
            do
            {
                PlayerOne.ChooseGesture();
                PlayerTwo.ChooseGesture();
                CompareGestures();
            } while (NumberOfWins <2);

        }
        public void DefinePlayers()
        {
            Console.WriteLine("Choose number of players, 1 or 2");
            string NumberOfPlayers = Console.ReadLine();
            if (NumberOfPlayers == "1")
            {
                PlayerOne = new human();
                PlayerTwo = new AI();
            }
            else if (NumberOfPlayers == "2")
            {
                PlayerOne = new human();
                PlayerTwo = new human();
            }
        }

        public void CompareGestures()
        {
            if (PlayerOne.gesture == PlayerTwo.gesture)
            {
                Console.WriteLine("It is a tie, keep playing!");
            }
            else if (PlayerOne.gesture == "Rock" && PlayerTwo.gesture == "Scissors" || 
                PlayerTwo.gesture == "Lizard")
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;

            }  
            else if (PlayerOne.gesture == "Scissors" && PlayerTwo.gesture == "Paper" || 
                PlayerTwo.gesture == "Lizard")
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "Paper" && PlayerTwo.gesture == "Rock" || 
                PlayerTwo.gesture == "Spock")
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "Lizard" && PlayerTwo.gesture == "Spock" || 
                PlayerTwo.gesture == "Paper")
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "Spock" && PlayerTwo.gesture == "Scissors" || 
                PlayerTwo.gesture == "Rock")
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else
            {
                Console.WriteLine("Player Two wins this round!");
                PlayerTwo.score++;
            }

                   
            

        }

        public void AwardPoints()
        {
            //need a return
        }

             public void DisplayWinner()
        {
            //list steps of game
            //RunGame();
            //DefinePlayers();
            //CompareGesture();
            //AwardPoints();
            //DisplayWinner();

      
            
        }



    }
}
