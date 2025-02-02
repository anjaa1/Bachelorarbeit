//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests
//{
//    [TestClass]
//    public class EnglishArticleTests
//    {
//        [TestMethod]
//        public void AppendArticlePrefix_WithValidArticles_ReturnsCorrectlySortedArray()
//        {
//            // Arrange
//            var input = new[]
//            {
//                "The Cat",
//                "A Dog",
//                "An Elephant",
//                "the Bird",
//                "a Mouse",
//                "an Owl"
//            };

//            var expected = new[]
//            {
//                "Bird the",
//                "Cat The",
//                "Dog A",
//                "Elephant An",
//                "Mouse a",
//                "Owl an"
//            };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_WithMixedArticlesAndNoArticles_ReturnsCorrectlySortedArray()
//        {
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
//        public void AppendArticlePrefix_WithExtraWhitespace_ReturnsNormalizedArray()
//        {
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
//        public void AppendArticlePrefix_WithSingleElement_ReturnsCorrectlyTransformedArray()
//        {
//            // Arrange
//            var input = new[] { "The Cat" };
//            var expected = new[] { "Cat The" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_WithLowercaseArticles_HandlesCorrectly()
//        {
//            // Arrange
//            var input = new[]
//            {
//                "the Cat",
//                "a Dog",
//                "an Elephant"
//            };

//            var expected = new[]
//            {
//                "Cat the",
//                "Dog a",
//                "Elephant an"
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

//            // Act
//            EnglishArticle.AppendArticlePrefix(input);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_WithEmptyStrings_PreservesEmptyStrings()
//        {
//            // Arrange
//            var input = new[]
//            {
//                "The Cat",
//                "",
//                "A Dog"
//            };

//            var expected = new[]
//            {
//                "",
//                "Cat The",
//                "Dog A"
//            };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}