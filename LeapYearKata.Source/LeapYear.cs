namespace LeapYearKata.Source
{

    public class LeapYear
    {
        public bool IsLeapYear(int year) =>
            year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}