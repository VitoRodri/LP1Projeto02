using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Controller
    {
        private Turn turn;
        private ConsoleKey key;

        private int alive;
        private bool keys;
        private string cards;
        private int number;
        
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
                cards=view.HowManyCards();
                key=view.GetKey().Key;
                keys=GetKey(cards);

                while(keys==true)
                {
                    number=StringtoInt(cards);
                    turn.SpellPhasePlayer(number,turn.player1);
                    if (turn.SpellPhasePlayer(number,turn.player1)==false)
                    {
                        view.NoCard();
                        view.Player1Stats();
                    }
                    cards=view.HowManyCards();
                    key=view.GetKey().Key;
                    keys=GetKey(cards);
                }
                if (key==ConsoleKey.Escape)
                {
                    view.End();

                    break;
                    
                }
                else if (key==ConsoleKey.Enter)
                {
                    view.Player2Stats();
                    key=view.GetKey().Key;

                    keys=GetKey(cards);

                    while (keys==true)
                    {
                        number=StringtoInt(cards);
                        turn.SpellPhasePlayer(number,turn.player2);
                        if (turn.SpellPhasePlayer(number,turn.player2)==false)
                        {
                            view.NoCard();
                            view.Player2Stats();
                        }
                        key=view.GetKey().Key;
                        keys=GetKey(cards);
                    }
                    if (key==ConsoleKey.Escape)
                    {
                        view.End();
                        break;
                        
                    }
                    else if (key==ConsoleKey.Enter)
                    {
                        while((turn.player1card!=null)&(turn.player2card!=null))
                        {
                            view.Attack(0);
                            turn.AttackPhase(0);
                        }

                        turn.EndTurn();
                        
                        
                    }
                }
                else
                {
                    
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

        private bool GetKey(string cards)
        {
            if (cards=="1")
            {
                return true;
            }
            else if (cards=="2")
            {
                return true;
            }
            else if (cards=="3")
            {
                return true;
            }
            else if (cards=="4")
            {
                return true;
            }
            else if (cards=="5")
            {
                return true;
            }
            else if (cards=="6")
            {
                return true;
            }
            else if (cards=="No")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private int StringtoInt(string cards)
        {
            if (cards=="1")
            {
                number=1;
                
            }
            else if (cards=="2")
            {
                number=2;
            }
            else if (cards=="3")
            {
                number=3;
            }
            else if (cards=="4")
            {
                number=4;
            }
            else if (cards=="5")
            {
                number=5;
            }
            else if (cards=="6")
            {
                number=6;
            }
            else
            {
                number=0;
            }
            return number;
        }

        
    }
}