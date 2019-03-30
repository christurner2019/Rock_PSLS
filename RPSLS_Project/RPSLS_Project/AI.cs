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


        //member methods (can do)
        public override void InputName()
        {

            name = "Tim";
        }
        public override void ChooseGesture()  //add void instead of string and delete switch below if needed. 
        {
            int Results = RandomInt.Next(0, 4);
            Console.WriteLine(RandomInt.Next(0, 4));

            switch(Results)

            {
                case 1:
                    Console.WriteLine("Rock");
                    break;
                case 2:
                    Console.WriteLine("Paper");
                    break;
                case 3:
                    Console.WriteLine("Scissors");
                    break;
                case 4:
                    Console.WriteLine("Lizard");
                    break;
                case 5:
                    Console.WriteLine("Spock");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

       


        }
        //get integer choices coming from AI to output strings-Rock, Paper, etc
    }
}
