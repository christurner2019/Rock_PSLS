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
        public override void ChooseGesture()
        {
            int Results = RandomInt.Next(0, 4);
            //randomizer needed
        }
    }
}
