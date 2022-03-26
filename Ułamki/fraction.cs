using System;
using System.Collections.Generic;
using System.Text;

namespace Ułamki
{
    class Fraction
    {
        public readonly int num;
        public readonly int den;
        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator can`t be 0");
            }

            this.num = num;
            this.den = den;
        }
        public override string ToString()
        {
            return $"{num}/{den}";
        }
        public Fraction add(Fraction secondFraction)
        {
            return new Fraction(num * secondFraction.den + secondFraction.num * den, den * secondFraction.den);
        }

        public static Fraction operator -(Fraction fr1)
        {
            return new Fraction(fr1.num, fr1.den);
        }
        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.num * fr2.den + fr2.num * fr2.den, fr1.den * fr2.den);
        }

    }
    
}


