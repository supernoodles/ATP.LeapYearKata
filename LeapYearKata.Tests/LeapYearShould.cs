namespace LeapYearKata.Tests
{
    using NUnit.Framework;
    using Source;

    [TestFixture]
    public class LeapYearShould
    {
        [TestCase(1600, ExpectedResult = true)]
        [TestCase(1992, ExpectedResult = true)]
        [TestCase(1988, ExpectedResult = true)]
        [TestCase(2000, ExpectedResult = true)]
        [TestCase(1200, ExpectedResult = true)]
        [TestCase(1600, ExpectedResult = true)]
        [TestCase(2001, ExpectedResult = false)]
        [TestCase(2003, ExpectedResult = false)]
        [TestCase(1900, ExpectedResult = false)]
        [TestCase(1700, ExpectedResult = false)]
        public bool ReturnCorrectAnswer_GivenYear(int year) =>
            new LeapYear()
                .IsLeapYear(year);
    }
}
