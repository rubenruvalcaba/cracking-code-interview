using System;

public class Siva
{
    public static void Run()
    {

        Console.WriteLine($" 3 to Roman: {GetRomanNumber(3)}");
        Console.WriteLine($" 12 to Roman: {GetRomanNumber(12)}");
        Console.WriteLine($" 45 to Roman: {GetRomanNumber(45)}");
        Console.WriteLine($" 50 to Roman: {GetRomanNumber(50)}");
    }

    private static string GetRomanNumber(int decimalNumber)
    {
        if (decimalNumber == 0)
            return string.Empty;

        if (decimalNumber < 0)
            throw new ArgumentOutOfRangeException("Decimal must be positive number");

        if (decimalNumber > 50)
            throw new ArgumentOutOfRangeException("Decimal must be less than 50");

        var sb = new System.Text.StringBuilder();
        string[] romanUnits = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] romanTens = new string[] { " ", "X", "XX", "XXX", "XL", "L" };

        if (decimalNumber > 9)
        {
            int tens = decimalNumber / 10;
            int units = decimalNumber % 10;
            sb.Append(romanTens[tens]);
            decimalNumber = units;
        }

        if (decimalNumber > 0)
            sb.Append(romanUnits[decimalNumber - 1]);

        return sb.ToString();

    }
}