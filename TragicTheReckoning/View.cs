using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class View: IView
    {
        private Controller controller;
        private Turn turn;
        public View(Controller controller, Turn turn)
        {
            this.controller=controller;
            this.turn=turn;
        }
        //If the card does not exist
        public void NoCard()
        {
            Console.WriteLine($"Card does not exist");
        }
    }
}