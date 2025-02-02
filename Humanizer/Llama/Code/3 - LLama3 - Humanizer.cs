//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Humanizer;
//using Humanizer.Tests;
//#using Humanizer.Pluralization;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class ToQuantityExtensionsTests {
//        [TestMethod]
//        public void ToQuantity_WhenQuantityIsOne_ReturnsSingularizedInput() {
//            // Arrange
//            var input = "cats";
//            var quantity = 1L;

//            // Act
//            var result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("cat", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenQuantityIsNotOne_ReturnsPluralizedInput() {
//            // Arrange
//            var input = "cat";
//            var quantity = 2L;

//            // Act
//            var result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("cats", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenShowQuantityAsIsNone_ReturnsInput() {
//            // Arrange
//            var input = "cats";
//            var quantity = 2L;

//            // Act
//            var result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.None);

//            // Assert
//            Assert.AreEqual("cats", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenShowQuantityAsIsNumeric_ReturnsFormattedString() {
//            // Arrange
//            var input = "cat";
//            var quantity = 2L;
//            var format = "N0";

//            // Act
//            var result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.Numeric, format: format);

//            // Assert
//            Assert.AreEqual("2 cats", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenShowQuantityAsIsWords_ReturnsFormattedString() {
//            // Arrange
//            var input = "cat";
//            var quantity = 2L;

//            // Act
//            var result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.Words);

//            // Assert
//            Assert.AreEqual("two cats", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenFormatProviderIsSpecified_ReturnsFormattedString() {
//            // Arrange
//            var input = "cat";
//            var quantity = 2L;
//            var format = "N0";
//            var culture = new CultureInfo("en-US");

//            // Act
//            var result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.Numeric, format: format, formatProvider: culture);

//            // Assert
//            Assert.AreEqual("2 cats", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WhenInvalidInputIsPassed_ThrowsArgumentException() {
//            // Arrange
//            var input = null;
//            var quantity = 2L;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => input.ToQuantity(quantity));
//        }
//    }
//}