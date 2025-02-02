//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class TruncateExtensionsTests {
//        private Mock<ITruncator> _mockTruncator;

//        [TestInitialize]
//        public void Setup() {
//            _mockTruncator = new Mock<ITruncator>();
//        }

//        [TestMethod]
//        public void Truncate_NullInput_ReturnsNull() {
//            // Arrange
//            string? input = null;

//            // Act
//            var result = input.Truncate(5, "...", _mockTruncator.Object);

//            // Assert
//            Assert.IsNull(result);
//            _mockTruncator.Verify(t => t.Truncate(It.IsAny<string>(), It.IsAny<int>(),
//                It.IsAny<string>(), It.IsAny<TruncateFrom>()), Times.Never);
//        }

//        [TestMethod]
//        public void Truncate_NullTruncator_ThrowsArgumentNullException() {
//            // Arrange
//            string input = "test string";
//            ITruncator? truncator = null;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() =>
//                input.Truncate(5, "...", truncator!));
//        }

//        [TestMethod]
//        public void Truncate_ValidInput_CallsTruncatorWithCorrectParameters() {
//            // Arrange
//            string input = "test string";
//            int length = 5;
//            string truncationString = "...";
//            TruncateFrom from = TruncateFrom.Left;

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, from))
//                .Returns("result");

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object, from);

//            // Assert
//            Assert.AreEqual("result", result);
//            _mockTruncator.Verify(t => t.Truncate(input, length, truncationString, from),
//                Times.Once);
//        }

//        [TestMethod]
//        public void Truncate_DefaultTruncateFrom_UsesRight() {
//            // Arrange
//            string input = "test string";
//            int length = 5;
//            string truncationString = "...";

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Right))
//                .Returns("result");

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object);

//            // Assert
//            Assert.AreEqual("result", result);
//            _mockTruncator.Verify(t => t.Truncate(input, length, truncationString,
//                TruncateFrom.Right), Times.Once);
//        }

//        [TestMethod]
//        public void Truncate_NullTruncationString_PassesNullToTruncator() {
//            // Arrange
//            string input = "test string";
//            int length = 5;
//            string? truncationString = null;

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Right))
//                .Returns("result");

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object);

//            // Assert
//            Assert.AreEqual("result", result);
//            _mockTruncator.Verify(t => t.Truncate(input, length, truncationString,
//                TruncateFrom.Right), Times.Once);
//        }

//        [TestMethod]
//        [DataRow(0)]
//        [DataRow(-1)]
//        public void Truncate_ZeroOrNegativeLength_PassesLengthToTruncator(int length) {
//            // Arrange
//            string input = "test string";
//            string truncationString = "...";

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Right))
//                .Returns("result");

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object);

//            // Assert
//            Assert.AreEqual("result", result);
//            _mockTruncator.Verify(t => t.Truncate(input, length, truncationString,
//                TruncateFrom.Right), Times.Once);
//        }
//    }
//}