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

        public void Times(int multiplier)
        {
            Amount = Amount * multiplier;
        }
    }
}
