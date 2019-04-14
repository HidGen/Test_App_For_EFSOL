using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Divide
    {
        public static int FloatHere()
        {
            int increase = 1;
            int in_num1 = StatClass.number1.IndexOf(',');

            Console.WriteLine(in_num1);
            int in_num2 = StatClass.number2.IndexOf(','); ;
            if (in_num1 != -1)
            {
                in_num1 = StatClass.number1.Length - in_num1 - 1;
            }
            if (in_num2 != -1)
            {
                in_num2 = StatClass.number2.Length - in_num2 - 1;
            }
            if (in_num1 > in_num2)
            {
                for (int i = 1; i <= in_num1; i++)
                {
                    increase *= 10;
                }
            }
            if (in_num1 < in_num2)
            {
                for (int i = 1; i <= in_num2; i++)
                {
                    increase *= 10;
                }
            }
            return increase;
        }
        public static void DivisionNumbers()
        {

            StatClass.num1_integer = Convert.ToInt32(Math.Truncate(StatClass.numba1));
            Console.WriteLine("num1_integer " + StatClass.num1_integer);
            StatClass.num1_fractional = Math.Round((StatClass.numba1 - Convert.ToDouble(StatClass.num1_integer)), (Convert.ToString(StatClass.numba1).Length));
            Console.WriteLine("num1_fractional " + StatClass.num1_fractional);
            StatClass.num1_fractional_L = Convert.ToString(StatClass.num1_fractional).Remove(0, 2);
            Console.WriteLine("num1_fractional_L " + StatClass.num1_fractional_L);

            //        StatClass.operation = StatClass.number1.Remove(0, StatClass.number1.Length - 1);
            //        StatClass.number1 = StatClass.number1.Remove(StatClass.number1.Length - 2, 2);
            int e = FloatHere();
            StatClass.num1 = Convert.ToDouble(StatClass.number1);
            StatClass.num2 = Convert.ToDouble(StatClass.number2);
            StatClass.num1 = StatClass.num1 * e;
            StatClass.num2 = StatClass.num2 * e;
            StatClass.number1 = Convert.ToString(StatClass.num1);
            StatClass.number2 = Convert.ToString(StatClass.num2);
           // bool stop = false;  // Остановка цикла
            bool comma = false; //Переменная, которая определяет наличие запятой
            int length_num2 = StatClass.number2.Length;
            int divider = Convert.ToInt32(StatClass.number2); //Записываем делитель
            int iteration = 1;
            while (StatClass.number1 != "00")
            {
                int length_num1 = StatClass.number1.Length;
                int c = 0;
                if (length_num1 >= length_num2)
                {
                    int length_num = length_num2;
                    string str_argument1 = StatClass.number1.Substring(0, length_num); //Обрезаем строку под размер делителя
                    int dividend = Convert.ToInt32(str_argument1);
                    if (dividend >= divider) //Если делимое больше или равно делителю
                    {
                        c = dividend / divider;
                        StatClass.result = StatClass.result + Convert.ToString(c);
                        int ostatok = dividend - c * divider;
                        StatClass.number1 = StatClass.number1.Remove(0, length_num);
                        StatClass.number1 = StatClass.number1.Insert(0, Convert.ToString(ostatok));
                        if (comma)
                        {
                            StatClass.number1 = StatClass.number1 + "0";
                        }
                    }
                    else  //Если делимое меньше делителя
                    {
                        length_num = length_num + 1;
                        if (length_num <= length_num1) //Забираем из строки еще одно число
                        {
                            str_argument1 = StatClass.number1.Substring(0, length_num);
                            dividend = Convert.ToInt32(str_argument1);
                            c = dividend / divider;
                            StatClass.result = StatClass.result + Convert.ToString(c);
                            int ostatok = dividend - c * divider;
                            StatClass.number1 = StatClass.number1.Remove(0, length_num);
                            StatClass.number1 = StatClass.number1.Insert(0, Convert.ToString(ostatok));
                            if (comma)
                            {
                                StatClass.number1 += "0";
                            }
                        }
                        else //Добавляем еще 0 
                        {
                            StatClass.number1 += "0";
                            if (!comma)
                            {
                                StatClass.result += ',';
                                comma = true;
                            }
                            else
                            {
                                StatClass.result += "0";
                            }
                        }
                    }
                }
                else
                {
                    if (!comma)
                    {
                        Console.WriteLine(StatClass.number1);
                        if (StatClass.result == null)
                        {
                            StatClass.result += "0";
                        }
                        else if ((!StatClass.result.Contains(",")) && (StatClass.result != null) && (StatClass.number1 == StatClass.num1_fractional_L))           //   вот такое условие для правильной расстановки нулей
                        { StatClass.result += "0"; }
                        
                            StatClass.result += ",";
                        

                        comma = true;
                    }
                    else
                    {
                        StatClass.result += "0";
                    }
                    StatClass.number1 += "0";
                }
                /* if (StatClass.number1 == "00")
                 {
                     break;
                 }*/
                iteration++;
            }
        }
    }
}
