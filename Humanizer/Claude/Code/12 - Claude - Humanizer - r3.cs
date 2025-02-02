//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class CasingExtensionsTests {
//        [TestMethod]
//        public void ApplyCase_TitleCase_ReturnsCorrectFormat() {
//            // Arrange
//            string input = "INvalid caSEs arE corrected";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual("Invalid Cases Are Corrected", result);
//        }

//        [TestMethod]
//        public void ApplyCase_AllCaps_ReturnsUpperCase() {
//            // Arrange
//            string input = "lower case statement";

//            // Act
//            string result = input.ApplyCase(LetterCasing.AllCaps);

//            // Assert
//            Assert.AreEqual("LOWER CASE STATEMENT", result);
//        }

//        [TestMethod]
//        public void ApplyCase_LowerCase_ReturnsLowerCase() {
//            // Arrange
//            string input = "Sentence casing";

//            // Act
//            string result = input.ApplyCase(LetterCasing.LowerCase);

//            // Assert
//            Assert.AreEqual("sentence casing", result);
//        }

//        [TestMethod]
//        public void ApplyCase_SentenceCase_ReturnsCorrectFormat() {
//            // Arrange
//            string input = "lower case statement";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Sentence);

//            // Assert
//            Assert.AreEqual("Lower case statement", result);
//        }

//        [TestMethod]
//        public void ApplyCase_EmptyString_ReturnsEmptyString() {
//            // Arrange
//            string input = string.Empty;

//            // Act & Assert
//            Assert.AreEqual(string.Empty, input.ApplyCase(LetterCasing.Title));
//            Assert.AreEqual(string.Empty, input.ApplyCase(LetterCasing.AllCaps));
//            Assert.AreEqual(string.Empty, input.ApplyCase(LetterCasing.LowerCase));
//            Assert.AreEqual(string.Empty, input.ApplyCase(LetterCasing.Sentence));
//        }

//        [TestMethod]
//        public void ApplyCase_WhiteSpaceHandling() {
//            // Arrange
//            string input = "   multiple   spaces   ";

//            // Act & Assert
//            // Test each casing type with its expected whitespace handling
//            Assert.AreEqual("   multiple   spaces   ", input.ApplyCase(LetterCasing.LowerCase));
//            Assert.AreEqual("   MULTIPLE   SPACES   ", input.ApplyCase(LetterCasing.AllCaps));
//            Assert.AreEqual("   multiple   spaces   ", input.ApplyCase(LetterCasing.Sentence));
//            Assert.AreEqual("   Multiple   Spaces   ", input.ApplyCase(LetterCasing.Title));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ApplyCase_InvalidLetterCasing_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            string input = "test string";

//            // Act
//            input.ApplyCase((LetterCasing)999);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ApplyCase_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            string input = null;

//            // Act
//            input.ApplyCase(LetterCasing.Title);
//        }
//    }
//}