using System;

namespace TragicTheReckoning
{
    class Program
    {
        static void Main(string[] args)
        {
            Turn turn=new Turn();
            Controller controller=new Controller(turn);
            IView view=new View(controller,turn);

            controller.Run(view);
        }
    }
}
