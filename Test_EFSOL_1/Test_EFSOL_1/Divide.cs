using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Divide
    {

        public static void Division(/*double dividend, double divider*/)
        {
            string dividend, divider,  temp_dividend_length;
            int divider_length, dividend_length;
            StatClass.quotient = "";
            StatClass.result = "";
            if (StatClass.num2_fractional > 0)
            {
                StatClass.lengh_num2_fractional = Convert.ToString(StatClass.num2_fractional).Length - 2;
                Console.WriteLine("кол-во знаков после запятой в делитете " + StatClass.lengh_num2_fractional);
            }
            else
            {
                StatClass.lengh_num2_fractional = 0;
                Console.WriteLine("кол-во знаков после запятой в делитете " + StatClass.lengh_num2_fractional);
            }
            dividend = Convert.ToString(StatClass.num1 * Math.Pow(10, StatClass.lengh_num2_fractional));
                divider = Convert.ToString(StatClass.num2 * Math.Pow(10, StatClass.lengh_num2_fractional));
            Console.WriteLine("dividend" + dividend);
            Console.WriteLine("divider" + divider);
            divider_length = Convert.ToInt32(divider.Length);
            Console.WriteLine("divider_length " + divider_length);
            if (dividend.Contains(","))
            {
                dividend_length = Convert.ToInt32(dividend.Length) - 1;
                Console.WriteLine("dividend_length " + dividend_length);
            }
            else
            {
                dividend_length = Convert.ToInt32(dividend.Length);
                Console.WriteLine("dividend_length " + dividend_length);
            }
           


            if ((Convert.ToDouble(divider)) > (Convert.ToDouble(dividend)))
            {
                Console.WriteLine("делимое меньше");
                if (dividend[0] == '0')
                {
                    dividend.Remove(0, 1);
                    StatClass.result += "0.";
                    dividend = dividend.Replace(",", "");
                    dividend_length = Convert.ToInt32(dividend.Length);
                    Console.WriteLine("new dividend_length " + (dividend_length - 1));
                    Console.WriteLine("result " + StatClass.result);
                }
                else
                {
                    StatClass.result += "0.";
                    dividend = dividend.Replace(",", "");
                    dividend_length = Convert.ToInt32(dividend.Length);
                    Console.WriteLine("new dividend_length " + dividend_length);
                    Console.WriteLine("result " + StatClass.result);
                }
               
            }

          /*  while (StatClass.remain != 0)
            {
                if (dividend_length > divider_length)
                {
                    StatClass.temp_dividend = dividend.Substring(0, divider_length);
                }
                else
                {
                    StatClass.temp_dividend = (dividend += "0").Substring(0, divider_length);
                }
            }*/





        }           //   конец функции


        
    }
}
