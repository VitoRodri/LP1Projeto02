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
            AddList(listofcards,CardNames.FlyingWand, 4);
            AddList(listofcards,CardNames.SeveredMonkeyHead, 4);
            AddList(listofcards,CardNames.MysticalRockWall,2);
            AddList(listofcards,CardNames.LobsterMcCrabs, 2);
            AddList(listofcards,CardNames.GoblinTroll, 2);
            AddList(listofcards,CardNames.ScorchingHeatwave, 1);
            AddList(listofcards,CardNames.BlindMinotaur, 1);
            AddList(listofcards,CardNames.TimTheWizard, 1);
            AddList(listofcards,CardNames.SharplyDressed, 1);
            AddList(listofcards,CardNames.BlueSteel, 2);

            Shuffle(listofcards); 
            
        }

        //Adding a card to the list
        public List<Card>AddList(List<Card>listofcards,CardNames cardname,int i)
        {
            a=0;
            while (a<i)
            {
                listofcards.Add(new Card(cardname));
                a++;
            }
        
            return listofcards;
        }

        //Removing a card from a list
        public List<Card> RemoveList(List<Card> listofcards,int i)
        {
            listofcards.RemoveAt( i );
            return listofcards;
        }

        //Shuffling a list with 20 cards
        public List<Card> Shuffle( List<Card> listofcards)
        {
            a=0;
            while(a<20)
            {
                a++;
                b=random.Next(0,20-a);
                newlist[a]=listofcards[b];
                RemoveList(listofcards,b);

            }
            listofcards=newlist;

            return listofcards;
        }
        
        //Taking a certain number of cards from the top of the list
        public List<Card> GiveCard(List<Card> list, int i)
        {
            a=0;
            while(a<i)
            {
                list.Add(listofcards[0]);
                RemoveList(listofcards,0);
            }
            
            return list;
        }
    }
}