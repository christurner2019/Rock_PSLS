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
        string AddRules;

        
        //constructor
        public Game()
        {
            
        }
        //member methods (Can Do)
        public virtual void RunGame()
        {
            DisplayRules();
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

        public void DisplayRules()
        {
            Console.WriteLine("Rules: Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, " +
                "Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, " +
                "Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock and Spock " +
                "vaporizes Rock.");
        }
        public void DefinePlayers()
        {
            Console.WriteLine("Choose number of players, '1' for human vs computer or '2' for human vs human");
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
            else if (PlayerOne.gesture == "rock" && (PlayerTwo.gesture == "scissors" || 
                PlayerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;

            }  
            else if (PlayerOne.gesture == "scissors" && (PlayerTwo.gesture == "paper" || 
                PlayerTwo.gesture == "lizard"))
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "paper" && (PlayerTwo.gesture == "rock" || 
                PlayerTwo.gesture == "spock"))
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "lizard" && (PlayerTwo.gesture == "spock" || 
                PlayerTwo.gesture == "paper"))
            {
                Console.WriteLine("Player One wins this round!");
                PlayerOne.score++;
            }
            else if (PlayerOne.gesture == "spock" && (PlayerTwo.gesture == "scissors" || 
                PlayerTwo.gesture == "rock"))
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
