//using Humanizer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Text.RegularExpressions;

//namespace HumanizerTests {
//    [TestClass]
//    public class StringHumanizeExtensionsTests {
//        private static readonly Regex FreestandingSpacingCharRegex = new Regex(@"\s([-_])\s");

//        [TestMethod]
//        public void Humanize_Humanizes_UnderscoredString() {
//            // Arrange
//            var input = "Underscored_input_String_is_turned_INTO_sentence";
//            var expected = "Underscored input String is turned INTO sentence";

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_Humanizes_DashedString() {
//            // Arrange
//            var input = "Underscored-input-String-is-turned-INTO-sentence";
//            var expected = "Underscored input String is turned INTO sentence";

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_Humanizes_FreeStandingSpacingString() {
//            // Arrange
//            var input = "free- _standing- _ spacing";
//            var expected = "free standing spacing";

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_DoesNotChange_UpperCaseString() {
//            // Arrange
//            var input = "UPPERCASE";
//            var expected = "UPPERCASE";

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void Humanize_HandlesNullInput() {
//            // Arrange
//            var input = (string)null;
//            var expected = null;

//            // Act
//            var result = input?.Humanize();

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void Humanize_HandlesEmptyString() {
//            // Arrange
//            var input = string.Empty;
//            var expected = string.Empty;

//            // Act
//            var result = input?.Humanize();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//    }
//}