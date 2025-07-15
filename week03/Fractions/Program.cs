using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Enhanced Fractions Project!\n");

        Fraction f1 = new Fraction();
        Console.WriteLine($"Default: {f1.GetFractionString()} = {f1.ToDecimal():0.###}");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Whole number: {f2.GetFractionString()} = {f2.ToDecimal():0.###}");

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {f3.GetFractionString()} = {f3.ToDecimal():0.###}");

        Fraction f4 = new Fraction(6, 8);
        Console.WriteLine($"Before Reduction: {f4.GetFractionString()} = {f4.ToDecimal():0.###}");
        f4.Simplify();
        Console.WriteLine($"After Reduction: {f4.GetFractionString()}\n");

        Fraction sum = f3.Add(f4);
        Console.WriteLine($"{f3.GetFractionString()} + {f4.GetFractionString()} = {sum.GetFractionString()} = {sum.ToDecimal():0.###}");

        Fraction diff = f3.Subtract(f4);
        Console.WriteLine($"{f3.GetFractionString()} - {f4.GetFractionString()} = {diff.GetFractionString()} = {diff.ToDecimal():0.###}");

        Fraction product = f3.Multiply(f4);
        Console.WriteLine($"{f3.GetFractionString()} * {f4.GetFractionString()} = {product.GetFractionString()} = {product.ToDecimal():0.###}");

        Fraction quotient = f3.Divide(f4);
        Console.WriteLine($"{f3.GetFractionString()} / {f4.GetFractionString()} = {quotient.GetFractionString()} = {quotient.ToDecimal():0.###}");

        Console.WriteLine("\nThank you for using the Fractions Project!");
    }
}
