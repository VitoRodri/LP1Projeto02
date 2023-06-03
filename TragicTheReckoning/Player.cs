using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class Player
    {
        private int HP;
        private int MP;
        private CardDeck deck;
        private List<Card>playercards= new List<Card>();
        
        public Player()
        {
            HP=10;
            MP=0;
            deck= new CardDeck();
            deck.GiveCard(playercards,6);
        }
    }
}