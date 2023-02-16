using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction emptyFraction = new Fraction();
        Console.Write($"{emptyFraction.GetFractionString()}\n");
        Console.Write($"{emptyFraction.GetDecimalValue()}\n");
        Fraction oneFraction = new Fraction(6);
        Console.Write($"{oneFraction.GetFractionString()}\n");
        Console.Write($"{oneFraction.GetDecimalValue()}\n");
        Fraction twoFraction = new Fraction(6,7);
        Console.Write($"{twoFraction.GetFractionString()}\n");
        Console.Write($"{twoFraction.GetDecimalValue()}\n");
        Fraction twoFraction2 = new Fraction(7,12);
        Console.Write($"{twoFraction2.GetFractionString()}\n");
        Console.Write($"{twoFraction2.GetDecimalValue()}\n");
    }
}