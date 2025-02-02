//using Humanizer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Humanizer.Test;

//[TestClass]
//public class CasingExtensionsTests {
//    [TestMethod]
//    public void TestApplyCase_Title() {
//        // Arrange
//        var input = "some string";
//        var expected = "Some String";

//        // Act
//        var result = input.ApplyCase(LetterCasing.Title);

//        // Assert
//        Assert.AreEqual(expected, result);
//    }

//    [TestMethod]
//    public void TestApplyCase_AllCaps() {
//        // Arrange
//        var input = "some string";
//        var expected = "SOME STRING";

//        // Act
//        var result = input.ApplyCase(LetterCasing.AllCaps);

//        // Assert
//        Assert.AreEqual(expected, result);
//    }

//    [TestMethod]
//    public void TestApplyCase_LowerCase() {
//        // Arrange
//        var input = "Some String";
//        var expected = "some string";

//        // Act
//        var result = input.ApplyCase(LetterCasing.LowerCase);

//        // Assert
//        Assert.AreEqual(expected, result);
//    }

//    [TestMethod]
//    public void TestApplyCase_Sentence() {
//        // Arrange
//        var input = "some string";
//        var expected = "Some string";

//        // Act
//        var result = input.ApplyCase(LetterCasing.Sentence);

//        // Assert
//        Assert.AreEqual(expected, result);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentOutOfRangeException))]
//    public void TestApplyCase_InvalidCasing() {
//        // Arrange
//        var input = "some string";
//        var expected = "some string";

//        // Act
//        var result = input.ApplyCase((LetterCasing)100);
//    }

//    [TestMethod]
//    public void TestApplyCase_NullInput() {
//        // Arrange
//        var input = null as string;
//        var expected = null;

//        // Act
//        if (input != null) {
//            var result = input.ApplyCase(LetterCasing.Title);
//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//        else {
//            Assert.IsNull(expected);
//        }
//    }

//    [TestMethod]
//    public void TestApplyCase_EmptyInput() {
//        // Arrange
//        var input = string.Empty;
//        var expected = string.Empty;

//        // Act
//        if (!string.IsNullOrEmpty(input)) {
//            var result = input.ApplyCase(LetterCasing.Title);
//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//        else {
//            Assert.AreEqual(expected, input);
//        }
//    }
//}