using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers number1 = new RationalNumbers(2, 4);
            RationalNumbers number2 = new RationalNumbers(3, 7);
            Console.WriteLine($"{number1} {number2}");
            RationalNumbers number3 = number2;
            Console.WriteLine(number2 == number1);                
            Console.WriteLine(number3 == number2);                
            Console.WriteLine(number2.Equals(number1));           
            Console.WriteLine(number3.Equals(number2));
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number3 >= number2);
            Console.WriteLine(number2 <= number1);
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1++);
            Console.WriteLine(number2--);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(number1 % number2);
            ComplexNumbers number4 = new ComplexNumbers(5, 6);
            ComplexNumbers number5 = new ComplexNumbers(-4, -3);
            Console.WriteLine($"{number4}, {number5}");
            Console.WriteLine(number4 + number5);
            Console.WriteLine(number4 * number5);
            Console.WriteLine(number4 - number5);
            Console.WriteLine(number4 == number5);
            Console.WriteLine(number4 != number5);
        }//1
    }
}
