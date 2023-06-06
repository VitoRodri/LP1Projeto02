using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Turn
    {
        //<summary>variables of the turn and both players</summary>
        private int turn;
        public Player player1=new Player();
        public Player player2=new Player();
        private Card card;
        private int number1=0;
        private int number2=0;
        public List<Card> player1card= new List<Card>();
        public List<Card> player2card= new List<Card>();
        private List<Card> player1c= new List<Card>();
        private List<Card> player2c= new List<Card>();

        //<summary>Constructor that starts 1 turn and updates the players</summary>
        public Turn()
        {
            turn=1;
            player1.UpdatePlayer(turn);
            player2.UpdatePlayer(turn);
        }

        //<summary>Check if player has enough MP to use card  
        //if yes add to list of cards the player will play in the attack phase</summary>
        //<returns> bool</returns>
        public bool SpellPhasePlayer(int i, Player player)
        {
            card=player.ChooseCard(i);
            if ((card!=null)&(card.C<=player.MP))
            {
                if (player==player1)
                {
                    player1card.Add(card);
                }
                else if (player==player2)
                {
                    player2card.Add(card);
                }
                
                player.MP=-card.C;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //<summary>Cards deal damage to each other and the players</summary>
        public void AttackPhase(int a)
        {
            
            if ((player1card!=null)&(player2card!=null))
            {
                number2=player2card[a].DP-player1card[a].AP;
                number1=player1card[a].DP-player2card[a].AP;
                player2card[a].DP-=player1card[a].AP;
                player1card[a].DP-=player2card[a].AP;
                if (player1card[a].DP>0)
                {
                    player1c.Add(player1card[a]);
                }
                if (player2card[a].DP>0)
                {
                    player2c.Add(player2card[a]);
                }
                player1card.RemoveAt(a);
                player2card.RemoveAt(a);
            }
            else if ((player1card[a]!=null)&(player2card[a]==null))
            {
                player2.HP-=player1card[a].AP;
                player1c.Add(player1card[a]);
                player1card.RemoveAt(a);
            }
            else if ((player2card[a]!=null)&(player1card[a]==null))
            {
                player1.HP-=player2card[a].AP;
                player2c.Add(player2card[a]);
                player2card.RemoveAt(a);
            }

            //<summary>If a players card gets destroyed 
            //but the other players card still has AP</summary>
            if ((number1<0)&(player1card[a]==null))
            {
                player1.HP+=number1;
            }
            else if ((number1<0)&(player1card[a]!=null))
            {
                player1card[a].DP+=number1;
            }


            if ((number2<0)&(player2card[a+1]==null))
            {
                player2.HP+=number2;
            }
            else if ((number2<0)&(player2card[a+1]!=null))
            {
                player2card[a].DP+=number2;
            }

            
            
        }

        //<summary>Next turn, update player MP and give card if needed</summary>
        public void EndTurn()
        {
            turn++;
            player1.UpdatePlayer(turn);
            player2.UpdatePlayer(turn);
            player1card=player1c;
            player2card=player2c;
        }
    }
}