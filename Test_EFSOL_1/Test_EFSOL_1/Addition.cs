using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Addition
    {
        public static void Get_Parts()
        {
            StatClass.num1_integer = Convert.ToInt32(Math.Truncate(StatClass.num1));
            Console.WriteLine("num1_integer " + StatClass.num1_integer);
            StatClass.num1_fractional = Math.Round((StatClass.num1 - Convert.ToDouble(StatClass.num1_integer)), (Convert.ToString(StatClass.num1).Length));
            Console.WriteLine("num1_fractional " + StatClass.num1_fractional);

            StatClass.num2_integer = Convert.ToInt32(Math.Truncate(StatClass.num2));
            Console.WriteLine("num2_integer " + StatClass.num2_integer);
            StatClass.num2_fractional = Math.Round((StatClass.num2 - Convert.ToDouble(StatClass.num2_integer)), (Convert.ToString(StatClass.num2).Length));
            Console.WriteLine("num2_fractional " + StatClass.num2_fractional);
        }

        public static void Get_Same_Int()
        {
            StatClass.num1_integer_s = Convert.ToString(StatClass.num1_integer);
            StatClass.num2_integer_s = Convert.ToString(StatClass.num2_integer);

            if ((StatClass.num1_integer_s.Length) > (StatClass.num2_integer_s.Length))
            {
                while ((StatClass.num1_integer_s.Length) > (StatClass.num2_integer_s.Length))
                {
                    StatClass.num2_integer_s = StatClass.num2_integer_s.Insert(0, "0");
                }
            }
            else if ((StatClass.num1_integer_s.Length) < (StatClass.num2_integer_s.Length))
            {
                while ((StatClass.num1_integer_s.Length) < (StatClass.num2_integer_s.Length))
                {
                    StatClass.num1_integer_s = StatClass.num1_integer_s.Insert(0, "0");
                }
            }

        }

        public static void Get_Same_Fractional()
        {
            StatClass.num1_fractional_s = Convert.ToString(StatClass.num1_fractional);
            StatClass.num2_fractional_s = Convert.ToString(StatClass.num2_fractional);

            if ((StatClass.num1_fractional_s.Length) > (StatClass.num2_fractional_s.Length))
            {
                while ((StatClass.num1_fractional_s.Length) > (StatClass.num2_fractional_s.Length))
                {
                    StatClass.num2_fractional_s += "0";
                }
            }
            else if ((StatClass.num1_fractional_s.Length) < (StatClass.num2_fractional_s.Length))
            {
                while ((StatClass.num1_fractional_s.Length) < (StatClass.num2_fractional_s.Length))
                {
                    StatClass.num1_fractional_s += "0";
                }
            }

        }

        public static void Get_Ready()
        {
            StatClass.number1 += StatClass.num1_integer_s;
            StatClass.number1 += StatClass.num1_fractional_s.Remove(0 , 1);

            StatClass.number2 += StatClass.num2_integer_s;
            StatClass.number2 += StatClass.num2_fractional_s.Remove(0, 1);
        }

            public static void Add()
        {
            StatClass.result = "";
            Get_Parts();
            Get_Same_Int();
            Console.WriteLine("StatClass.num1_integer_s " + StatClass.num1_integer_s);
            Console.WriteLine("num2_integer_s " + StatClass.num2_integer_s);
            Get_Same_Fractional(); 
            Console.WriteLine("StatClass.num1_fractional_s " + StatClass.num1_fractional_s);
            Console.WriteLine("num2_fractional_s " + StatClass.num2_fractional_s);
            Get_Ready();
            Console.WriteLine("number1 " + StatClass.number1);
            Console.WriteLine("number2 " + StatClass.number2);

            int counter = StatClass.number1.Length - 1;
            Console.WriteLine("counter " + counter);
         //   Console.WriteLine("counter123 " + StatClass.number1[6]);

            while (counter != -1)
            { string temp_s_1, temp_s_2;
                int temp_11, temp_12, summ;
                try
                {
                    Console.WriteLine("counter123 " + StatClass.number1[counter]);
                    char i1 = StatClass.number1[counter];
                    Console.WriteLine("temp_1  " + i1);
                    temp_s_1 = Convert.ToString(i1);
                    temp_11 = Convert.ToInt16(temp_s_1);
                    Console.WriteLine("temp_1afdhsf  " + temp_11);

                     i1 = StatClass.number2[counter];
                    Console.WriteLine("temp_2  " + i1);
                    temp_s_2 = Convert.ToString(i1);
                    temp_12 = Convert.ToInt16(temp_s_2);
                    Console.WriteLine("temp_1afdhsf  " + temp_12);

                    summ = temp_11 + temp_12 + StatClass.reg;
                    if (summ > 9)
                    {
                        summ %= 10;
                        StatClass.reg = 1;
                    }
                    else
                    {
                        StatClass.reg = 0;
                    }

                    if (StatClass.result == "")
                    {
                        StatClass.result = Convert.ToString(summ);
                        Console.WriteLine("result  " + StatClass.result);
                    }
                    else
                    {
                        StatClass.result = StatClass.result.Insert(0, Convert.ToString(summ));
                        Console.WriteLine("result  " + StatClass.result);
                    }

                  

                }
                catch
                {
                    StatClass.result = StatClass.result.Insert(0, ",");
                }


                counter--;

                if ((counter == -1) && (StatClass.reg == 1))
                {
                    StatClass.result = StatClass.result.Insert(0, "1");
                }
            }

        }

    }
}
