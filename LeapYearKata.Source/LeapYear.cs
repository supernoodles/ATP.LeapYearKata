namespace LeapYearKata.Source
{
    public sealed class LeapYear
    {
        public bool IsLeapYear(int year) =>
            year.IsDivisibleBy(4) && 
            (!year.IsDivisibleBy(100) || 
              year.IsDivisibleBy(400));
    }

    internal static class YearsExtensions
    {
        internal static bool IsDivisibleBy(this int numerator, int divisor)
        {
            return numerator % divisor == 0;
        }
    }
}