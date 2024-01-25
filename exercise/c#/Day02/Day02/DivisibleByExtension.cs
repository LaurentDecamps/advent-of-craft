namespace Day02;

public static class DivisibleByExtension
{
    public static bool IsDivisibleBy(this int input, int divisor)
        => input % divisor == 0;
}
