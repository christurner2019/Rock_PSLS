using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class human : Player
    {
        //member variables (has a….also defined as attributes of the class)
        Player HumanGestureChoice;

        //constructor (build this thing)
        public human()
        {
            HumanGestureChoice = Gestures;
        }        


        //member methods (can do)
    }
}
