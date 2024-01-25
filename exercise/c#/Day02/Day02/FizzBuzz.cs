namespace Day02;

public static class FizzBuzz
{
    private const int Min = 0;
    private const int Max = 100;
    private const int Fizz = 3;
    private const string FizzString = "Fizz";
    private const int Buzz = 5;
    private const string BuzzString = "Buzz";
    private const int Fizz_Buzz = 15;
    private const string FizzBuzzString = "FizzBuzz";

    public static string Convert(int input)
        => IsOutOfRange(input)
            ? throw new OutOfRangeException()
            : ConvertInRange(input);

    private static string ConvertInRange(int input)
    {
        if (input.IsDivisibleBy(Fizz_Buzz))
            return FizzBuzzString;
        if (input.IsDivisibleBy(Fizz))
            return FizzString;
        if (input.IsDivisibleBy(Buzz))
            return BuzzString;

        return input.ToString();
    }
    private static bool IsOutOfRange(int input) => input is <= Min or > Max;
}