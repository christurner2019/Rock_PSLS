using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Player
    {
        //member variables (Has A)
        //Player HumanPlayer;
        //Player AIPlayer;
        public List<string> Gestures;
        public int score;
        public string name;
        public string gesture;


        //constructor
        public Player()
        {
            Gestures = new List<string>() { "Rock", "Paper", "Scissor", "Lizard", "Spock" };
            name = null;
            score = 0;
        }

        //member methods (Can Do)
        public virtual void InputName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
         public virtual void ChooseGesture()  //add virtual back in after public if AI code doesnt function correctly.
        {
            Console.WriteLine("Please enter a gesture: Rock, Paper, Scissors, Lizard, or Spock");
            gesture = Console.ReadLine();

            //good place for switch if time. a nice to have, not a must have
        }
        public void UpdateScore()
        {
            score++;
        }
    }
}
