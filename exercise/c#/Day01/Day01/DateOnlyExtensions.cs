namespace Day01;

internal static class DateOnlyExtensions
{
    public static bool IsGreaterThan(this DateOnly thisDate, DateOnly otherDate) => thisDate.CompareTo(otherDate) > 0;
}