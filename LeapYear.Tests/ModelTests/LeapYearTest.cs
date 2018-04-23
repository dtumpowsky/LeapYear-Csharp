using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;

namespace LeapYear.Tests
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_NumberDivisibleByFour_True()
        {
              LeapYear testLeapYear = new LeapYear();
              Assert.AreEqual(true, testLeapYear.IsLeapYear(2016));
              //checks if number in parameter follows IsLeapYear method from Model
              // The test passes through its own parameter "IsLeapYear(number)"
        }
    }
}
