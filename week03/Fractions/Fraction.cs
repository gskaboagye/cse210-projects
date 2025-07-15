
// Fraction.cs
public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        _numerator = numerator;
        _denominator = denominator;
        Simplify();
    }

    public string GetFractionString() => $"{_numerator}/{_denominator}";

    public double ToDecimal() => (double)_numerator / _denominator;

    public void SetNumerator(int numerator) => _numerator = numerator;

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        _denominator = denominator;
        Simplify();
    }

    public int GetNumerator() => _numerator;
    public int GetDenominator() => _denominator;

    public void Simplify()
    {
        int gcd = GCD(Math.Abs(_numerator), Math.Abs(_denominator));
        _numerator /= gcd;
        _denominator /= gcd;

        // Keep negative sign on numerator
        if (_denominator < 0)
        {
            _numerator *= -1;
            _denominator *= -1;
        }
    }

    private int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    public Fraction Add(Fraction other)
    {
        int num = _numerator * other._denominator + other._numerator * _denominator;
        int denom = _denominator * other._denominator;
        return new Fraction(num, denom);
    }

    public Fraction Subtract(Fraction other)
    {
        int num = _numerator * other._denominator - other._numerator * _denominator;
        int denom = _denominator * other._denominator;
        return new Fraction(num, denom);
    }

    public Fraction Multiply(Fraction other)
    {
        return new Fraction(_numerator * other._numerator, _denominator * other._denominator);
    }

    public Fraction Divide(Fraction other)
    {
        if (other._numerator == 0)
            throw new DivideByZeroException("Cannot divide by a fraction with zero numerator.");

        return new Fraction(_numerator * other._denominator, _denominator * other._numerator);
    }
}

