using ExtremeCalculator;
using ExtremeCalculatorUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeCalculatorDataType
{
    public struct Fraction
    {
        public Fraction(Boolean sign, StringNumber numerator, StringNumber denominator)
        {
            this.Sign = sign ^ numerator.Sign ^ denominator.Sign;
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public Boolean Sign
        { get; set; }

        public StringNumber Numerator
        { get; set; }

        public StringNumber Denominator
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

        public static StringNumber operator +(StringNumber strnum) => strnum;
        public static StringNumber operator +(StringNumber strnum1, StringNumber strnum2)
        {
            StringNumber result = SpecialOperations.Additions(strnum1, strnum2);

            return result;
        }

        public static StringNumber operator -(StringNumber strnum)
        {
            strnum.Sign ^= true;

            return strnum;
        }

        public static StringNumber operator -(StringNumber strnum1, StringNumber strnum2)
        {
            strnum2.Sign ^= true;
            StringNumber result = SpecialOperations.Additions(strnum1, strnum2);

            return result;
        }

        public static Boolean operator ==(StringNumber strnum1, StringNumber strnum2)
        {
            Boolean isEqual = Utils.DoesTwoStringNumbersAreEqual(strnum1, strnum2);
            return isEqual;
        }

        public static Boolean operator !=(StringNumber strnum1, StringNumber strnum2)
        {
            Boolean isEqual = Utils.DoesTwoStringNumbersAreEqual(strnum1, strnum2);
            return !isEqual;
        }
        
        public override Boolean Equals(Object? obj)
        {
            if(obj != null && this.GetType() == obj.GetType())
            {
                return this == (StringNumber) obj;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

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
