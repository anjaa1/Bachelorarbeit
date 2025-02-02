//using Humanizer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace UnitTests {
//    [TestClass]
//    public class TruncateExtensionsTests {
//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = "Hello, Worl";
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase_Left() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = "ello, Worl";
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Left;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase_NullInput() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = null;
//            var expected = null;
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase_NullTruncator() {
//            // Arrange
//            var input = "Hello, World!";
//            var expected = null;
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;
//            var truncator = null;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => TruncateExtensions.Truncate(input, length, truncationString, truncator, from));
//        }

//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase_ZeroLength() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = input;
//            var length = 0;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_TypicalUseCase_NegativeLength() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = input;
//            var length = -1;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_NullTruncator_ThrowsArgumentNullException() {
//            // Arrange
//            var input = "Hello, World!";
//            var expected = null;
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;
//            var truncator = null;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => TruncateExtensions.Truncate(input, length, truncationString, truncator, from));
//        }

//        [TestMethod]
//        public void TruncateExtensions_NullInput_ReturnsNull() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = null;
//            var expected = null;
//            var length = 10;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_ZeroLength_ReturnsOriginalString() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = input;
//            var length = 0;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void TruncateExtensions_NegativeLength_ReturnsOriginalString() {
//            // Arrange
//            var truncator = new Truncator();
//            var input = "Hello, World!";
//            var expected = input;
//            var length = -1;
//            var truncationString = "...";
//            var from = TruncateFrom.Right;

//            // Act
//            var result = TruncateExtensions.Truncate(input, length, truncationString, truncator, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//    }
//}

//public class Truncator : ITruncator {
//    public string? Truncate(string? value, int length, string? truncationString, TruncateFrom truncateFrom = TruncateFrom.Right) {
//        if (value == null) {
//            return null;
//        }

//        if (length <= 0) {
//            return value;
//        }

//        var truncatedValue = value.Length <= length ? value : value.Substring(0, length);

//        if (truncatedValue.Length < length) {
//            var remainingLength = length - truncatedValue.Length;
//            var truncationStringLength = truncationString?.Length ?? 0;
//            if (remainingLength > truncationStringLength) {
//                return truncatedValue + truncationString!.Repeat(remainingLength - truncationStringLength);
//            }
//            else {
//                return truncatedValue + truncationString!.Substring(0, remainingLength);
//            }
//        }
//        else {
//            return truncatedValue;
//        }
//    }
//}

//public interface ITruncator {
//    string? Truncate(string? value, int length, string? truncationString, TruncateFrom truncateFrom = TruncateFrom.Right);
//}

//public static class TruncateExtensions {
//    public static string? Truncate(this string? input, int length, string? truncationString, ITruncator truncator, TruncateFrom from = TruncateFrom.Right) {
//        if (truncator == null) {
//            throw new ArgumentNullException(nameof(truncator));
//        }

//        if (input == null) {
//            return null;
//        }

//        return truncator.Truncate(input, length, truncationString, from);
//    }
//}

//public enum TruncateFrom {
//    Left,
//    Right
//}

//public static class StringExtensions {
//    public static string? Repeat(this string? value, int count) {
//        var result = "";
//        for (int i = 0; i < count; i++) {
//            result += value!;
//        }
//        return result;
//    }
//}