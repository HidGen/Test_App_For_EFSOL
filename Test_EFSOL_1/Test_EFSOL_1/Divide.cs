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
            int dividend, divider, divider_length, dividend_length;
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

            divider_length = Convert.ToInt32(Convert.ToString(divider).Length);         //   получаем длину делителя
            dividend_length = Convert.ToInt32(Convert.ToString(dividend).Length);           //   получаем длину делимого
            StatClass.remain = 1;
            StatClass.result = "";
            Console.WriteLine(dividend);
            Console.WriteLine(divider);
            while (StatClass.remain != 0)
            {
                int c = 0;
                while (StatClass.temp_dividend < divider)
                {
                    try
                    {
                        Console.WriteLine(c);

                        StatClass.temp_dividend = Convert.ToInt32(Convert.ToString(dividend * Math.Pow(10, c)).Substring(0, divider_length));
                        Console.WriteLine("стат делимое" + StatClass.temp_dividend);
                        if (StatClass.temp_dividend < divider)
                        {
                            c++;
                            // Console.WriteLine(c);

                        }
                        StatClass.useless_dividend = (Convert.ToString((dividend * Math.Pow(10, c))).Remove(0, divider_length));

                    }
                    catch
                    {
                        if (StatClass.result == "")
                        {
                            StatClass.result += "0";
                        }

                        if (StatClass.result.Contains('.'))
                        {
                            StatClass.result += "0";
                        }
                        else { StatClass.result += "."; }
                        c++;
                    }
                }
                Console.WriteLine(StatClass.temp_dividend);

                int temp_divider = divider, i;
                for (i = 1; StatClass.temp_dividend >= temp_divider; i++)
                {
                    temp_divider = divider;
                    temp_divider *= i;
                    Console.WriteLine("i=" + i);
                    Console.WriteLine(" temp_divider=" + temp_divider);
                    
                }
             temp_divider = divider * (i - 2);
                Console.WriteLine("new temp_divider=" + temp_divider);
                StatClass.temp_dividend -= temp_divider;
                dividend = StatClass.temp_dividend;
                Console.WriteLine("new temp_dividend=" + dividend);
                StatClass.remain = dividend;
                dividend = Convert.ToInt32(Convert.ToString(dividend)+ StatClass.useless_dividend);

                Console.WriteLine("new i=" + (i-2));
                StatClass.result += (i-2);
             //   StatClass.remain -= 1;
                Console.WriteLine("result =" + StatClass.result);
                /*
                StatClass.result = String.Join("", i - 2);
                Console.WriteLine("new временный делитель=" + temp_divider);
                Console.WriteLine("result=" + StatClass.result);
                StatClass.quotient = String.Join("", Convert.ToString(i));
                StatClass.temp_dividend -= temp_divider;
                dividend = Convert.ToInt32(Convert.ToString(dividend).Insert(0, Convert.ToString(StatClass.temp_dividend)));
                StatClass.remain = dividend;*/
            }


        }
    }
}
