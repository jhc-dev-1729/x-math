using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeCalculatorDataType
{
    public class Fraction
    {
        public Fraction(Boolean sign, StringNumber numerator, StringNumber denominator)
        {
            this.Sign = !(sign^(!(numerator.Sign ^ denominator.Sign)));
            this.Numerator = numerator.Number;
            this.Denominator = denominator.Number;
        }

        public Boolean Sign
        { get; set; }

        public string Numerator
        { get; set; }

        public string Denominator
        { get; set; }

        public override string ToString()
        {
            return $"[{Numerator},{Denominator}]";
        }

    }

    public struct StringNumber
    {

        public StringNumber(Boolean sign, string number)
        {
            this.Sign = sign;
            this.Number = number;
        }

        public Boolean Sign 
        { get; set; }

        public string Number 
        { get; set; }

        public override string ToString()
        {
            if(this.Sign == true)
            {
                return $"-{Number}";
            }
            return $"{Number}";
            
        }
    }
}
