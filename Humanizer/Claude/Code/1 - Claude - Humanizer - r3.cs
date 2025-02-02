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
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst;

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneMinuteAgo_ReturnsAMinuteAgo() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMinutes(-1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("a minute ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_OneHourFromNow_ReturnsAnHourFromNow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddHours(1);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("an hour from now", result.ToLower());
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
//        public void Humanize_TwoMinutesAgo_ReturnsTwoMinutesAgo() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMinutes(-2);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("2 minutes ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_TwoHoursFromNow_ReturnsTwoHoursFromNow() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddHours(2);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("2 hours from now", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithUtcDate_RespectsTimeZone() {
//            // Arrange
//            var compareAgainst = DateTime.UtcNow;
//            var input = compareAgainst.AddHours(-2);

//            // Act
//            string result = input.Humanize(utcDate: true, dateToCompareAgainst: compareAgainst);

//            // Assert
//            Assert.AreEqual("2 hours ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithSpanishCulture_UsesSpanishLocalization() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddDays(-1);
//            var spanishCulture = new CultureInfo("es-ES");

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: spanishCulture);

//            // Assert
//            Assert.AreEqual("ayer", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithNullCulture_UsesDefaultCulture() {
//            // Arrange
//            var compareAgainst = DateTime.Now;
//            var input = compareAgainst.AddMinutes(-2);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: compareAgainst, culture: null);

//            // Assert
//            Assert.AreEqual("2 minutes ago", result.ToLower());
//        }

//        [TestMethod]
//        public void Humanize_WithNullCompareDate_UsesCurrentTime() {
//            // Arrange
//            var input = DateTime.Now.AddMinutes(-5);

//            // Act
//            string result = input.Humanize(dateToCompareAgainst: null);

//            // Assert
//            Assert.IsTrue(result.ToLower().Contains("minutes ago"));
//        }
//    }
//}