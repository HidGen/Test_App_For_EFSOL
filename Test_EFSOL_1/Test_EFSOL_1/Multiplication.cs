using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EFSOL_1
{
    class Multiplication
    {
        public static string Multiplicate()
        {
            string s = umnozh(StatClass.num1, StatClass.num2);
           return  s;
        }

        private static string umnozh(double mnj1, double mnj2)
        {
            string add = "";
            string result = "";
            foreach (char c in mnj1.ToString().Reverse())
            {
                result += char.GetNumericValue(c) * mnj2 + add + "\r\n" + "+" + "\r\n";
                add += "0";
            }
            result += "__________\r\n";
            result += mnj1 * mnj2;
            return result;
        }
    }
}
