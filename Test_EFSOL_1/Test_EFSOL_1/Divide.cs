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
            int dividend, divider, divider_length;
            StatClass.quotient = "";
            if (StatClass.num1_fractional > 0)
            {
                StatClass.lengh_num1_fractional = Convert.ToString(StatClass.num1_fractional).Length - 2;

            }
            if (StatClass.num2_fractional > 0)
            {
                StatClass.lengh_num2_fractional = Convert.ToString(StatClass.num2_fractional).Length - 2;
            }

            if (StatClass.lengh_num1_fractional > StatClass.lengh_num2_fractional)
            {
                dividend = Convert.ToInt32(StatClass.num1 * Math.Pow(10, StatClass.lengh_num1_fractional));
                divider = Convert.ToInt32(StatClass.num2 * Math.Pow(10, StatClass.lengh_num1_fractional));
            }
            else if (StatClass.lengh_num1_fractional < StatClass.lengh_num2_fractional)
            {
                dividend = Convert.ToInt32(StatClass.num1 * Math.Pow(10, StatClass.lengh_num2_fractional));
                divider = Convert.ToInt32(StatClass.num2 * Math.Pow(10, StatClass.lengh_num2_fractional));
            }
            else
            {
                dividend = Convert.ToInt32(StatClass.num1 * Math.Pow(10, StatClass.lengh_num1_fractional));
                divider = Convert.ToInt32(StatClass.num2 * Math.Pow(10, StatClass.lengh_num1_fractional));
            }

            divider_length = Convert.ToInt32(Convert.ToString(divider).Length);

            if (dividend > divider)
            {
                while (dividend > divider)
                { 
                StatClass.temp_dividend = Convert.ToInt32(Convert.ToString(dividend).Substring(0, divider_length));
                Console.WriteLine("стат делимое"+ StatClass.temp_dividend);
                dividend = Convert.ToInt32(Convert.ToString(dividend).Remove(0, divider_length));
                Console.WriteLine("просто делимое" + dividend);
                Console.WriteLine("просто делитель" + divider);

                if (StatClass.temp_dividend >= divider)
                {
                    int temp_divider = divider, i;
                    for (i = 1; StatClass.temp_dividend > temp_divider; i++)
                    {
                        temp_divider *= i;
                        Console.WriteLine("i=" + i);
                        Console.WriteLine(" temp_divider=" + temp_divider);

                    }
                    temp_divider = divider * (i - 2);
                    StatClass.result += i - 2;
                    Console.WriteLine("new временный делитель=" + temp_divider);
                    Console.WriteLine("туц i=" + StatClass.result);
                    StatClass.quotient = String.Join("", Convert.ToString(i));
                    StatClass.temp_dividend -= temp_divider;
                    dividend = Convert.ToInt32(Convert.ToString(dividend).Insert(0, Convert.ToString(StatClass.temp_dividend)));
                }
                 //   Console.WriteLine(dividend);


                }

            }

        }
    }
}
