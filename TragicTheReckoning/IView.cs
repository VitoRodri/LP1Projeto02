using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public interface IView
    {
        public void NoCard();
        public void Player1Stats();
        public void Player2Stats();
        public void ExplainGame();
        public void SpellPhase();
        public void Attack(int a);
        public void End();
        public void Death(int a);
        public ConsoleKeyInfo GetKey();
        public string HowManyCards();

    }
}