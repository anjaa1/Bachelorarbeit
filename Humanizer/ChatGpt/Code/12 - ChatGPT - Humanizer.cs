//using System;
//using Humanizer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace HumanizerTests {
//    [TestClass]
//    public class CasingExtensionsTests {
//        [TestMethod]
//        public void ApplyCase_TitleCase_ShouldTransformToTitleCase() {
//            // Arrange
//            string input = "INvalid caSEs arE corrected";
//            string expected = "Invalid Cases Are Corrected";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Title);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ApplyCase_AllCaps_ShouldTransformToAllCaps() {
//            // Arrange
//            string input = "lower case statement";
//            string expected = "LOWER CASE STATEMENT";

//            // Act
//            string result = input.ApplyCase(LetterCasing.AllCaps);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ApplyCase_LowerCase_ShouldTransformToLowerCase() {
//            // Arrange
//            string input = "Sentence casing";
//            string expected = "sentence casing";

//            // Act
//            string result = input.ApplyCase(LetterCasing.LowerCase);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ApplyCase_SentenceCase_ShouldTransformToSentenceCase() {
//            // Arrange
//            string input = "lower case statement";
//            string expected = "Lower case statement";

//            // Act
//            string result = input.ApplyCase(LetterCasing.Sentence);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ApplyCase_InvalidCasing_ShouldThrowArgumentOutOfRangeException() {
//            // Arrange
//            string input = "Some random text";

//            // Act
//            string result = input.ApplyCase((LetterCasing)999);

//            // Assert
//            // Exception is expected, no additional assertions needed
//        }

//        [TestMethod]
//        public void ApplyCase_NullInput_ShouldHandleGracefully() {
//            // Arrange
//            string input = null;
//            LetterCasing casing = LetterCasing.Title;

//            // Act
//            string result = input.ApplyCase(casing);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void ApplyCase_EmptyInput_ShouldReturnEmptyString() {
//            // Arrange
//            string input = string.Empty;
//            LetterCasing casing = LetterCasing.AllCaps;

//            // Act
//            string result = input.ApplyCase(casing);

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }
//    }
//}
