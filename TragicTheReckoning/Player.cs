using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Player
    {
        //<summary>Variables of the player</summary>
        public int HP{get; set;}
        public int MP{get; set;}
        public CardDeck deck;
        public List<Card>playercards= new List<Card>();
        private int missingcards=0;
        
        //<summary>Constructor that assigns initial values to the variables</summary>
        public Player()
        {
            HP=10;
            MP=0;
            deck= new CardDeck();
            deck.GiveCard(playercards,6);
        }

        //<summary>Changes the player's MP and gives a card if player has less than 6</summary>
        public void UpdatePlayer(int turn)
        {
            if (turn<5)
            {
                MP=turn;
            }
            else
            {
                MP=5;
            } 
            
            foreach (Card card in playercards)
            {
                missingcards++;
            }

            if(missingcards<6)
            {
                deck.GiveCard(playercards,1);
            }
            
        }
        //<summary>Get one of the cards from the playercards</summary>
        //<returns>Card</returns>
        public Card ChooseCard(int i)
        {
            int a=0;
            int b=0;
            while (playercards[a]!=null)
            {
                b++;
            }
            if (i<=b)
            {
                Card card1=playercards[i-1];
                playercards.RemoveAt(i-1);
                return card1;
            }
            else
            {
                return null;
            }
            

        }
    }
}