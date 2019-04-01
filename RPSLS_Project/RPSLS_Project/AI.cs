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

       


        //constructor (build this thing)
        public AI()
        {

            //AIGestureChoice = Gestures;

        }





        //member methods (can do)
        public override void InputName()
        {

            name = "AI Tim";
            Console.WriteLine(name);

        }
        public override void ChooseGesture()  //add void instead of string and delete switch below if needed. 
        {
            Random RandomInt = new Random();
            int Results = RandomInt.Next(0, 4);
            Console.WriteLine(RandomInt.Next(0, 4));

            switch (Results)

            {
                case 1:
                    Console.WriteLine("rock");
                    break;
                case 2:
                    Console.WriteLine("paper");
                    break;
                case 3:
                    Console.WriteLine("scissors");
                    break;
                case 4:
                    Console.WriteLine("lizard");
                    break;
                case 5:
                    Console.WriteLine("spock");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;

            }




        }
    }
}


