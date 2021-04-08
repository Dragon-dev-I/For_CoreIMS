using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyOperations
{
    class Dollar : Money
    {
        private const int exchange_rate = 60;
        public override double ExchangeRate()
        {
            return exchange_rate;
        }
    }
    class Euro : Money
    {
        private const int exchange_rate = 90;
        public override double ExchangeRate()
        {
            return exchange_rate;
        }
    }
    class Ruble : Money
    {
        private const int exchange_rate = 1;
        public override double ExchangeRate()
        {
            return exchange_rate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Dollar { Val = 1 };
            var b = new Ruble { Val = 30 };
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
