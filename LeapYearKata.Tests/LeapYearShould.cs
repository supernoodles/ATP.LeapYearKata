namespace LeapYearKata.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using Source;

    [TestFixture]
    public class LeapYearShould
    {
        [TestCase(1996)]
        [TestCase(1992)]
        [TestCase(1988)]
        [TestCase(2000)]
        [TestCase(1200)]
        [TestCase(1600)]
        public void ReturnTrue_GivenLeapYear(int year)
        {
            new LeapYear()
                .IsLeapYear(year)
                .Should().BeTrue();
        }

        [TestCase(2001)]
        [TestCase(2003)]
        [TestCase(1900)]
        [TestCase(1700)]
        public void ReturnFalse_GivenCommonYear(int year)
        {
            new LeapYear()
                .IsLeapYear(year)
                .Should().BeFalse();
        }
    }
}
