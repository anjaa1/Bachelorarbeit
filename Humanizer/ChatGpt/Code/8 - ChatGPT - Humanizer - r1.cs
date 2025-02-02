//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class HeadingExtensionsTests {
//        [TestInitialize]
//        public void Setup() {
//            // Mock the Resources.GetResource method to return expected localized values.
//            Resources.GetResource = (key, culture) => {
//                // Mocked resource dictionary
//                var mockedResources = new Dictionary<string, string>
//                {
//                    { "NNE_Short", "NNE_Short" },
//                    { "E_Short", "E_Short" },
//                    { "nne_short", "NNE_Short" } // Normalize for case insensitivity
//                };

//                return mockedResources.TryGetValue(key, out var value) ? value : null;
//            };
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_ValidInput_ReturnsCorrectHeading() {
//            // Arrange
//            string heading = "NNE_Short";
//            double expected = 22.5;
//            CultureInfo culture = CultureInfo.InvariantCulture;

//            // Act
//            double result = heading.FromAbbreviatedHeading(culture);

//            // Assert
//            Assert.AreEqual(expected, result, 0.001, "The heading does not match the expected value.");
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_ValidInputWithDifferentCulture_ReturnsCorrectHeading() {
//            // Arrange
//            string heading = "E_Short";
//            double expected = 90.0;
//            CultureInfo culture = new CultureInfo("fr-FR");

//            // Act
//            double result = heading.FromAbbreviatedHeading(culture);

//            // Assert
//            Assert.AreEqual(expected, result, 0.001, "The heading does not match the expected value for the specified culture.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void FromAbbreviatedHeading_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            string heading = null;

//            // Act
//            heading.FromAbbreviatedHeading();

//            // Assert - Handled by ExpectedException
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_InvalidInput_ReturnsNegativeOne() {
//            // Arrange
//            string heading = "INVALID_HEADING";
//            double expected = -1;

//            // Act
//            double result = heading.FromAbbreviatedHeading();

//            // Assert
//            Assert.AreEqual(expected, result, 0.001, "Invalid input should return -1.");
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_EmptyInput_ReturnsNegativeOne() {
//            // Arrange
//            string heading = string.Empty;
//            double expected = -1;

//            // Act
//            double result = heading.FromAbbreviatedHeading();

//            // Assert
//            Assert.AreEqual(expected, result, 0.001, "Empty input should return -1.");
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_UpperAndLowerCaseInput_ReturnsCorrectHeading() {
//            // Arrange
//            string heading = "nne_short";
//            double expected = 22.5;

//            // Act
//            double result = heading.FromAbbreviatedHeading();

//            // Assert
//            Assert.AreEqual(expected, result, 0.001, "The method should handle case-insensitive inputs correctly.");
//        }
//    }
//}
