//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class CasingExtensionsTests {
//        [TestMethod]
//        public void ApplyCase_WhiteSpace_PreservesWhiteSpace() {
//            // Arrange
//            string input = "   multiple   spaces   ";

//            // Act & Assert - Testing all casing types
//            Assert.AreEqual("   MULTIPLE   SPACES   ", input.ApplyCase(LetterCasing.AllCaps), "AllCaps should preserve whitespace");
//            Assert.AreEqual("   multiple   spaces   ", input.ApplyCase(LetterCasing.LowerCase), "LowerCase should preserve whitespace");
//            Assert.AreEqual("   Multiple   Spaces   ", input.ApplyCase(LetterCasing.Title), "Title should preserve whitespace");
//            Assert.AreEqual("   Multiple   spaces   ", input.ApplyCase(LetterCasing.Sentence), "Sentence should preserve whitespace");
//        }

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
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ApplyCase_InvalidLetterCasing_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            string input = "test string";

//            // Act - this should throw ArgumentOutOfRangeException
//            input.ApplyCase((LetterCasing)999);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ApplyCase_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            string input = null;

//            // Act - this should throw ArgumentNullException
//            input.ApplyCase(LetterCasing.Title);
//        }
//    }
//}