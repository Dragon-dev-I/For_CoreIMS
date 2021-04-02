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
        public int Dollar_exchange_rate
        {
            get { return exchange_rate; }
        }
        public int AbsoluteValue()
        {
            return exchange_rate * Val;
        }
        public double REAbsoluteValue(int val)
        {
            return (double)val / (double)exchange_rate;
        }
        public static String operator +(Dollar c1, Euro c2)
        {
            Dollar res = new Dollar();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "$";
        }
        public static String operator +(Dollar c1, Ruble c2)
        {
            Dollar res = new Dollar();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "$";
        }
        public static String operator -(Dollar c1, Euro c2)
        {
            Dollar res = new Dollar();
            return res.REAbsoluteValue(c1.AbsoluteValue() - c2.AbsoluteValue()).ToString() + "$";
        }
        public static String operator -(Dollar c1, Ruble c2)
        {
            Dollar res = new Dollar();
            return res.REAbsoluteValue(c1.AbsoluteValue() - c2.AbsoluteValue()).ToString() + "$";
        }
        public static bool operator >(Dollar c1, Euro c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator >(Dollar c1, Ruble c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator <(Dollar c1, Euro c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
        public static bool operator <(Dollar c1, Ruble c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
    }
    class Euro : Money
    {
        private const int exchange_rate = 90;
        public int Euro_exchange_rate
        {
            get { return exchange_rate; }
        }
        public int AbsoluteValue()
        {
            return exchange_rate * Val;
        }
        public double REAbsoluteValue(int val)
        {
            return (double)val / (double)exchange_rate;
        }
        public static String operator +(Euro c1, Dollar c2)
        {
            Euro res = new Euro();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "e";
        }
        public static String operator +(Euro c1, Ruble c2)
        {
            Euro res = new Euro();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "e";
        }
        public static String operator -(Euro c1, Dollar c2)
        {
            Euro res = new Euro();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "e";
        }
        public static String operator -(Euro c1, Ruble c2)
        {
            Euro res = new Euro();
            return res.REAbsoluteValue(c1.AbsoluteValue() - c2.AbsoluteValue()).ToString() + "e";
        }
        public static bool operator >(Euro c1, Dollar c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator >(Euro c1, Ruble c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator <(Euro c1, Dollar c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
        public static bool operator <(Euro c1, Ruble c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
    }
    class Ruble : Money
    {
        private const int exchange_rate = 1;
        public int Ruble_exchange_rate
        {
            get { return exchange_rate; }
        }
        public int AbsoluteValue()
        {
            return exchange_rate * Val;
        }
        public double REAbsoluteValue(int val)
        {
            return (double)val / (double)exchange_rate;
        }
        public static String operator +(Ruble c1, Euro c2)
        {
            Ruble res = new Ruble();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "r";
        }
        public static String operator +(Ruble c1, Dollar c2)
        {
            Ruble res = new Ruble();
            return res.REAbsoluteValue(c1.AbsoluteValue() + c2.AbsoluteValue()).ToString() + "r";
        }
        public static String operator -(Ruble c1, Euro c2)
        {
            Ruble res = new Ruble();
            return res.REAbsoluteValue(c1.AbsoluteValue() - c2.AbsoluteValue()).ToString() + "r";
        }
        public static String operator -(Ruble c1, Dollar c2)
        {
            Ruble res = new Ruble();
            return res.REAbsoluteValue(c1.AbsoluteValue() - c2.AbsoluteValue()).ToString() + "r";
        }
        public static bool operator >(Ruble c1, Dollar c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator >(Ruble c1, Euro c2)
        {
            return c1.AbsoluteValue() > c2.AbsoluteValue();
        }
        public static bool operator <(Ruble c1, Dollar c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
        public static bool operator <(Ruble c1, Euro c2)
        {
            return c1.AbsoluteValue() < c2.AbsoluteValue();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            String x_val = "";
            String y_val = "";

            String x_currency = "";
            String y_currency = "";

            String operation = "";

            String mes_number = "Enter a number";
            String mes = "Enter currency sign (r - ruble, $ - dollar, e - euro)";
            String mes_operation = "Enter operation (> comparison, < comparison, + summation, - subtraction)";

            Console.WriteLine(mes_number);
            x_val = Console.ReadLine();
            Console.WriteLine(mes);
            x_currency = Console.ReadLine();

            Console.WriteLine(mes_number);
            y_val = Console.ReadLine();
            Console.WriteLine(mes);
            y_currency = Console.ReadLine();

            Console.WriteLine(mes_operation);
            operation = Console.ReadLine();


            dynamic money_val1 = 0;
            dynamic money_val2 = 0;

            switch (x_currency)
            {
                case "r":
                    Ruble ruble = new Ruble();
                    ruble.Val = Convert.ToInt32(x_val);
                    money_val1 = ruble;
                    break;
                case "$":
                    Dollar dollar = new Dollar();
                    dollar.Val = Convert.ToInt32(x_val);
                    money_val1 = dollar;
                    break;
                case "e":
                    Euro euro = new Euro();
                    euro.Val = Convert.ToInt32(x_val);
                    money_val1 = euro;
                    break;
                default:
                    Console.WriteLine("Error: operation (> comparison, < comparison, + summation, - subtraction) not found");
                    break;
            }
            switch (y_currency)
            {
                case "r":
                    Ruble ruble = new Ruble();
                    ruble.Val = Convert.ToInt32(y_val);
                    money_val2 = ruble;
                    break;
                case "$":
                    Dollar dollar = new Dollar();
                    dollar.Val = Convert.ToInt32(y_val);
                    money_val2 = dollar;
                    break;
                case "e":
                    Euro euro = new Euro();
                    euro.Val = Convert.ToInt32(y_val);
                    money_val2 = euro;
                    break;
                default:
                    Console.WriteLine("Error: operation (> comparison, < comparison, + summation, - subtraction) not found");
                    break;
            }
            switch (operation)
            {
                case ">":
                    Console.WriteLine(money_val1 > money_val2);
                    break;
                case "<":
                    Console.WriteLine(money_val1 < money_val2);
                    break;
                case "+":
                    Console.WriteLine(money_val1 + money_val2);
                    break;
                case "-":
                    Console.WriteLine(money_val1 - money_val2);
                    break;
                default:
                    Console.WriteLine("Error: operation (? comparison, + summation, - subtraction) not found");
                    break;
            }
            Console.ReadKey();
        }
    }
}
