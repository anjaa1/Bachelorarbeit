//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Humanizer;
//using Humanizer.Localisation;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class DateHumanizeExtensionsTests {
//        private static readonly DateTime Now = DateTime.Now;
//        private static readonly DateTime UtcNow = DateTime.UtcNow;
//        private static readonly CultureInfo EnglishCulture = new CultureInfo("en-US");
//        private IFormatter _formatter;

//        [TestInitialize]
//        public void Setup() {
//            // Initialize default formatter
//            _formatter = Configurator.GetFormatter(EnglishCulture);

//            // Ensure we have a default date humanize strategy
//            if (Configurator.DateTimeHumanizeStrategy == null) {
//                Configurator.DateTimeHumanizeStrategy = new DefaultDateTimeHumanizeStrategy();
//            }
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
//            var current = DateTime.Now;
//            var compareAgainst = current;

//            // Act
//            string result = current.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneMinuteAgo_ReturnsOneMinuteAgo() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMinutes(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("1 minute ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneHourFromNow_ReturnsOneHourFromNow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddHours(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("1 hour from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayAgo_ReturnsYesterday() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("yesterday", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayFromNow_ReturnsTomorrow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("tomorrow", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithCustomCulture_ReturnsLocalizedString() {
//            // Arrange
//            var spanishCulture = new CultureInfo("es-ES");
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: spanishCulture);

//            // Assert
//            Assert.AreEqual("ayer", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithUtcDate_UsesUtcComparison() {
//            // Arrange
//            var compareAgainst = DateTime.UtcNow;
//            var input = compareAgainst.AddHours(-2);

//            // Act
//            string result = input.Humanize(utcDate: true, dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("2 hours ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneYearAgo_ReturnsOneYearAgo() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddYears(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("1 year ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_FutureDate_ReturnsCorrectPhrase() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMonths(3);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: EnglishCulture);

//            // Assert
//            Assert.AreEqual("3 months from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithNullComparisonDate_UsesCurrentDateTime() {
//            // Arrange
//            var input = DateTime.Now.AddMinutes(-5);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: null, culture: EnglishCulture);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithDefaultValues_ReturnsValidString() {
//            // Arrange
//            var input = DateTime.Now.AddMinutes(-30);

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.IsTrue(!string.IsNullOrEmpty(result));
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithInvalidCulture_UsesDefaultCulture() {
//            // Arrange
//            var input = DateTime.Now.AddHours(-1);
//            CultureInfo invalidCulture = null;

//            // Act
//            string result = input.Humanize(culture: invalidCulture);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("hour ago"));
//        }
//    }
//}