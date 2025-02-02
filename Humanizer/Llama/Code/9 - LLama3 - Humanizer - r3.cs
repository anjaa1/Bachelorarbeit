using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Humanizer.Tests {
    [TestClass]
    public class EnglishArticleTests {
        //[TestMethod]
        //public void AppendArticlePrefix_TypicalCase_ReturnsSortedArray() {
        //    // Arrange
        //    var input = new[] { "The quick brown fox", "a lazy dog", "An elephant", "The sun" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(new[] { "a lazy dog", "An elephant", "The quick brown fox", "The sun" }, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_NoArticlePrefix_ReturnsOriginalArray() {
        //    // Arrange
        //    var input = new[] { "quick brown fox", "lazy dog", "elephant", "sun" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(input, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_NullInput_ThrowsArgumentNullException() {
        //    // Act and Assert
        //    Assert.ThrowsException<ArgumentNullException>(() => EnglishArticle.AppendArticlePrefix(null));
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_InvalidArticlePrefix_ReturnsOriginalArray() {
        //    // Arrange
        //    var input = new[] { "The quick brown fox", "xyz lazy dog", "An elephant", "The sun" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(input, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_SingleElementArray_ReturnsSortedArray() {
        //    // Arrange
        //    var input = new[] { "The quick brown fox" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(new[] { "The quick brown fox" }, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_EmptyArray_ReturnsEmptyArray() {
        //    // Arrange
        //    var input = new string[0];

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(input, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_DuplicateStrings_ReturnsSortedArray() {
        //    // Arrange
        //    var input = new[] { "The quick brown fox", "The quick brown fox", "a lazy dog", "An elephant" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(new[] { "a lazy dog", "An elephant", "The quick brown fox", "The quick brown fox" }, result);
        //}

        //[TestMethod]
        //public void AppendArticlePrefix_MultipleArticlePrefixes_ReturnsSortedArray() {
        //    // Arrange
        //    var input = new[] { "The quick brown fox", "The quick brown fox", "The quick brown fox", "a lazy dog" };

        //    // Act
        //    var result = EnglishArticle.AppendArticlePrefix(input);

        //    // Assert
        //    CollectionAssert.AreEqual(new[] { "a lazy dog", "The quick brown fox", "The quick brown fox", "The quick brown fox" }, result);
        //}

        [TestMethod]
        public void AppendArticlePrefix_NoArticlePrefix_ReturnsOriginalArray_WithSingleElementArray() {
            // Arrange
            var input = new[] { "quick brown fox" };

            // Act
            var result = EnglishArticle.AppendArticlePrefix(input);

            // Assert
            CollectionAssert.AreEqual(input, result);
        }
    }
}