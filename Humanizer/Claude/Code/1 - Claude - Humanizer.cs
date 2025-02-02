//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class DateHumanizeExtensionsTests {
//        private static readonly DateTime Now = DateTime.Now;
//        private static readonly DateTime UtcNow = DateTime.UtcNow;
//        private static readonly CultureInfo EnglishCulture = new CultureInfo("en-US");

//        [TestInitialize]
//        public void Setup() {
//            // Reset any global configurations before each test
//            Configurator.DateTimeHumanizeStrategy = null;
//        }

//        [TestMethod]
//        public void Humanize_NullDateTime_ReturnsNever() {
//            // Arrange
//            DateTime? nullDateTime = null;

//            // Act
//            string result = nullDateTime.Humanize();

//            // Assert
//            Assert.AreEqual("never", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_CurrentDateTime_ReturnsNow() {
//            // Arrange
//            DateTime current = Now;

//            // Act
//            string result = current.Humanize(dateToCompareAgainst: current);

//            // Assert
//            Assert.AreEqual("now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneMinuteAgo_ReturnsOneMinuteAgo() {
//            // Arrange
//            DateTime input = Now.AddMinutes(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("1 minute ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneHourFromNow_ReturnsOneHourFromNow() {
//            // Arrange
//            DateTime input = Now.AddHours(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("1 hour from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayAgo_ReturnsYesterday() {
//            // Arrange
//            DateTime input = Now.AddDays(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("yesterday", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayFromNow_ReturnsTomorrow() {
//            // Arrange
//            DateTime input = Now.AddDays(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("tomorrow", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithCustomCulture_ReturnsLocalizedString() {
//            // Arrange
//            DateTime input = Now.AddDays(-1);
//            CultureInfo spanishCulture = new CultureInfo("es-ES");

//            // Act
//            string result = input.Humanize(culture: spanishCulture);

//            // Assert
//            Assert.AreEqual("ayer", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithUtcDate_UsesUtcComparison() {
//            // Arrange
//            DateTime input = UtcNow.AddHours(-2);

//            // Act
//            string result = input.Humanize(utcDate: true, dateToCompareAgainst: UtcNow);

//            // Assert
//            Assert.AreEqual("2 hours ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneYearAgo_ReturnsOneYearAgo() {
//            // Arrange
//            DateTime input = Now.AddYears(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("1 year ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_FutureDate_ReturnsCorrectPhrase() {
//            // Arrange
//            DateTime input = Now.AddMonths(3);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("3 months from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_ExtremelyFutureDate_HandlesLargeTimeSpan() {
//            // Arrange
//            DateTime input = Now.AddYears(100);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: Now);

//            // Assert
//            Assert.AreEqual("100 years from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithNullComparisonDate_UsesCurrentDateTime() {
//            // Arrange
//            DateTime input = DateTime.Now.AddMinutes(-5);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: null);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Humanize_WithInvalidCulture_ThrowsArgumentException() {
//            // Arrange
//            DateTime input = Now;
//            CultureInfo invalidCulture = null;

//            // Act & Assert
//            input.Humanize(culture: invalidCulture);
//        }
//    }
//}