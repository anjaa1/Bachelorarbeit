//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Globalization;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class ToQuantityExtensionsTests {
//        [TestMethod]
//        public void ToQuantity_WithSingularInput_ReturnsSingularForQuantityOne() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 1;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("1 request", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithSingularInput_ReturnsPluralForQuantityZero() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 0;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("0 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithCustomFormat_AppliesFormatting() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 10000;
//            var format = "N0";

//            // Act
//            string result = input.ToQuantity(quantity, format);

//            // Assert
//            Assert.AreEqual("10,000 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithFrenchFormatProvider_AppliesFormatting() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 1000;
//            var format = "N0";
//            var formatProvider = new CultureInfo("fr-FR");

//            // Act
//            string result = input.ToQuantity(quantity, format, formatProvider);

//            // Assert
//            // Using string.Contains to avoid culture-specific space character issues
//            StringAssert.Contains(result, "1");
//            StringAssert.Contains(result, "000");
//            StringAssert.Contains(result, "requests");
//        }

//        [TestMethod]
//        public void ToQuantity_WithNullFormatProvider_UsesCurrentCulture() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 1000;

//            // Act
//            string result = input.ToQuantity(quantity, null, null);

//            // Assert
//            StringAssert.Contains(result, "1000");
//            StringAssert.Contains(result, "requests");
//        }

//        [TestMethod]
//        public void ToQuantity_WithNegativeQuantity_HandlesNegativeNumbers() {
//            // Arrange
//            const string input = "request";
//            const long quantity = -5;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("-5 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithEmptyInput_ReturnsFormattedQuantityWithSpace() {
//            // Arrange
//            const string input = "";
//            const long quantity = 5;

//            // Act
//            string result = input.ToQuantity(quantity);

//            // Assert
//            Assert.AreEqual("5 ", result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ToQuantity_WithNullInput_ThrowsArgumentNullException() {
//            // Act & Assert
//#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type
//            string result = ToQuantityExtensions.ToQuantity(null, 5, "N0", null);
//#pragma warning restore CS8625
//        }

//        [TestMethod]
//        public void ToQuantity_WithLongNumber_UsesProperFormatting() {
//            // Arrange
//            const string input = "item";
//            const long quantity = 1234567;
//            const string format = "N0";

//            // Act
//            string result = input.ToQuantity(quantity, format);

//            // Assert
//            Assert.AreEqual("1,234,567 items", result);
//        }
//    }
//}