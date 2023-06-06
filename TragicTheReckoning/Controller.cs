using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Controller
    {
        private Turn turn;
        private char keychar;
        private ConsoleKeyInfo key;
        private ConsoleKey actualkey;
        private int alive;
        
        public Controller(Turn turn)
        {
            this.turn=turn;
        }
        public void Run(IView view)
        {
            view.ExplainGame();
            while ((turn.player1.HP>0)&(turn.player2.HP>0)
                    &(turn.player1.deck!=null)&(turn.player2.deck!=null))
            {
                view.Player1Stats();
                view.Player2Stats();
                view.SpellPhase();
                view.Player1Stats();
                key=view.GetKey();
                keychar=key.KeyChar;
                actualkey=key.Key;

                while ((actualkey!=ConsoleKey.Enter)&(actualkey!=ConsoleKey.Escape))
                {
                    turn.SpellPhasePlayer(keychar,turn.player1);
                    if (turn.SpellPhasePlayer(keychar,turn.player1)==false)
                    {
                        view.NoCard();
                        view.Player1Stats();
                    }
                    key=view.GetKey();
                    keychar=key.KeyChar;
                    actualkey=key.Key;
                }
                if (actualkey==ConsoleKey.Escape)
                {
                    view.End();

                    break;
                    
                }
                else
                {
                    view.Player2Stats();
                    key=view.GetKey();
                    keychar=key.KeyChar;
                    actualkey=key.Key;

                    while ((actualkey!=ConsoleKey.Enter)&(actualkey!=ConsoleKey.Escape))
                    {
                        turn.SpellPhasePlayer(keychar,turn.player2);
                        if (turn.SpellPhasePlayer(keychar,turn.player2)==false)
                        {
                            view.NoCard();
                            view.Player2Stats();
                        }
                        key=view.GetKey();
                        keychar=key.KeyChar;
                        actualkey=key.Key;
                    }
                    if (actualkey==ConsoleKey.Escape)
                    {
                        view.End();
                        break;
                        
                    }
                    else
                    {
                        while((turn.player1card!=null)&(turn.player2card!=null))
                        {
                            view.Attack(0);
                            turn.AttackPhase(0);
                        }

                        turn.EndTurn();
                        
                        
                    }
                }
            }


            if ((turn.player1.HP==0)|(turn.player2.HP==0)
                    |(turn.player1.deck==null)|(turn.player2.deck==null))
            {
                if (turn.player1.HP>turn.player2.HP)
                {
                    alive=2;
                }
                else
                {
                    alive=1;
                }

                view.Death(alive);
            }
            
            
        }
    }
}