using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RationalNumbers
    {
        int numerator { get; set; }
        int denominator { get; set; }
        public override string ToString()
        {
            return $" дробь {numerator} / {denominator}";
        }
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Делить на 0 нельзя");
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static bool operator ==(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator == number2.numerator && number1.denominator == number2.denominator);
        }
        public static bool operator !=(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator != number2.numerator && number1.denominator == number2.denominator);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, (RationalNumbers)obj))
            {
                return true;
            }
            if (ReferenceEquals((RationalNumbers)obj, null))
            {
                return false;
            }
            return numerator == ((RationalNumbers)obj).numerator && denominator == ((RationalNumbers)obj).denominator;
        }
        public static bool operator > (RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator*number2.denominator > number2.numerator*number1.denominator);
        }
        public static bool operator < (RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator*number2.denominator < number2.numerator*number1.denominator);
        }
        public static bool operator >=(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator * number2.denominator >= number2.numerator * number1.denominator);
        }
        public static bool operator <=(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.numerator * number2.denominator <= number2.numerator * number1.denominator);
        }
        public static RationalNumbers operator + (RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.denominator == number2.denominator)
            {
                return new RationalNumbers(number1.numerator + number2.numerator, number1.denominator);
            }
            return new RationalNumbers((number1.numerator*number2.denominator)+(number2.numerator*number1.denominator),
                number1.denominator*number2.denominator);
        }
        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {
            if (number1.denominator == number2.denominator)
            {
                return new RationalNumbers(number1.numerator - number2.numerator, number1.denominator);
            }
            return new RationalNumbers((number1.numerator * number2.denominator) - (number2.numerator * number1.denominator),
                number1.denominator * number2.denominator);
        }
        public static RationalNumbers operator ++(RationalNumbers number)
        {
            number.numerator++;
            number.denominator++;
            return number;
        }
        public static RationalNumbers operator --(RationalNumbers number)
        {
            number.numerator--;
            number.denominator--;
            return number;
        }      
        public static implicit operator float(RationalNumbers number)
        {
           return (float)number.numerator / number.denominator;
        }
        public static explicit operator int (RationalNumbers number)
        {
            return (number.numerator / number.denominator);
        }
        public static RationalNumbers operator *(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.numerator * number2.numerator, number1.denominator * number2.denominator);
        }
        public static RationalNumbers operator /(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.numerator * number2.denominator, number1.denominator * number2.numerator);
        }
        public static RationalNumbers operator %(RationalNumbers number1, RationalNumbers number2)
        {

            return new RationalNumbers((number1.numerator * number2.denominator) % (number1.denominator * number2.numerator), 1);
        }
    }
}