using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {
        private int value;
        public bool FaceUp { get; set; }
        public int Value {
            get {
                if (!FaceUp) return 0;
                else return (int)this.FaceValue;
            }
        }

        public BlackJackCard(Suit suit, FaceValue faceValue): base(suit, faceValue)
        {
            FaceUp = false;
        }

        public void TurnCard()
        {
            FaceUp = !FaceUp;
        }
    }
}
