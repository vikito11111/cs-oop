using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05._Cards
{
    public class Card
    {
        public Card(string cardFace, CardSuit cardSuit)
        {
            CardFace = cardFace;
            CardSuit = cardSuit;
        }

        public string CardFace { get; set; }

        public CardSuit CardSuit { get; set; }

        public override string ToString()
        {
            char viewSuit = '♣';

            switch (this.CardSuit)
            {
                case CardSuit.Diamonds:
                    viewSuit = '♦';
                    break;
                case CardSuit.Hearts:
                    viewSuit = '♥';
                    break;
                case CardSuit.Spades:
                    viewSuit = '♠';
                    break;
                default:
                    break;
            }

            return $"[{this.CardFace}{viewSuit}]";
        }
    }
}