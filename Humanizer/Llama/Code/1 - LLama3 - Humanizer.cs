//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Humanizer;

//namespace HumanizerTests
//{
//    [TestClass]
//    public class DateHumanizeExtensionsTests
//    {
//        [TestMethod]
//        public void Humanize_ValidDate_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_ValidDate_ReturnsHumanizedStringWithCulture()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);
//            var culture = new CultureInfo("en-GB");

//            // Act
//            var result = date.Humanize(culture: culture);

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_NullDate_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = (DateTime?)null;

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("never", result);
//        }

//        [TestMethod]
//        public void Humanize_NullDate_ReturnsHumanizedStringWithCulture()
//        {
//            // Arrange
//            var date = (DateTime?)null;
//            var culture = new CultureInfo("en-GB");

//            // Act
//            var result = date.Humanize(culture: culture);

//            // Assert
//            Assert.AreEqual("never", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInPast_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2020, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("2 years ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInFuture_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2024, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("2 years from now", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInSameYear_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInSameMonth_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInSameWeek_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateInSameDay_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateWithTimeComponent_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1, 12, 0, 0);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateWithoutTimeComponent_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateWithTimeZone_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1, 12, 0, 0, DateTimeKind.Utc);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }

//        [TestMethod]
//        public void Humanize_DateWithoutTimeZone_ReturnsHumanizedString()
//        {
//            // Arrange
//            var date = new DateTime(2022, 1, 1, 12, 0, 0);

//            // Act
//            var result = date.Humanize();

//            // Assert
//            Assert.AreEqual("1 year ago", result);
//        }
//    }
//}