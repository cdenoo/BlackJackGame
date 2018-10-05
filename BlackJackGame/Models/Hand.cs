using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class Hand
    {
        private IList<BlackJackCard> _cards;

        public int NrOfCards { get; private set; }
        public int Value { get; private set; }
        public IEnumerable<BlackJackCard> Cards {
            get { return _cards; }
        }

        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }

        public void AddCard(BlackJackCard blackJackCard)
        {
            _cards.Add(blackJackCard);
            NrOfCards++;
        }

        public int CalculateValue()
        {
            bool ace = false;
            int total = 0;
            foreach(BlackJackCard card in _cards)
            {
                if (card.FaceValue == FaceValue.Ace) ace = true;
                total += (int)card.Value;
            }
            if (ace && total < 21) total += 10;
            Value = total;
            return total;
        }

        public void TurnAllCardsFaceUp()
        {
            foreach (BlackJackCard card in _cards) {
                if (!card.FaceUp)
                    card.TurnCard();
            }
            CalculateValue();
        }
    }
}
