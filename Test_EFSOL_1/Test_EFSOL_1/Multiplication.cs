using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Multiplication
    {
        public static void Multiplicate()
        {
            Addition.Get_Parts();

            StatClass.num1_fractional_s = Convert.ToString(StatClass.num1_fractional);
            StatClass.num2_fractional_s = Convert.ToString(StatClass.num2_fractional);


            StatClass.num1_fractional_l = StatClass.num1_fractional_s.Length - 2;
     //       Console.WriteLine("length1" + StatClass.num2_fractional_l);
            StatClass.num2_fractional_l = StatClass.num2_fractional_s.Length - 2;
   //         Console.WriteLine("length2" + StatClass.num2_fractional_l);
            StatClass.fractional_l = StatClass.num1_fractional_l + StatClass.num2_fractional_l;
   //         Console.WriteLine("final length " + StatClass.fractional_l);

            StatClass.num1 = StatClass.num1 * Math.Pow(10, StatClass.num1_fractional_l);
    //        Console.WriteLine("Full1 " + StatClass.num1);
            StatClass.num2 = StatClass.num2 * Math.Pow(10, StatClass.num2_fractional_l);
    //        Console.WriteLine("Full1 " + StatClass.num2);

            int counter = Convert.ToString(StatClass.num1).Length - 1;
    //        Console.WriteLine("counter " + counter);
            int i = 0;
            while (counter != -1)
            {
                string temp_s_1;
                int temp_11;

                char i1 = Convert.ToString(StatClass.num1)[counter];
    //            Console.WriteLine("temp_1  " + i1);
                temp_s_1 = Convert.ToString(i1);
                temp_11 = Convert.ToInt16(temp_s_1);
     //           Console.WriteLine("temp_1afdhsf  " + temp_11);

                StatClass.summ += temp_11 * StatClass.num2 * Math.Pow(10, i++);
      //          Console.WriteLine("summ   " + StatClass.summ);




                counter--;
            }

            StatClass.result = Convert.ToString(StatClass.summ / Math.Pow(10, StatClass.fractional_l));

        }
    }
}
