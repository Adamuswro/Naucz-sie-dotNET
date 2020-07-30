using System;
using System.Collections.Generic;

namespace _20Full.Models
{
    class Hand
    {
        public Card[] Cards { get; set; } = new Card[5];

        public override string ToString()
        {
            var result = new List<string>();
            foreach (var card in Cards)
            {
                result.Add(card.ToString());
            }
            return String.Join("  |  ", result);
        }
    }
}
