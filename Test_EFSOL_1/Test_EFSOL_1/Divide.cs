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
            int dividend, divider;
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

        }
    }
}
