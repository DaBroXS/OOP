namespace lr2;

public sealed class Fraction : IEquatable<Fraction>
{
	public int Numerator { get; private set; }
	public int Denominator { get; private set; }

	public Fraction(int numerator, int denominator)
	{
		Numerator = numerator;
		Denominator = denominator;
	}

	~Fraction()
	{
		Numerator = 0;
		Denominator = 0;
	}

	public Fraction Add(Fraction other)
	{
		int numerator = Numerator * other.Denominator + other.Numerator * Denominator;
		int denominator = Denominator * other.Denominator;
		return Simplify(new Fraction(numerator, denominator));
	}

	public Fraction Subtract(Fraction other)
	{
		int numerator = Numerator * other.Denominator - other.Numerator * Denominator;
		int denominator = Denominator * other.Denominator;
		return Simplify(new Fraction(numerator, denominator));
	}

	public Fraction Multiply(Fraction other)
	{
		int numerator = Numerator * other.Numerator;
		int denominator = Denominator * other.Denominator;
		return Simplify(new Fraction(numerator, denominator));
	}

	public Fraction Divide(Fraction other)
	{
		int numerator = Numerator * other.Denominator;
		int denominator = Denominator * other.Numerator;
		return Simplify(new Fraction(numerator, denominator));
	}

	public Fraction Simplify(Fraction fraction)
	{
		int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator);
		fraction.Numerator /= gcd;
		fraction.Denominator /= gcd;
		return fraction;
	}

	public Fraction Simplify() => Simplify(this);

	private int GreatestCommonDivisor(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

	public override string ToString()
	{
		return $"{Numerator}/{Denominator}";
	}

	public double ToDouble()
	{
		return Numerator / Denominator;
	}

	public bool Equals(Fraction? other)
	{
		if (other is null)
			return false;

		var left = Simplify();
		var right = other.Simplify();
		return left.Numerator.Equals(right.Numerator) && left.Denominator.Equals(right.Denominator);
	}

	public override bool Equals(object? obj) => Equals(obj as Fraction);

	public override int GetHashCode() => Numerator.GetHashCode() ^ Denominator.GetHashCode();

	public static Fraction operator +(Fraction left, Fraction right) => left.Add(right);
	public static Fraction operator -(Fraction left, Fraction right) => left.Subtract(right);
	public static Fraction operator /(Fraction left, Fraction right) => left.Divide(right);
	public static Fraction operator *(Fraction left, Fraction right) => left.Multiply(right);
	public static bool operator ==(Fraction left, Fraction right) => left.Equals(right);
	public static bool operator !=(Fraction left, Fraction right) => left.Equals(right) is false;
	public static bool operator >(Fraction left, Fraction right) => left.ToDouble() > right.ToDouble();
	public static bool operator <(Fraction left, Fraction right) => left.ToDouble() < right.ToDouble();
	public static bool operator >=(Fraction left, Fraction right) => left.ToDouble() >= right.ToDouble();
	public static bool operator <=(Fraction left, Fraction right) => left.ToDouble() <= right.ToDouble();
}
