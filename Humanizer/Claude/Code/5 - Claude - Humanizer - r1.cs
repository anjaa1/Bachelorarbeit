//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class StringHumanizeExtensionsTests {
//        [TestMethod]
//        public void Humanize_WithPascalCase_ReturnsSentenceCase() {
//            // Arrange
//            string input = "PascalCaseInputString";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Pascal case input string", result);
//        }

//        [TestMethod]
//        public void Humanize_WithUnderscoreSeparatedWords_ReturnsSentenceCase() {
//            // Arrange
//            string input = "Underscored_input_String_is_humanized";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Underscored input String is humanized", result);
//        }

//        [TestMethod]
//        public void Humanize_WithDashSeparatedWords_ReturnsSentenceCase() {
//            // Arrange
//            string input = "Dash-separated-input-String";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Dash separated input String", result);
//        }

//        [TestMethod]
//        public void Humanize_WithAllCapitals_ReturnsUnchangedString() {
//            // Arrange
//            string input = "ACRONYM";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("ACRONYM", result);
//        }

//        [TestMethod]
//        public void Humanize_WithFreestandingSpacingChar_RemovesSpacingChar() {
//            // Arrange
//            string input = "Free - standing";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Free standing", result);
//        }

//        [TestMethod]
//        public void Humanize_WithMixedUnderscoresAndDashes_ReturnsSentenceCase() {
//            // Arrange
//            string input = "Mixed_input-with_different-separators";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Mixed input with different separators", result);
//        }

//        [TestMethod]
//        public void Humanize_WithEmptyString_ReturnsEmptyString() {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }

//        [TestMethod]
//        public void Humanize_WithNull_ThrowsArgumentNullException() {
//            // Arrange
//            string input = null;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => input.Humanize());
//        }

//        [TestMethod]
//        public void Humanize_WithSingleCharacter_ReturnsCapitalizedCharacter() {
//            // Arrange
//            string input = "x";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("X", result);
//            // The Humanize method applies PascalCase transformation to single characters
//        }

//        [TestMethod]
//        public void Humanize_WithConsecutiveUnderscores_PreservesSpacing() {
//            // Arrange
//            string input = "multiple__underscores___test";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("multiple  underscores   test", result);
//            // The Humanize method preserves consecutive underscores as spaces
//        }
//    }
//}