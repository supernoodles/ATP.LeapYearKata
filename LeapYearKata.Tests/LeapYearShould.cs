namespace LeapYearKata.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using Source;

    [TestFixture]
    public class LeapYearShould
    {
        [Test]
        public void ReturnTrue_Given1996()
        {
            new LeapYear()
                .IsLeapYear(1996)
                .Should().BeTrue();
        }

        [Test]
        public void ReturnFalse_Given2001()
        {
            new LeapYear()
                .IsLeapYear(2001)
                .Should().BeFalse();
        }

        [Test]
        public void ReturnTrue_Given1992()
        {
            var leapYear = new LeapYear();

            var result = leapYear.IsLeapYear(1992);

            result.Should().BeTrue();
        }
    }
}
