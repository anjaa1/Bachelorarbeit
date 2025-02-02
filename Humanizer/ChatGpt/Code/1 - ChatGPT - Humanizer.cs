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
//            var expected = Configurator.GetFormatter(CultureInfo.CurrentCulture).DateHumanize_Never();

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_WithValidInput_ProvidesRelativeTimeDescription() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-5);
//            var expected = "5 hours ago"; // Adjust this based on your formatter's output.

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains("hours ago")); // General validation due to localization differences.
//        }

//        [TestMethod]
//        public void Humanize_WithFutureDate_HandlesCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddDays(3);
//            var expectedSubstring = "in 3 days"; // Adjust based on formatter.

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains(expectedSubstring));
//        }

//        [TestMethod]
//        public void Humanize_WithSpecifiedComparisonDate_UsesComparisonDate() {
//            // Arrange
//            DateTime input = new DateTime(2023, 1, 1);
//            DateTime comparisonDate = new DateTime(2023, 1, 5);
//            var expectedSubstring = "4 days ago"; // Adjust based on formatter.

//            // Act
//            var result = input.Humanize(dateToCompareAgainst: comparisonDate);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains(expectedSubstring));
//        }

//        [TestMethod]
//        public void Humanize_WithUtcOption_AdjustsForTimeZoneCorrectly() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-10);
//            var expectedSubstring = "10 hours ago"; // Adjust based on formatter.

//            // Act
//            var result = input.Humanize(utcDate: true);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains(expectedSubstring));
//        }

//        [TestMethod]
//        public void Humanize_WithSpecificCulture_ReturnsLocalizedResult() {
//            // Arrange
//            DateTime input = DateTime.UtcNow.AddHours(-1);
//            CultureInfo culture = new CultureInfo("fr-FR");
//            var expectedSubstring = "il y a 1 heure"; // Adjust based on formatter.

//            // Act
//            var result = input.Humanize(culture: culture);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Contains(expectedSubstring));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Humanize_WithInvalidCulture_ThrowsException() {
//            // Arrange
//            DateTime input = DateTime.UtcNow;
//            CultureInfo invalidCulture = new CultureInfo("invalid-culture-code");

//            // Act
//            input.Humanize(culture: invalidCulture);

//            // Assert - Exception is expected.
//        }
//    }
//}
