//using System;
//using System.Globalization;
//using Humanizer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class DateHumanizeExtensionsTests {
//        [TestMethod]
//        public void Humanize_WithNullInput_ReturnsNever() {
//            // Arrange
//            DateTime? input = null;
//            var expected = "never"; // Replace with actual expected value for "never"

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_WithValidInput_ProvidesRelativeTimeDescription() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-5);

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("hours ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithFutureDate_HandlesCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddDays(3);

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("in 3 days"));
//        }

//        [TestMethod]
//        public void Humanize_WithSpecifiedComparisonDate_UsesComparisonDate() {
//            // Arrange
//            DateTime input = new DateTime(2023, 1, 1);
//            DateTime comparisonDate = new DateTime(2023, 1, 5);

//            // Act
//            var result = input.Humanize(dateToCompareAgainst: comparisonDate);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("4 days ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithUtcOption_AdjustsForTimeZoneCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-10);

//            // Act
//            var result = input.Humanize(utcDate: true);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("10 hours ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithSpecificCulture_ReturnsLocalizedResult() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-1);
//            CultureInfo culture = new CultureInfo("fr-FR");

//            // Act
//            var result = input.Humanize(culture: culture);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("il y a 1 heure"));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(CultureNotFoundException))]
//        public void Humanize_WithInvalidCulture_ThrowsException() {
//            // Arrange
//            DateTime input = DateTime.UtcNow;

//            // Act
//            input.Humanize(culture: new CultureInfo("invalid-culture-code"));

//            // Assert - Exception is expected.
//        }
//    }
//}
