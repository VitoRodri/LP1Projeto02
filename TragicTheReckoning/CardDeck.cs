using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TragicTheReckoning
{
    public class CardDeck
    {
        private List<Card> listofcards=new List<Card>();
        private int a;
        
        public CardDeck()
        {
            AddToList(listofcards,CardNames.FlyingWand, 4);
            AddToList(listofcards,CardNames.SeveredMonkeyHead, 4);
            AddToList(listofcards,CardNames.MysticalRockWall,2);
            AddToList(listofcards,CardNames.LobsterMcCrabs, 2);
            AddToList(listofcards,CardNames.GoblinTroll, 2);
            AddToList(listofcards,CardNames.ScorchingHeatwave, 1);
            AddToList(listofcards,CardNames.BlindMinotaur, 1);
            AddToList(listofcards,CardNames.TimTheWizard, 1);
            AddToList(listofcards,CardNames.SharplyDressed, 1);
            AddToList(listofcards,CardNames.BlueSteel, 2);
           
        }

        public List<Card> AddToList(List<Card> listofcards,CardNames cardname,int i)
        {
            a=0;
            while (a<i)
            {
                listofcards.Add(new Card(cardname));
                a++;
            }
        
            return listofcards;
        }
        public List<Card> RemoveList(List<Card> listofcards,int i)
        {
            listofcards.RemoveAt( i );
            return listofcards;
        }
    }
}