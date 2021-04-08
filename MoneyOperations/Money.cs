using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyOperations
{
    public abstract class Money
    {
        private int val = 0;

        public int Val
        {
            get { return val; }
            set { val = value; }
        }

        public abstract double ExchangeRate();


        public double AbsoluteValue(double exchangeRate)
        {
            return exchangeRate * Val;
        }

        public static double GetExchangeRate(Money money)
        {
            return money.ExchangeRate();
        }

        public static double REAbsoluteValue(double val, double changeRate)
        {
            return val / changeRate;
        }

        public static double operator +(Money first, Money second)
        {
            if (first.GetType() == second.GetType())
                return first.val + second.val;

            var exchangeRate_first = GetExchangeRate(first);
            var exchangeRate_second = GetExchangeRate(second);
            return REAbsoluteValue(first.AbsoluteValue(exchangeRate_first) + second.AbsoluteValue(exchangeRate_second), exchangeRate_first);
        }
    }
}
