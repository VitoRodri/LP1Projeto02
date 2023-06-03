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
        
        //Constructor that assigns initial values to the variables
        public Player()
        {
            HP=10;
            MP=0;
            deck= new CardDeck();
            playercards=deck.GiveCard(playercards,6);
        }
    }
}