namespace Day02;

public static class DivisibleByExtension
{
    public static bool IsDivisibleBy(this int input, int divisor)
    {
        return input % divisor == 0;
    }
}
