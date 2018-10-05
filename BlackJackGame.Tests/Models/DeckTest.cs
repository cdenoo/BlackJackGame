using Xunit;
using BlackJackGame.Models;
using System;

namespace BlackJackGame.Tests.Models
{
    public class DeckTest
    {
        private Deck _deck;

        public DeckTest()
        {
            _deck = new Deck();
        }

        [Fact]
        public void Draw_ReturnsBlackJackCard()
        {
            Assert.IsType<BlackJackCard>(_deck.Draw());
        }

        [Fact]
        public void Deck_ConstructorAdds52BlackJackCards()
        {
            int count = 0;
            foreach(BlackJackCard card in _deck.Cards)
            {
                count++;
            }
            Assert.Equal(52, count);
        }

        [Fact]
        public void Draw_ThrowsInvalidOperationException_WhenDeckEmpty()
        {
            for(int i = 0; i<52; i++)
            {
                _deck.Draw();
            }
            Assert.Throws<InvalidOperationException>(()=>_deck.Draw());
        }
    }
}
