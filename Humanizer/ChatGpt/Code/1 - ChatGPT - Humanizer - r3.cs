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
//            string expected = "never";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result, "The Humanize method did not return 'never' for a null input.");
//        }

//        [TestMethod]
//        public void Humanize_WithValidInput_ProvidesRelativeTimeDescription() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-5);

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result, "The Humanize method returned a null result.");
//            Assert.IsTrue(result.Contains("5 hours ago"), $"The Humanize method did not return the expected description. Actual: {result}");
//        }

//        [TestMethod]
//        public void Humanize_WithFutureDate_HandlesCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddDays(3);

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result, "The Humanize method returned a null result.");
//            Assert.IsTrue(result.Contains("3 days from now"), $"The Humanize method did not return the expected future description. Actual: {result}");
//        }

//        [TestMethod]
//        public void Humanize_WithSpecifiedComparisonDate_UsesComparisonDate() {
//            // Arrange
//            DateTime input = new DateTime(2023, 1, 1);
//            DateTime comparisonDate = new DateTime(2023, 1, 5);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: comparisonDate);

//            // Assert
//            Assert.IsNotNull(result, "The Humanize method returned a null result.");
//            Assert.IsTrue(result.Contains("4 days ago"), $"The Humanize method did not use the specified comparison date correctly. Actual: {result}");
//        }

//        [TestMethod]
//        public void Humanize_WithUtcOption_AdjustsForTimeZoneCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-10);

//            // Act
//            string result = input.Humanize(utcDate: true);

//            // Assert
//            Assert.IsNotNull(result, "The Humanize method returned a null result.");
//            Assert.IsTrue(result.Contains("10 hours ago"), $"The Humanize method did not adjust for UTC timezone correctly. Actual: {result}");
//        }

//        [TestMethod]
//        public void Humanize_WithSpecificCulture_ReturnsLocalizedResult() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-1);
//            CultureInfo culture = new CultureInfo("fr-FR");

//            // Act
//            string result = input.Humanize(culture: culture);

//            // Assert
//            Assert.IsNotNull(result, "The Humanize method returned a null result.");
//            Assert.IsTrue(result.Contains("il y a une heure"), $"The Humanize method did not return the expected localized result. Actual: {result}");
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
