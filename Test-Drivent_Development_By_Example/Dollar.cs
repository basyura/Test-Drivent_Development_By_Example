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

        public static bool operator ==(Dollar a, Dollar b)
        {
            // 同一のインスタンスを参照している場合は true
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // どちらか片方でも null なら false
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // 減算した結果が0なら true
            return a.Amount == b.Amount;
        }

        public static bool operator !=(Dollar a, Dollar b)
        {
            return !(a == b);
        }

    }
}
