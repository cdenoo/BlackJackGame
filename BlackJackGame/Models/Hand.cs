using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    class Hand
    {
        private IList<BlackJackCard> _cards;

        public int NrOfCards { get; }
        public int Value { get; }
        public IEnumerable<BlackJackCard> Cards { get; }

        public Hand()
        {
            throw new NotImplementedException();
        }

        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new NotImplementedException();
        }

        public int CalculateValue()
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }
    }
}
