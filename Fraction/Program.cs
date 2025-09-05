using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConstructors();
            TestArithmeticOperations();
            TestComparisonOperators();
            TestConversions();
            TestSpecialMethods();
            TestParseMethod();
        }
        static void TestConstructors()
        {
            Fraction f1 = new Fraction(1, 2);
            Console.WriteLine($"Fraction(1, 2) = {f1}");

            Fraction f2 = new Fraction(3, 4, 2);
            Console.WriteLine($"Fraction(3, 4, 2) = {f2}");

            Fraction f3 = new Fraction(f2);
            Console.WriteLine($"Copy of {f2} = {f3}");
        }

        static void TestArithmeticOperations()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);

            Fraction sum = f1 + f2;
            Console.WriteLine($"{f1} + {f2} = {sum}");

            Fraction diff = f1 - f2;
            Console.WriteLine($"{f1} - {f2} = {diff}");

            Fraction product = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {product}");

            Fraction quotient = f1 / f2;
            Console.WriteLine($"{f1} / {f2} = {quotient}");

            Fraction negative = -f1;
            Console.WriteLine($"-{f1} = {negative}");
        }

        static void TestComparisonOperators()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);
            Fraction f3 = new Fraction(1, 2);

            Console.WriteLine($"{f1} == {f3}: {f1 == f3}");
            Console.WriteLine($"{f1} != {f2}: {f1 != f2}");
            Console.WriteLine($"{f1} > {f2}: {f1 > f2}");
            Console.WriteLine($"{f2} < {f1}: {f2 < f1}");
            Console.WriteLine($"{f1} >= {f3}: {f1 >= f3}");
            Console.WriteLine($"{f2} <= {f1}: {f2 <= f1}");
        }

        static void TestConversions()
        {
            Fraction f1 = new Fraction(3, 2);
            Fraction f2 = new Fraction(5, 4, 1);

            Console.WriteLine($"{f1}.ToDouble() = {f1.ToDouble():F3}");
            Console.WriteLine($"{f2}.ToDouble() = {f2.ToDouble():F3}");

            Fraction improper = f2.ToImproper();
            Console.WriteLine($"{f2}.ToImproper() = {improper}");

            Fraction proper = improper.ToProper();
            Console.WriteLine($"{improper}.ToProper() = {proper}");
        }

        static void TestSpecialMethods()
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction inverted = f1.Inverted();

            Console.WriteLine($"{f1}.Inverted() = {inverted}");
            Console.WriteLine($"{f1} * {inverted} = {f1 * inverted}");

            Fraction f2 = new Fraction(2, 3, 1);
            Fraction invertedMixed = f2.Inverted();
            Console.WriteLine($"{f2}.Inverted() = {invertedMixed}");
        }
        static void TestParseMethod()
        {
            Fraction f1 = Fraction.Parse("1/2");
            Console.WriteLine($"Parse(\"1/2\") = {f1}");

            Fraction f2 = Fraction.Parse("2(3/4)");
            Console.WriteLine($"Parse(\"2(3/4)\") = {f2}");

            Fraction f3 = Fraction.Parse("0(1/2)");
            Console.WriteLine($"Parse(\"0(1/2)\") = {f3}");
        }
    }
}


