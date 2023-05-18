using ExtremeCalculatorDataType;
using ExtremeCalculatorUtils;

namespace ExtremeCalculator
{
    public static class SpecialOperations
    {
        private static StringNumber Addition(StringNumber num1, StringNumber num2)
        {
            StringNumber result = new StringNumber(false, "");
            StringNumber largeStrnum = Utils.CompareTwoStringNumbers(true, num1, num2);
            StringNumber smallStrnum = Utils.CompareTwoStringNumbers(false, num1, num2);

            int carry = 0;

            if(largeStrnum.Number == smallStrnum.Number)
            {
                if(largeStrnum.Sign ^ smallStrnum.Sign)
                {
                    result.Sign = false;
                    result.Number = "0";

                    return result;
                }
            }

            result.Sign = largeStrnum.Sign;
            Utils.AppendStringNumbersOnLeft("0", ref smallStrnum, largeStrnum.Number.Length);

            for (int i = largeStrnum.Number.Length-1; i >= 0 ; i--)
            {
                int digitFromLargeStrnum = Int16.Parse(largeStrnum.Number.Substring(i, 1));
                int digitFromSamllStrnum = Int16.Parse(smallStrnum.Number.Substring(i, 1));
                int temp = Utils.ReturnSign(largeStrnum.Sign) * digitFromLargeStrnum + Utils.ReturnSign(smallStrnum.Sign) * digitFromSamllStrnum;

                if (temp + carry <= 0 && largeStrnum.Sign)
                {
                    result.Number = Math.Abs(temp + carry)%10 + result.Number;
                    carry = 0 - (int)Math.Floor(Math.Abs(temp + carry) / 10m);
                } 
                else if (temp + carry > 0 && largeStrnum.Sign)
                {
                    result.Number = Math.Abs(temp + carry - 10) + result.Number;
                    carry = 1;
                }
                else if(temp + carry < 0 && !largeStrnum.Sign)
                {
                    result.Number = (temp + carry + 10) + result.Number;
                    carry = -1;
                }
                else if (temp + carry >= 0 && !largeStrnum.Sign)
                {
                    result.Number = (temp + carry)%10 + result.Number;
                    carry = 0 + (int)Math.Floor((temp + carry) / 10m);
                }

            }

            if(carry != 0)
            {
                result.Number = Math.Abs(carry) + result.Number;
            }

            result.Number = result.Number.TrimStart('0');

            return result;
        }
        
        public static StringNumber Additions(params StringNumber[] nums)
        {
            StringNumber result = nums[0];
            
            for(int i=1; i < nums.Length; i++)
            {
                result = Addition(result, nums[i]);
            }

            return result;
        }

    }
}