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

            
        }

    }
}
