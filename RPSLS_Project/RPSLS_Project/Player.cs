using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Player
    {
        //member variables (Has A)
        //Player HumanPlayer;
        //Player AIPlayer;
        public List<string> Gestures;
        public int score;
        public string name;



        //constructor
        public Player()
        {
            Gestures = new List<string>() { "Rock", "Paper", "Scissor", "Lizard", "Spock" };
        }

        //member methods (Can Do)
        public  virtual void InputName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public void ChooseGesture()
        {
            Console.WriteLine("Please enter a gesture. Rock, Paper, Scissors, Lizard, or Spock");
            Console.ReadLine();

            //good place for switch if time. a nice to have, not a must have
        }
    }
}
