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
        private int number;
        public View(Controller controller, Turn turn)
        {
            this.controller=controller;
            this.turn=turn;
        }
        //<summary>If the card does not exist or player does not have enough MP</summary>
        public void NoCard()
        {
            Console.WriteLine($"Card does not exist or player has no MP");
        }

        //<summary>Stats of the player 1</summary>
        public void Player1Stats()
        {
            number=0;
            Console.WriteLine($"player1 HP:{turn.player1.HP}");
            Console.WriteLine($"MP:{turn.player1.MP}");
            Console.WriteLine($"cards:");

            foreach (Card card in turn.player1.playercards)
            {
                number++;
                Console.Write($"card {number} - ");
                Console.Write($"{card.card}/");
                Console.Write($"{card.C}/");
                Console.Write($"{card.AP}/");
                Console.WriteLine($"{card.DP}");
            }
        }
        //<summary>stats of the player 2</summary>
        public void Player2Stats()
        {
            number=0;
            Console.WriteLine($"player2 HP:{turn.player2.HP}");
            Console.WriteLine($"MP:{turn.player2.MP}");
            Console.WriteLine($"cards:");

            foreach (Card card in turn.player2.playercards)
            {
                number++;
                Console.Write($"card {number} - ");
                Console.Write($"{card.card}/");
                Console.Write($"{card.C}/");
                Console.Write($"{card.AP}/");
                Console.WriteLine($"{card.DP}");
            }
        }

        //<summary>Initial explanation of the game</summary>
        public void ExplainGame()
        {
            Console.Write($"Try to bring the other players HP to 0.");
            Console.Write($"Each player starts with 6 cards, ");
            Console.Write($"to select a card in the spell phase write the ");
            Console.Write($"number of the card. ");
            Console.Write($"From turn 1 to 4 the MP will be the number of ");
            Console.Write($"the turn, from turn 5 onwards the player will ");
            Console.Write($"have MP=5. ");
            Console.Write($"If the number of cards in a players hand is ");
            Console.Write($"less than 6 then the player will get another card");
            Console.Write($" at the end of the turn. ");
            Console.Write($"If any of the players want to give up write ");
            Console.WriteLine($"quit.");
        }

        //<summary>Spell phase</summary>
        public void SpellPhase()
        {
            Console.Write($"Choose the card to play in the attack phase.");
            Console.Write($" If you don't want to play anymore cards write");
            Console.WriteLine($" continue");
            
        }

        

        //Attack phase
        public void Attack(int a)
        {
            if ((turn.player1card[a]!=null)&(turn.player2card[a]!=null))
            {
                Console.WriteLine($"Both players have cards that can attack in game");
            }
            else if ((turn.player1card[a]!=null)&(turn.player2card[a]==null))
            {
                Console.WriteLine($"Player 2 has no cards that can attack");
            }
            else if ((turn.player1card[a]==null)&(turn.player2card[a]!=null))
            {
                Console.WriteLine($"Player 1 has no cards that can attack");
            }
            else
            {
                Console.WriteLine($"No player has cards that can attack in the game");
            }
            
        }

        //<summary>If a player gives up</summary>
        public void End()
        {
            Console.WriteLine($"A player has given up");
        }
        //<summary>If a player loses</summary>
        public void Death(int a)
        {
            Console.WriteLine($"player {a} lost");
        }
        public string HowManyCards()
        {
            return Console.ReadLine();
        }
    }
}