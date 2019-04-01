using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class AI : Player
    {
        //member variables (has a….also defined as attributes of the class)

        Random RandomInt;


        //constructor (build this thing)
        public AI()
        {
            RandomInt = new Random();
            //AIGestureChoice = Gestures;

        }
        public override void InputName()
        {
            string temp;
            int number;
            char computer = ' ', answer;

            Random rand = new Random();

            Console.WriteLine("Please enter a gesture: Rock, Paper, Scissors, Lizard, or Spock");
            temp = Console.ReadLine();
            answer = Convert.ToChar(temp);
            number = rand.Next(3);

            switch (number)
            {
                case 1:
                    computer = 'paper';
                    Console.WriteLine("CPU chose paper");
                    break;

                case 2:
                    computer = 'scissors';
                    Console.WriteLine("CPU chose scissors");
                    break;

                case 3:
                    computer = 'rock';
                    Console.WriteLine("CPU chose rock");
                    break;

                case 4:
                    computer = 'spock';
                    Console.WriteLine("CPU chose spock");
                    break;
                case 5:
                    computer = 'lizard';
                    Console.WriteLine("CPU chose lizard");
                    break;
            }
            if (answer == computer)
            {
                Console.WriteLine("Draw");
            }
            else if (((answer == 'rock') && (computer == 'scissors')) || 
                ((answer == 'scissors') && (computer == 'paper')) || ((answer == 'paper') && 
                (computer == 'rock')) && ((answer == 'rock') && (computer == 'lizard')))
            {
                Console.WriteLine("You have won");
            }
            else if
                (((answer == 's') && (computer == 'r')) || ((answer == 'p') && (computer == 's')) 
                || ((answer == 'r') && (computer == 'p')))
            {
                Console.WriteLine("You have lost");

            }
            else
            {
                Console.WriteLine("In conclusive");
            }
            Console.ReadLine();


        }

        //member methods (can do)
        //public override void InputName()
        //{

        //    name = "AI Tim";
        //    Console.WriteLine(name);

        //}
        //public override void ChooseGesture()  //add void instead of string and delete switch below if needed. 
        //{
        //    int Results = RandomInt.Next(0, 4);
        //    Console.WriteLine(RandomInt.Next(0, 4));

        //    switch (Results)

        //    {
        //        case 1:
        //            Console.WriteLine("Rock");
        //            break;
        //        case 2:
        //            Console.WriteLine("Paper");
        //            break;
        //        case 3:
        //            Console.WriteLine("Scissors");
        //            break;
        //        case 4:
        //            Console.WriteLine("Lizard");
        //            break;
        //        case 5:
        //            Console.WriteLine("Spock");
        //            break;
        //        default:
        //            Console.WriteLine("Default case");
        //            break;

        //    }




        }

        
    }
}

