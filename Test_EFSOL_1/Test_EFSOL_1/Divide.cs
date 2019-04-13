using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Divide
    {
        public static void if_Null()
        {
            StatClass.temp_d.Remove(0, 2);
            StatClass.result += "0,";

        }
        public static void Get_Length()
        {
            StatClass.divider_length = Convert.ToInt32(StatClass.divider.Length);           //   получение длины делителя
            Console.WriteLine("divider_length " + StatClass.divider_length);
                       
            StatClass.dividend_length = Convert.ToInt32(StatClass.dividend.Length);         //   получение длины "рабочей" части делимого
            Console.WriteLine("dividend_length " + StatClass.dividend_length);                  
        }
         

        public static void Get_Substring(int xyz)
        {
            if ((StatClass.dividend_length - xyz) >= StatClass.divider_length)
            {
                StatClass.temp_dividend = StatClass.dividend.Substring(0, StatClass.divider_length);
                Console.WriteLine("StatClass.temp_dividend " + StatClass.temp_dividend);
                StatClass.dividend = StatClass.dividend.Remove(0, (StatClass.temp_dividend.Length));
                Console.WriteLine("StatClass.dividend " + StatClass.dividend);
                if (StatClass.temp_dividend.Contains(","))          //   проверяем, наткнулись ли на строку и если наткнулись, то записываем её в результат и переприсваивем новое временное делимое без запятой
                {
                    int i = 0;
                    while ( StatClass.temp_dividend[i] != ',')
                    {
                        i++;  
                    }
                    StatClass.temp_dividend = StatClass.temp_dividend.Remove(i, 1);
                    StatClass.dividend = StatClass.dividend.Insert(0, StatClass.temp_dividend);
                    //  StatClass.dividend.Replace(",", "");
                    if (StatClass.result == "")
                    {
                        StatClass.result += "0,";
                        Console.WriteLine("1result" + StatClass.result);
                    }
                    else if (StatClass.result.EndsWith(","))
                    {
                        StatClass.result += "0";
                        Console.WriteLine("2result" + StatClass.result);
                    }
                    else
                    {
                        StatClass.result += ",";
                    }
                    Console.WriteLine("rresult" + StatClass.result);
                    Get_Length();
                    Get_Substring(0);
                }
                else if (StatClass.result.EndsWith("0,") && (xyz == 1))
                {
                    StatClass.result += "0";
                    Console.WriteLine("3result" + StatClass.result);
                }

            }
            else
            {
                int count = 0;
                while ((StatClass.dividend_length - xyz) < StatClass.divider_length)           
                {
                    try
                    {
                        string qwerty = "0";
                        int ytrewq = (-xyz);
                        while ( ytrewq != count)
                            {
                            ytrewq++;
                            qwerty += "0";

                        }
                        StatClass.temp_dividend = (StatClass.dividend + (qwerty)).Substring(0, StatClass.divider_length + count);
                        count++;
                        Console.WriteLine("StatClass.temp_dividend " + StatClass.temp_dividend);
                        //  Get_Length();
                        StatClass.dividend_length = Convert.ToInt32(StatClass.temp_dividend.Length);
                        if (xyz == 0)
                        {
                            if (StatClass.result == "")
                            {
                                StatClass.result += "0,";
                            }
                            else if (StatClass.result.Contains(","))
                            {
                                StatClass.result += "0";
                            }
                            else
                            {
                                StatClass.result += ",";
                            }
                            Console.WriteLine("rresult_try" + StatClass.result);
                        }
                    }
                    catch
                    {
                        count++;

                        if (xyz == 0)
                        {
                            if (StatClass.result == "")
                            {
                                StatClass.result += "0,";
                            }
                            else if (StatClass.result.Contains(","))
                            {
                                StatClass.result += "0";
                                Console.WriteLine("4result" + StatClass.result);
                            }
                            else
                            {
                                StatClass.result += ",";
                            }
                        }
                        Console.WriteLine("rresult_catch" + StatClass.result);
                    }
;

                }
            }
        }

        public static void Witch_Bigger()
        {
            Console.WriteLine("Witch_Bigger");
            Console.WriteLine("5result" + StatClass.result);
            if ((Convert.ToInt32(StatClass.temp_dividend)) < (Convert.ToInt32(StatClass.divider)))
            {
                Console.WriteLine("Witch_Bigger_IF");
                if (StatClass.result == "")
                {
                    StatClass.result += "0,";
                }
                else if (StatClass.result.Contains(","))
                {
                    StatClass.result += "0";
                }
                else
                {
                    StatClass.result += ",";
                }

                Get_Substring(1);
            }
        }

        public static void Action()
        {
            int temp_d, temp_D, i;
            temp_d = Convert.ToInt32(StatClass.temp_dividend);
            temp_D = Convert.ToInt32(StatClass.divider);

            for (i = 1; temp_d >= temp_D; i++)
            {
                temp_D = Convert.ToInt32(StatClass.divider);
                temp_D *= i;
                Console.WriteLine("i=" + i);
                Console.WriteLine(" temp_divider=" + temp_D);

            }
            StatClass.result += (i - 2);
            Console.WriteLine("Result" + StatClass.result);
            temp_D = Convert.ToInt32(StatClass.divider);
            StatClass.remain = temp_d - temp_D * (i - 2);
            Console.WriteLine("remain" + StatClass.remain);



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

                Get_Length();
            Get_Substring(0);
            Witch_Bigger();
            Action();



        }           //   конец функции


        
    }
}
