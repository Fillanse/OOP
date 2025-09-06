using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public int Whole { get; set; }

        public Fraction(int numerator, int denominator, int whole) { Numerator = numerator; Denominator = denominator; Whole = whole; }
        public Fraction(int numerator, int denominator) { Numerator = numerator; Denominator = denominator; }
        public Fraction(Fraction other) { Numerator = other.Numerator; Denominator = other.Denominator; Whole = other.Whole; }

        public static Fraction operator -(Fraction operand) => new Fraction(-operand.Numerator, operand.Denominator);
        public static Fraction operator +(Fraction left, Fraction right) => new Fraction(left.Numerator * right.Denominator + right.Numerator * left.Denominator, left.Denominator * right.Denominator);
        public static Fraction operator -(Fraction left, Fraction right) => left + (-right);
        public static Fraction operator *(Fraction left, Fraction right) => new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
        public static Fraction operator /(Fraction left, Fraction right) => new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator);

        public static bool operator ==(Fraction left, Fraction right) => left.ToDouble() == right.ToDouble();
        public static bool operator !=(Fraction left, Fraction right) => !(left == right);
        public static bool operator <(Fraction left, Fraction right) => left.ToDouble() < right.ToDouble();
        public static bool operator >(Fraction left, Fraction right) => right < left;
        public static bool operator <=(Fraction left, Fraction right) => left < right || left == right;
        public static bool operator >=(Fraction left, Fraction right) => left > right || left == right;

        public double ToDouble() => (double)Numerator / Denominator + Whole;
        public Fraction ToImproper() => new Fraction(Numerator + Denominator * Whole, Denominator);
        public Fraction ToProper() => new Fraction(Numerator % Denominator, Denominator, Whole + Numerator / Denominator);
        public Fraction Inverted()
        {
            Fraction inverted = this.ToImproper();
            return new Fraction(inverted.Denominator, inverted.Numerator);
        }

        public override string ToString() => Whole == 0 ? $"{Numerator}/{Denominator}" : $"{Whole}({Numerator}/{Denominator})";
        public static Fraction Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException("Input can't be empty");

            input = input.Trim();

            if (input.Contains('/') && !input.Contains('(') && !input.Contains(')'))
            {
                string[] parts = input.Split('/');
                if (parts.Length == 2)
                {
                    int numerator = int.Parse(parts[0]);
                    int denominator = int.Parse(parts[1]);
                    return new Fraction(numerator, denominator);
                }
            }

            if (input.Contains('(') && input.Contains(')') && input.Contains('/'))
            {
                int openBracket = input.IndexOf('(');
                int closeBracket = input.IndexOf(')');
                int slash = input.IndexOf('/');

                if (openBracket < slash && slash < closeBracket)
                {
                    int whole = int.Parse(input.Substring(0, openBracket));
                    int numerator = int.Parse(input.Substring(openBracket + 1, slash - openBracket - 1));
                    int denominator = int.Parse(input.Substring(slash + 1, closeBracket - slash - 1));

                    return new Fraction(numerator, denominator, whole);
                }
            }

            throw new FormatException($"Invalid format: {input}");
        }


    }

}

