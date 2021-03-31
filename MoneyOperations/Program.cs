using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            String x_val = "";
            String y_val = "";

            String x_currency = "";
            String y_currency = "";

            String operation = "";

            String ans = "";


            String mes_number = "Enter a number";
            String mes = "Enter currency sign (r - ruble, $ - dollar, e - euro)";
            String mes_operation = "Enter operation (? comparison, + summation, - subtraction)";

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

            switch (operation)
            {
                case "?":
                    ans = comparison(x_val, x_currency, y_val, y_currency);
                    break;
                case "+":
                    ans = summation(x_val, x_currency, y_val, y_currency);
                    break;
                case "-":
                    Console.WriteLine("Enter y or n: val1 - val2?");
                    String check = Console.ReadLine();
                    ans = subtraction(x_val, x_currency, y_val, y_currency, check);
                    break;
                default:
                    ans = "Error: operation (? comparison, + summation, - subtraction) not found";
                    break;
            }

            Console.WriteLine(ans);
            Console.ReadKey();
        }

        protected static String comparison (String x_val, String x_currency, String y_val, String y_currency)
        {
            Money money = new Money();
            String ans = "val1 or val2 is null";
            if (x_val != null && y_val !=null)
            {
                ans = money.AbsoluteValue(Convert.ToInt32(x_val), x_currency) > money.AbsoluteValue(Convert.ToInt32(y_val), y_currency) ?
                    (x_val + x_currency) : (y_val + y_currency);
            }
            return ans;
        }

        protected static String summation(String x_val, String x_currency, String y_val, String y_currency)
        {
            Money money = new Money();
            String ans = "val1 or val2 is null";
            if (x_val != null && y_val != null)
            {
                ans = Convert.ToString(money.AbsoluteValue(Convert.ToInt32(x_val), x_currency) + money.AbsoluteValue(Convert.ToInt32(y_val), y_currency)) + "rub";
            }
            return ans;
        }

        protected static String subtraction(String x_val, String x_currency, String y_val, String y_currency, String check)
        {
            Money money = new Money();
            String ans = "val1 or val2 is null";

            if (check == "y")
            {
                ans = Convert.ToString(money.AbsoluteValue(Convert.ToInt32(x_val), x_currency) - money.AbsoluteValue(Convert.ToInt32(y_val), y_currency)) + "rub";
            }
            else
            {
                ans = Convert.ToString(money.AbsoluteValue(Convert.ToInt32(y_val), y_currency) - money.AbsoluteValue(Convert.ToInt32(x_val), x_currency)) + "rub";
            }
            return ans;
        }
    }
}
