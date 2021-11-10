using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ComplexNumbers
    {
        int a { get; set; }
        int b { get; set; }
        public ComplexNumbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            if (b < 0)
            {
                return $"комплексное число z = {a} - {-b}i";
            }
            return $"комплексное число z = {a} + {b}i";
        }
        public static ComplexNumbers operator +(ComplexNumbers number1, ComplexNumbers number2)
        {
            return new ComplexNumbers((number1.a + number2.a), (number1.b + number2.b));               
        }
        public static ComplexNumbers operator *(ComplexNumbers number1, ComplexNumbers number2)
        {
            return new ComplexNumbers((number1.a * number2.a)-(number1.b*number2.b), (number1.a*number2.b) + (number1.b*number2.a));
        }
        public static ComplexNumbers operator -(ComplexNumbers number1, ComplexNumbers number2)
        {
            return new ComplexNumbers((number1.a - number2.a), (number1.b - number2.b));
        }
        public static bool operator ==(ComplexNumbers number1, ComplexNumbers number2)
        {
            return (number1.a == number2.a && number1.b == number2.b);
        }
        public static bool operator !=(ComplexNumbers number1, ComplexNumbers number2)
        {
            return (number1.a != number2.a || number1.b != number2.b);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, (ComplexNumbers)obj))
            {
                return true;
            }

            if (ReferenceEquals((ComplexNumbers)obj, null))
            {
                return false;
            }
            return a == ((ComplexNumbers)obj).a && b == ((ComplexNumbers)obj).b;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(a, b); 
        }
    }
}
