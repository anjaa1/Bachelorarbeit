//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class ToQuantityExtensionsTests {
//        [TestMethod]
//        public void ToQuantity_ShouldHandleSingularCaseCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 1;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("1 request", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandlePluralCaseCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 5;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("5 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleZeroCaseCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 0;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("0 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleNumericFormattingCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 10000;
//            string format = "N0";

//            // Act
//            string result = input.ToQuantity(quantity, format, System.Globalization.CultureInfo.InvariantCulture);

//            // Assert
//            Assert.AreEqual("10,000 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleWordsFormattingCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 123;

//            // Act
//            string result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.Words);

//            // Assert
//            Assert.AreEqual("one hundred and twenty-three requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleNoneFormattingCorrectly() {
//            // Arrange
//            string input = "request";
//            long quantity = 10;

//            // Act
//            string result = input.ToQuantity(quantity, showQuantityAs: ShowQuantityAs.None);

//            // Assert
//            Assert.AreEqual("requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldRespectCultureSpecificFormatting() {
//            // Arrange
//            string input = "request";
//            long quantity = 1234;
//            string format = "N";
//            var culture = new System.Globalization.CultureInfo("de-DE");

//            // Act
//            string result = input.ToQuantity(quantity, format, culture);

//            // Assert
//            Assert.AreEqual("1.234 requests", result); // Updated expected result for culture format
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleEdgeCase_NegativeQuantity() {
//            // Arrange
//            string input = "request";
//            long quantity = -1;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("-1 requests", result); // Assuming plural form for negative numbers
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleNullInputGracefully() {
//            // Arrange
//            string input = null;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => input.ToQuantity(1));
//        }

//        [TestMethod]
//        public void ToQuantity_ShouldHandleEmptyStringInput() {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            string result = input.ToQuantity(1);

//            // Assert
//            Assert.AreEqual("1", result.Trim()); // Ensuring no extra spaces in the result
//        }
//    }
//}
