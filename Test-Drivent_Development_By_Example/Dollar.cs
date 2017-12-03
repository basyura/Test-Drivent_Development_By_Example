using System;

namespace Money
{
    public class Dollar
    {
        public Dollar(int amout)
        {
            Amount = amout;
        }

        public int Amount { get; private set; }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
