using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Divide
    {
        public static void Get_Length()
        {
            StatClass.divider_length = Convert.ToInt32(StatClass.divider.Length);           //   получение длины делителя
            Console.WriteLine("divider_length " + StatClass.divider_length);
            if (StatClass.dividend.Contains(","))         //   получение длины "рабочей" части делимого
            {
                StatClass.dividend_length = Convert.ToInt32(StatClass.dividend.Length) - 1;
                Console.WriteLine("dividend_length " + StatClass.dividend_length);
            }
            else
            {
                StatClass.dividend_length = Convert.ToInt32(StatClass.dividend.Length);
                Console.WriteLine("dividend_length " + StatClass.dividend_length);
            }
            if ((Convert.ToDouble(StatClass.divider)) > (Convert.ToDouble(StatClass.dividend)))         //   обработка случая, когда делимое меньше делителя и получение новой "рабочей" длины делимого
            {
                Console.WriteLine("делимое меньше");
                if (StatClass.dividend[0] == '0')
                {
                    StatClass.dividend.Remove(0, 2);
                    StatClass.result += "0,";
                    //    dividend = dividend.Replace(",", "");
                    StatClass.dividend_length = Convert.ToInt32(StatClass.dividend.Length);
                    Console.WriteLine("new dividend_length " + (StatClass.dividend_length - 1));
                    Console.WriteLine("result " + StatClass.result);
                }
                else
                {
                    StatClass.result += "0,";
                    StatClass.dividend = StatClass.dividend.Replace(",", "");
                    StatClass.dividend_length = Convert.ToInt32(StatClass.dividend.Length);
                    Console.WriteLine("new dividend_length " + StatClass.dividend_length);
                    Console.WriteLine("result " + StatClass.result);
                }
            }
            }

        public static void Get_Substring()
        {
            if (StatClass.dividend_length >= StatClass.divider_length)
            {
                StatClass.temp_dividend = StatClass.dividend.Substring(0, StatClass.divider_length);
                Console.WriteLine("StatClass.temp_dividend " + StatClass.temp_dividend);
                StatClass.dividend = StatClass.dividend.Remove(0, (StatClass.temp_dividend.Length));
                Console.WriteLine("StatClass.dividend " + StatClass.dividend);
                if (StatClass.temp_dividend.Contains(","))
                {
                    StatClass.dividend.Replace(",", "");
                    StatClass.temp_dividend = StatClass.dividend.Substring(0, StatClass.divider_length);
                    Console.WriteLine("StatClass.temp_dividend " + StatClass.temp_dividend);
                    StatClass.dividend = StatClass.dividend.Remove(0, StatClass.temp_dividend.Length);
                    Console.WriteLine("StatClass.dividend " + StatClass.dividend);

                }

            }
            else
            {

                while (StatClass.dividend_length > StatClass.divider_length)            //   доделать обработку вставок нулей и запятых
                {
                    StatClass.temp_dividend = (StatClass.dividend + ("0")).Substring(0, StatClass.divider_length);
                    Console.WriteLine("StatClass.temp_dividend " + StatClass.temp_dividend);

                }
            }
        }
        public static void Division()
        {
            
            
            StatClass.quotient = "";
            StatClass.result = "";          //   обнуление результата
            if (StatClass.num2_fractional > 0)          //   корректное получение кол-ва знаков после запятой
            {
                StatClass.lengh_num2_fractional = Convert.ToString(StatClass.num2_fractional).Length - 2;
                Console.WriteLine("кол-во знаков после запятой в делитете " + StatClass.lengh_num2_fractional);
            }
            else
            {
                StatClass.lengh_num2_fractional = 0;
                Console.WriteLine("кол-во знаков после запятой в делитете " + StatClass.lengh_num2_fractional);
            }
            StatClass.dividend = Convert.ToString(StatClass.num1 * Math.Pow(10, StatClass.lengh_num2_fractional));            //   приведение делимого
            StatClass.divider = Convert.ToString(StatClass.num2 * Math.Pow(10, StatClass.lengh_num2_fractional));         //   приведение делителя
            Console.WriteLine("dividend" + StatClass.dividend);
            Console.WriteLine("divider" + StatClass.divider);
            while (StatClass.remain != 0)
            {
                Get_Length();

            Get_Substring();

         
                if (Convert.ToInt32(StatClass.temp_dividend) > Convert.ToInt32(StatClass.divider))
                {
                    StatClass.temp_divider = Convert.ToInt32(StatClass.divider);
                    int i;
                    for (i = 1; Convert.ToInt32(StatClass.temp_dividend) >= Convert.ToInt32(StatClass.temp_divider); i++)
                    {
                        StatClass.temp_divider = Convert.ToInt32(StatClass.divider);
                        StatClass.temp_divider *= i;
                        Console.WriteLine("i=" + i);
                        Console.WriteLine(" temp_divider=" + StatClass.temp_divider);

                    }
                    StatClass.result += (i - 2);
                    Console.WriteLine("Result" + StatClass.result);
                    StatClass.temp_divider = Convert.ToInt32(StatClass.divider);
                    StatClass.remain = (Convert.ToInt32(StatClass.temp_dividend)) - ((Convert.ToInt32(StatClass.divider)) * (i - 2));
                    Console.WriteLine("remain" + StatClass.remain);
                    StatClass.dividend = StatClass.dividend.Insert(0, Convert.ToString(StatClass.remain));
                    Console.WriteLine("new dividend " + StatClass.dividend);

                }
            }

            

        







        }           //   конец функции


        
    }
}
