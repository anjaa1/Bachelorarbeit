//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace HumanizerTests {
//    [TestClass]
//    public class StringHumanizeExtensionsTests {
//        [TestMethod]
//        public void Humanize_Should_ReturnInput_When_AllUpperCase() {
//            // Arrange
//            string input = "NASA";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("NASA", result);
//        }

//        [TestMethod]
//        public void Humanize_Should_RemoveUnderscoresAndHumanizeText() {
//            // Arrange
//            string input = "Underscored_input_String";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Underscored input String", result);
//        }

//        [TestMethod]
//        public void Humanize_Should_RemoveDashesAndHumanizeText() {
//            // Arrange
//            string input = "Dashed-input-String";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Dashed input String", result);
//        }

//        [TestMethod]
//        public void Humanize_Should_HumanizePascalCaseString() {
//            // Arrange
//            string input = "PascalCaseInputString";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Pascal case input String", result);
//        }

//        [TestMethod]
//        public void Humanize_Should_HandleEmptyString() {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }

//        [TestMethod]
//        public void Humanize_Should_HandleNullInput() {
//            // Arrange
//            string input = null;

//            // Act and Assert
//            Assert.ThrowsException<System.ArgumentNullException>(() => input.Humanize());
//        }

//        [TestMethod]
//        public void Humanize_Should_HandleSingleCharacterInput() {
//            // Arrange
//            string input = "A";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("A", result);
//        }

//        [TestMethod]
//        public void Humanize_Should_HandleMixedCaseInputWithUnderscores() {
//            // Arrange
//            string input = "This_IS_A_Test";

//            // Act
//            string result = input.Humanize();

//            // Assert
//            Assert.AreEqual("This IS A Test", result);
//        }
//    }
//}
