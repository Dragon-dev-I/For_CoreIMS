using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyOperations
{
    class Money
    {
        private const int euro = 90;
        private const int dollar = 60;
        private const int ruble = 1;

        public int AbsoluteValue (int val, String currency)
        {
            switch(currency)
            {
                case "e":
                    return val * euro;
                case "$":
                    return val * dollar;
                case "r":
                    return val * ruble;
                default:
                    return -1;
            }
        }

    }
}
