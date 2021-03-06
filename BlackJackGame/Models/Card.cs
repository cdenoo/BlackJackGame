﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame.Models
{
    public class Card
    {
        public FaceValue FaceValue { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Suit suit, FaceValue faceValue)
        {
            this.FaceValue = faceValue;
            this.Suit = suit;
        }
    }
}
