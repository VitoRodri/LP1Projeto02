using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Player
    {
        //Variables of the player
        private int HP;
        private int MP;
        private CardDeck deck;
        private List<Card>playercards= new List<Card>();
        private int missingcards=0;
        
        //Constructor that assigns initial values to the variables
        public Player()
        {
            HP=10;
            MP=0;
            deck= new CardDeck();
            deck.GiveCard(playercards,6);
        }

        public void UpdatePlayer(int turn)
        {
            if (turn<5)
            {
                MP++;
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
    }
}