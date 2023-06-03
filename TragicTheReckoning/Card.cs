namespace TragicTheReckoning
{
    public class Card
    {
        private CardNames card;
        private int C {get; set;}
        private int AP{get; set;}
        private int DP{get; set;}

        public Card(CardNames card)
        {
            this.card=card;
            if (card == (CardNames)0)
            {
                C=1;
                AP=1;
                DP=1;               
            }
            else if (card==(CardNames)1)
            {
                C=1;
                AP=2;
                DP=1;
            }
            else if (card==(CardNames)2)
            {
                C=2;
                AP=0;
                DP=5;
            }
            else if (card==(CardNames)3)
            {
                C=2;
                AP=1;
                DP=3;
            }
            else if (card==(CardNames)4)
            {
                C=3;
                AP=3;
                DP=2;
            }
            else if (card==(CardNames)5)
            {
                C=4;
                AP=5;
                DP=3;
            }
            else if (card==(CardNames)6)
            {
                C=3;
                AP=1;
                DP=3;
            }
            else if (card==(CardNames)7)
            {
                C=5;
                AP=6;
                DP=4;
            }
            else if (card==(CardNames)8)
            {
                C=4;
                AP=3;
                DP=3;
            }
            else if (card==(CardNames)9)
            {
                C=2;
                AP=2;
                DP=2;
            }
        }

    }
}