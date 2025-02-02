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

//            // Act
//            var result = truncator.Truncate(input, length, truncationString, TruncateFrom.Right);

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
//            var result = truncator.Truncate(input, length, truncationString, from);

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
//            var result = truncator.Truncate(input, length, truncationString, from);

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
//            Assert.ThrowsException<ArgumentNullException>(() => Truncate(input, length, truncationString, truncator, from));
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
//            var result = truncator.Truncate(input, length, truncationString, from);

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
//            var result = truncator.Truncate(input, length, truncationString, from);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//    }
//}