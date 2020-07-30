using _20Full.Models.Enums;
using System;

namespace _20Full.Models
{
    class Card
    {
        public CardPatterns Pattern { get; set; }
        private uint _value;
        public uint Value
        {
            get { return _value; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Max value for card is 14! (Ace)");
                }
                if (value < 2)
                {
                    throw new ArgumentException("Min value for card is 2!");
                }
                _value = value;
            }
        }

        public override string ToString()
        {
            string valueName = Value.ToString();
            switch (Value)
            {
                case 11:
                    valueName = "Jack";
                    break;
                case 12:
                    valueName = "Queen";
                    break;
                case 13:
                    valueName = "King";
                    break;
                case 14:
                    valueName = "Ace";
                    break;
            }
            return $"{valueName} {Pattern.ToString()}";
        }

    }
}
