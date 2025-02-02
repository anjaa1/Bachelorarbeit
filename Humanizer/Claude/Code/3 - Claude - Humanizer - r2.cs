//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Globalization;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class ToQuantityExtensionsTests {
//        private static readonly CultureInfo DefaultCulture = CultureInfo.InvariantCulture;

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

//            // Act
//            string result = input.ToQuantity(quantity, "N0", DefaultCulture);

//            // Assert
//            Assert.AreEqual("10,000 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithFrenchFormatProvider_AppliesFormatting() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 1000;
//            var formatProvider = new CultureInfo("fr-FR");

//            // Act
//            string result = input.ToQuantity(quantity, "N0", formatProvider);

//            // Assert
//            Assert.AreEqual("1 000 requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithShowQuantityAsNone_ReturnsOnlyWord() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 5;

//            // Act
//            string result = input.ToQuantity(quantity, ShowQuantityAs.None);

//            // Assert
//            Assert.AreEqual("requests", result);
//        }

//        [TestMethod]
//        public void ToQuantity_WithNullFormatProvider_UsesCurrentCulture() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 1000;

//            // Act
//            string result = input.ToQuantity(quantity, "N0");

//            // Assert
//            Assert.IsTrue(result.EndsWith("requests"));
//            Assert.IsTrue(result.StartsWith("1"));
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
//            // Arrange
//            string? input = null;
//            const long quantity = 5;

//            // Act & Assert
//#pragma warning disable CS8604 // Possible null reference argument
//            _ = input.ToQuantity(quantity);
//#pragma warning restore CS8604
//        }

//        [TestMethod]
//        public void ToQuantity_WithShowQuantityAsWords_ReturnsQuantityInWords() {
//            // Arrange
//            const string input = "request";
//            const long quantity = 123;

//            // Act
//            string result = input.ToQuantity(quantity, ShowQuantityAs.Words);

//            // Assert
//            Assert.AreEqual("one hundred and twenty-three requests", result);
//        }
//    }
//}