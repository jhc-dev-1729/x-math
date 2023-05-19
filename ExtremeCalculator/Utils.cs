using ExtremeCalculatorDataType;
using ExtremeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeCalculatorUtils
{
    public static class Utils
    {

        public static void AppendStringNumbersOnRight(string sourceNumber, ref StringNumber targetStringNumber, int offset)
        {
            int length = targetStringNumber.Number.Length;
            for (int i = 0; i < offset - length; i++)
            {
                targetStringNumber.Number +=  sourceNumber;
            }

        }

        public static void AppendStringNumbersOnLeft(string sourceNumber, ref StringNumber targetStringNumber, int offset)
        {
            string result = "";
            int length = targetStringNumber.Number.Length;
            for (int i = 0; i < offset - length; i++)
            {
                result += sourceNumber;
            }
            targetStringNumber.Number = result + targetStringNumber.Number;

        }

        public static int ReturnSign(Boolean sign)
        {
            if (sign)
            {
                return -1;
            }
            return 1;
        }

        public static StringNumber CompareTwoStringNumbers(Boolean isLarge, StringNumber strnum1, StringNumber strnum2)
        {

            if (strnum1.Number.Length > strnum2.Number.Length)
            {
                return isLarge ? strnum1 : strnum2;
            }
            else if (strnum1.Number.Length == strnum2.Number.Length)
            {
                if (Int16.Parse(strnum1.Number.Substring(0, 1)) > Int16.Parse(strnum2.Number.Substring(0, 1)))
                {
                    return isLarge ? strnum1 : strnum2;
                }
                else
                {
                    return isLarge ? strnum2 : strnum1;
                }
            }
            else
            {
                return isLarge ? strnum2 : strnum1;
            }

        }

        public static Boolean DoesTwoStringNumbersAreEqual(StringNumber strnum1, StringNumber strnum2)
        {
            if(strnum1.Sign == strnum2.Sign && strnum1.Number == strnum2.Number)
            {
                return true;
            }
            return false;
        }
    }
}
