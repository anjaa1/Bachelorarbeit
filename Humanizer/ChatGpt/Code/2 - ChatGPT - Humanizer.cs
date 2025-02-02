//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;
//using System;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumDehumanizeExtensionsTests {
//        // Sample enum for testing
//        private enum SampleEnum {
//            ValueOne,
//            ValueTwo,
//            ValueThree
//        }

//        [TestMethod]
//        public void DehumanizeTo_ValidInput_ShouldReturnExpectedEnumValue() {
//            // Arrange
//            string input = "Value One"; // Humanized form of ValueOne

//            // Act
//            var result = input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException);

//            // Assert
//            Assert.AreEqual(SampleEnum.ValueOne, result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_InvalidInput_ShouldThrowNoMatchFoundException() {
//            // Arrange
//            string input = "Invalid Value";

//            // Act & Assert
//            Assert.ThrowsException<NoMatchFoundException>(() => input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException));
//        }

//        [TestMethod]
//        public void DehumanizeTo_InvalidInput_ReturnsNull_WhenOnNoMatchIsReturnsNull() {
//            // Arrange
//            string input = "Invalid Value";

//            // Act
//            var result = input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ReturnsNull);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_NullInput_ShouldThrowArgumentNullException() {
//            // Arrange
//            string input = null;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException));
//        }

//        [TestMethod]
//        public void DehumanizeTo_NonEnumTargetType_ShouldThrowArgumentException() {
//            // Arrange
//            string input = "ValueOne";

//            // Act & Assert
//            Assert.ThrowsException<ArgumentException>(() => input.DehumanizeTo(typeof(string), OnNoMatch.ThrowsException));
//        }

//        [TestMethod]
//        public void DehumanizeTo_EmptyInput_ShouldThrowNoMatchFoundException() {
//            // Arrange
//            string input = "";

//            // Act & Assert
//            Assert.ThrowsException<NoMatchFoundException>(() => input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException));
//        }

//        [TestMethod]
//        public void DehumanizeTo_WhitespaceInput_ShouldThrowNoMatchFoundException() {
//            // Arrange
//            string input = "   ";

//            // Act & Assert
//            Assert.ThrowsException<NoMatchFoundException>(() => input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException));
//        }

//        [TestMethod]
//        public void DehumanizeTo_ValidInputWithDifferentCase_ShouldReturnExpectedEnumValue() {
//            // Arrange
//            string input = "value one"; // Case-insensitive humanized form

//            // Act
//            var result = input.DehumanizeTo(typeof(SampleEnum), OnNoMatch.ThrowsException);

//            // Assert
//            Assert.AreEqual(SampleEnum.ValueOne, result);
//        }
//    }
//}
