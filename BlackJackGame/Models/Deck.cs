using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class Deck
    {
        private Random _random;
        private IList<BlackJackCard> _cards;

        public IEnumerable<BlackJackCard> Cards { get; }

        public Deck()
        {
            _random = new Random();
            _cards = new List<BlackJackCard>();
            Cards = _cards;
            
            for(int suit = 1; suit <= 4; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    _cards.Add(new BlackJackCard((Suit)suit, (FaceValue)value));
                }
            }
        }

        public BlackJackCard Draw()
        {
            if(_cards.Count == 0)
            {
                throw new InvalidOperationException("Cannot draw from empty deck");
            }
            BlackJackCard card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
