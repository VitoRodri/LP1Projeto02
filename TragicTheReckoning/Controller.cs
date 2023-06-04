using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Controller
    {
        private Turn turn;
        
        public Controller(Turn turn)
        {
            this.turn=turn;
        }
        public void Run(IView view)
        {

        }
    }
}