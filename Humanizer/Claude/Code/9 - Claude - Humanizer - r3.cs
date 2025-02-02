//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests
//{
//    [TestClass]
//    public class EnglishArticleTests
//    {
//        [TestMethod]
//        public void AppendArticlePrefix_WithExtraWhitespace_ReturnsNormalizedArray() {
//            // Arrange
//            var input = new[]
//            {
//                "  The    Cat  ",
//                "A   Dog",
//                "   An    Elephant    "
//            };

//            var expected = new[]
//            {
//                "Cat The",
//                "Dog A",
//                "Elephant An"
//            };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_WithMixedArticlesAndNoArticles_ReturnsCorrectlySortedArray() {
//            // Arrange
//            var input = new[]
//            {
//                "The Cat",
//                "Plain Dog",
//                "An Elephant",
//                "Simple Bird",
//                "a Mouse"
//            };

//            var expected = new[]
//            {
//                "Bird Simple",
//                "Cat The",
//                "Dog Plain",
//                "Elephant An",
//                "Mouse a"
//            };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void AppendArticlePrefix_WithEmptyArray_ThrowsArgumentOutOfRangeException()
//        {
//            // Arrange
//            var input = Array.Empty<string>();

//            // Act & Assert
//            _ = EnglishArticle.AppendArticlePrefix(input);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_WithSingleArticle_ReturnsTransformedArray()
//        {
//            // Arrange
//            var input = new[] { "The Cat" };
//            var expected = new[] { "Cat The" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}