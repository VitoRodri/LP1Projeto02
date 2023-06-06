using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class CardDeck
    {
        //Variables for CardDeck
        private List<Card> listofcards=new List<Card>();
        private List<Card> newlist=new List<Card>();
        private int a;
        private static Random random= new Random();
        private int b;
        
        //Constructor that creates a list of the cards and shuffles them 
        public CardDeck()
        {
            AddList(CardNames.FlyingWand, 4);
            AddList(CardNames.SeveredMonkeyHead, 4);
            AddList(CardNames.MysticalRockWall,2);
            AddList(CardNames.LobsterMcCrabs, 2);
            AddList(CardNames.GoblinTroll, 2);
            AddList(CardNames.ScorchingHeatwave, 1);
            AddList(CardNames.BlindMinotaur, 1);
            AddList(CardNames.TimTheWizard, 1);
            AddList(CardNames.SharplyDressed, 1);
            AddList(CardNames.BlueSteel, 2);

            Shuffle(); 
            
        }

        //Adding a card to the list
        public void AddList(CardNames cardname,int i)
        {
            a=0;
            while (a<i)
            {
                listofcards.Add(new Card(cardname));
                a++;
            }
            
            
        }

        //Removing a card from a list
        public void RemoveList(int i)
        {
            listofcards.RemoveAt( i );
            
        }

        //Shuffling a list with 20 cards
        public void Shuffle()
        {
            a=0;
            while(a<20)
            {
                a++;
                b=random.Next(0,20-a);
                newlist.Add(listofcards[b]);
                RemoveList(b);

            }
            listofcards=newlist;
   
        }
        
        //Taking a certain number of cards from the top of the list
        public void GiveCard(List<Card> list, int i)
        {
            a=0;
            while(a<i)
            {
                list.Add(listofcards[0]);
                RemoveList(0);
                a++;
            }
            
            
        }
    }
}