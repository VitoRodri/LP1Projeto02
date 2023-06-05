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
        private List<Card> player1card;
        private List<Card> player2card;

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
        

        public void AttackPhase()
        {
            
        }
        public void EndTurn()
        {
            turn++;
            player1.UpdatePlayer(turn);
            player2.UpdatePlayer(turn);
        }
    }
}