using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            int loopCount = 0;
            if (numberOfCards > 52)
            {
                throw new ArgumentOutOfRangeException("You can only have a max of 52 cards.");
            }


            string[] pickedCards = new string[numberOfCards];

          
            for (int i = 0; i < numberOfCards; i++)
            {
                bool foundCard = false;
                while (foundCard == false)
                {
                    loopCount++;
                   string c = RandomValue() + " of " + RandomSuit();
                    if (pickedCards.Contains(c) == false)
                    {
                        pickedCards[i] = c; 
                        foundCard = true;
                    }

                }
                //pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            Console.WriteLine($"Attempts: {loopCount}");
            return pickedCards;
          
        }



        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

    }
}
