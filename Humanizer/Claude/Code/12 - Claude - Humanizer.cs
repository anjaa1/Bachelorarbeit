//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class CasingExtensionsTests {
//        [TestMethod]
//        public void ApplyCase_TitleCasing_ReturnsCorrectFormat() {
//            // Arrange
//            string input = "this IS a TEST string";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual("This Is A Test String", result);
//        }

//        [TestMethod]
//        public void ApplyCase_AllCaps_ReturnsUpperCase() {
//            // Arrange
//            string input = "convert this to upper case";

//            // Act
//            string result = input.ApplyCase(LetterCasing.AllCaps);

//            // Assert
//            Assert.AreEqual("CONVERT THIS TO UPPER CASE", result);
//        }

//        [TestMethod]
//        public void ApplyCase_LowerCase_ReturnsLowerCase() {
//            // Arrange
//            string input = "CONVERT THIS to LoweR caSE";

//            // Act
//            string result = input.ApplyCase(LetterCasing.LowerCase);

//            // Assert
//            Assert.AreEqual("convert this to lower case", result);
//        }

//        [TestMethod]
//        public void ApplyCase_SentenceCase_ReturnsCorrectFormat() {
//            // Arrange
//            string input = "tHIS should BE sentence CASE";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Sentence);

//            // Assert
//            Assert.AreEqual("This should be sentence case", result);
//        }

//        [TestMethod]
//        public void ApplyCase_EmptyString_ReturnsEmptyString() {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }

//        [TestMethod]
//        public void ApplyCase_WhiteSpace_PreservesWhiteSpace() {
//            // Arrange
//            string input = "   multiple   spaces   ";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual("   Multiple   Spaces   ", result);
//        }

//        [TestMethod]
//        public void ApplyCase_SpecialCharacters_PreservesSpecialCharacters() {
//            // Arrange
//            string input = "test@email.com with $pecial #tags";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual("Test@Email.Com With $pecial #Tags", result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ApplyCase_InvalidLetterCasing_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            string input = "test string";

//            // Act
//            // Using cast to simulate invalid enum value
//            input.ApplyCase((LetterCasing)999);

//            // Assert is handled by ExpectedException attribute
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ApplyCase_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            string input = null;

//            // Act
//            input.ApplyCase(LetterCasing.Title);

//            // Assert is handled by ExpectedException attribute
//        }

//        [TestMethod]
//        public void ApplyCase_NumbersInString_PreservesNumbers() {
//            // Arrange
//            string input = "test123 with 456 numbers";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual("Test123 With 456 Numbers", result);
//        }
//    }
//}