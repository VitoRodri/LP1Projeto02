using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Turn
    {
        //variables of the turn and both players
        private int turn;
        public Player player1=new Player();
        public Player player2=new Player();
        private Card card;
        private int number1=0;
        private int number2=0;
        public List<Card> player1card;
        public List<Card> player2card;

        //Constructor that starts 1 turn and updates the players
        public Turn()
        {
            turn=1;
            player1.UpdatePlayer(turn);
            player2.UpdatePlayer(turn);
        }

        //Check if player has enough MP to use card  
        //if yes add to list of cards the player will play in the attack phase
        public bool SpellPhasePlayer1(int i, Player player)
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
        
        //Cards deal damage to each other and the players
        public void AttackPhase(int a)
        {
            
            if ((player1card[a]!=null)&(player2card[a]!=null))
            {
                number2=player2card[a].DP-player1card[a].AP;
                number1=player1card[a].DP-player2card[a].AP;
                player2card[a].DP-=player1card[a].AP;
                player1card[a].DP-=player2card[a].AP;
                player1card.RemoveAt(a);
                player2card.RemoveAt(a);
            }
            else if ((player1card[a]!=null)&(player2card[a]==null))
            {
                player2.HP-=player1card[a].AP;
                player1card.RemoveAt(a);
            }
            else if ((player2card[a]!=null)&(player1card[a]==null))
            {
                player1.HP-=player2card[a].AP;
                player2card.RemoveAt(a);
            }

            //If a players card gets destroyed 
            //but the other players card still has AP
            if ((number1<0)&(player1card[a+1]==null))
            {
                player1card.RemoveAt(a);
                player1.HP+=number1;
            }
            else if ((number1<0)&(player1card[a+1]!=null))
            {
                player1card.RemoveAt(a);
                player1card[a].DP+=number1;
            }


            if ((number2<0)&(player2card[a+1]==null))
            {
                player2card.RemoveAt(a);
                player2.HP+=number2;
            }
            else if ((number2<0)&(player2card[a+1]!=null))
            {
                player2card.RemoveAt(a);
                player2card[a].DP+=number2;
            }
            
        }

        //Next turn, update player MP and give card if needed
        public void EndTurn()
        {
            turn++;
            player1.UpdatePlayer(turn);
            player2.UpdatePlayer(turn);
        }
    }
}