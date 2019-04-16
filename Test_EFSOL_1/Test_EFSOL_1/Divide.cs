using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Divide
    {
        public static void To_Same_L()
        {
            int e = Find_Dot();
            StatClass.num1 = Convert.ToDouble(StatClass.number1);
            StatClass.num2 = Convert.ToDouble(StatClass.number2);
            StatClass.num1 = StatClass.num1 * e;
            StatClass.num2 = StatClass.num2 * e;
            StatClass.number1 = Convert.ToString(StatClass.num1);
            StatClass.number2 = Convert.ToString(StatClass.num2);
        }


             public static int Find_Dot()
        {
            int increase = 1;
            int in_num1 = StatClass.number1.IndexOf(',');
            int in_num2 = StatClass.number2.IndexOf(','); ;
            if (in_num1 != -1)
            {
                in_num1 = StatClass.number1.Length - in_num1 - 1;
            }
            if (in_num2 != -1)
            {
                in_num2 = StatClass.number2.Length - in_num2 - 1;
            }
            if (in_num1 >= in_num2)
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
                if (StatClass.number1 == "0")
                {
                    StatClass.result = "0";
                    return;
                }
                   To_Same_L();
                bool stop = false;  
                bool put_dot = false; 
                int length_take = StatClass.number2.Length;
                int divider = Convert.ToInt32(StatClass.number2);
                StatClass.remain = "0";
                bool start = true;
                while (!stop)
                {
                    int length_num1 = StatClass.number1.Length;
                    int i = 0;
                    int num_dividend = Convert.ToInt32(StatClass.remain);
                    while (num_dividend < divider)
                    {
                        if (start)
                        {
                            if (StatClass.number1 == "")
                            {
                                if (!put_dot)
                                {
                                    StatClass.result = StatClass.result + "0,";
                                    StatClass.number1 = StatClass.number1 + '0';
                                    put_dot = true;
                                }
                                else
                                {
                                    StatClass.result = StatClass.result + '0';
                                    StatClass.number1 = StatClass.number1 + '0';
                                }
                            }
                            StatClass.remain = StatClass.remain + StatClass.number1[0];
                            StatClass.number1 = StatClass.number1.Remove(0, 1);
                            num_dividend = Convert.ToInt32(StatClass.remain);
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (StatClass.number1 == "")
                                {
                                    if (!put_dot)
                                    {
                                        StatClass.result = StatClass.result + ',';
                                        StatClass.number1 = StatClass.number1 + '0';
                                        put_dot = true;
                                    }
                                    else
                                    {
                                        StatClass.number1 = StatClass.number1 + '0';
                                    }
                                }
                                StatClass.remain = StatClass.remain + StatClass.number1[0];
                                StatClass.number1 = StatClass.number1.Remove(0, 1); 
                                num_dividend = Convert.ToInt32(StatClass.remain);
                            }
                            else
                            {
                                StatClass.result = StatClass.result + '0'; 
                                if (StatClass.number1 == "")
                                {
                                    if (!put_dot)
                                    {
                                        StatClass.result = StatClass.result + ',';
                                        StatClass.number1 = StatClass.number1 + '0';
                                        put_dot = true;
                                    }
                                    else
                                    {
                                        StatClass.number1 = StatClass.number1 + '0';
                                    }
                                }
                                StatClass.remain = StatClass.remain + StatClass.number1[0];
                                StatClass.number1 = StatClass.number1.Remove(0, 1);
                                num_dividend = Convert.ToInt32(StatClass.remain);
                            }
                            i++;
                        }
                    }
                    num_dividend = Convert.ToInt32(StatClass.remain);
                    int c = num_dividend / divider;
                    StatClass.result = StatClass.result + Convert.ToString(c);
                    int ost = num_dividend - c * divider;
                    StatClass.remain = Convert.ToString(ost);
                    start = false;
                    int stop_point = StatClass.result.IndexOf(',');
                    if (stop_point != -1)
                    {
                        if (StatClass.result.Length - stop_point > 12)
                        {
                            stop = true;
                        }
                    }
                } 
                bool clear = true;
                while (clear) //Clear zero
                {
                    int last_symbol = StatClass.result.Length - 1;
                    if ((StatClass.result[last_symbol] == '0') || (StatClass.result[last_symbol] == ','))
                    {
                        StatClass.result = StatClass.result.Remove(last_symbol, 1);
                        if (StatClass.result[last_symbol] == ',')
                        {
                            clear = false;
                        }
                    }
                    else
                    {
                        clear = false;
                    }
                }
            }
        }
    }
