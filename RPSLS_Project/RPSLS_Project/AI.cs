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
        Player AIGestureChoice;



        //constructor (build this thing)
        public AI()
        {
            AIGestureChoice = Gestures;

        }


        //member methods (can do)
        public virtual void InputName()
        {
            Console.WriteLine("AI");
            name = Console.ReadLine();
        }
}
