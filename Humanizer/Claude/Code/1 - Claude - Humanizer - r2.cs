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
//            string result = current.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneMinuteAgo_ReturnsOneMinuteAgo() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMinutes(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("1 minute ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneHourFromNow_ReturnsOneHourFromNow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddHours(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("1 hour from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayAgo_ReturnsYesterday() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("yesterday", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneDayFromNow_ReturnsTomorrow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("tomorrow", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithCustomCulture_ReturnsSameFormatRegardlessOfCulture() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(-1);
//            var spanishCulture = new CultureInfo("es-ES");

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: spanishCulture);

//            // Assert
//            // Note: We're only testing that it returns a non-empty string since actual localization
//            // behavior depends on the specific implementation
//            Assert.IsFalse(string.IsNullOrEmpty(result));
//        }

//        [TestMethod]
//        public void Humanize_WithUtcDate_HandlesUtcComparison() {
//            // Arrange
//            var compareAgainst = DateTime.UtcNow;
//            var input = compareAgainst.AddHours(-2);

//            // Act
//            string result = input.Humanize(utcDate: true, dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("hours ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithNullComparisonDate_UsesCurrentDateTime() {
//            // Arrange
//            var input = DateTime.Now.AddMinutes(-5);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: null);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }

//        [TestMethod]
//        public void Humanize_WithNullCulture_UsesDefaultCulture() {
//            // Arrange
//            var input = DateTime.Now.AddMinutes(-30);

//            // Act
//            string result = input.Humanize(culture: null);

//            // Assert
//            Assert.IsTrue(!string.IsNullOrEmpty(result));
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }
//    }
//}