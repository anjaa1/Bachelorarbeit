//using System;
//using System.Globalization;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class HeadingExtensionsTests {
//        private static readonly CultureInfo EnglishCulture = new CultureInfo("en-US");
//        private static readonly CultureInfo GermanCulture = new CultureInfo("de-DE");

//        [TestMethod]
//        public void FromAbbreviatedHeading_ValidHeadings_ReturnsCorrectDegrees() {
//            // Arrange
//            var testCases = new[]
//            {
//                ("N_Short", 0.0),      // North
//                ("NE_Short", 45.0),    // Northeast
//                ("E_Short", 90.0),     // East
//                ("SE_Short", 135.0),   // Southeast
//                ("S_Short", 180.0),    // South
//                ("SW_Short", 225.0),   // Southwest
//                ("W_Short", 270.0),    // West
//                ("NW_Short", 315.0),   // Northwest
//            };

//            // Act & Assert
//            foreach (var (resourceKey, expectedDegrees) in testCases) {
//                var heading = Resources.GetResource(resourceKey, EnglishCulture);
//                var result = heading.FromAbbreviatedHeading(EnglishCulture);
//                Assert.AreEqual(expectedDegrees, result, 0.01,
//                    $"Failed for heading {heading}, expected {expectedDegrees} degrees");
//            }
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_IntermediateHeadings_ReturnsCorrectDegrees() {
//            // Arrange
//            var testCases = new[]
//            {
//                ("NNE_Short", 22.5),
//                ("ENE_Short", 67.5),
//                ("SSE_Short", 157.5),
//                ("SSW_Short", 202.5),
//                ("WSW_Short", 247.5),
//                ("WNW_Short", 292.5),
//                ("NNW_Short", 337.5)
//            };

//            // Act & Assert
//            foreach (var (resourceKey, expectedDegrees) in testCases) {
//                var heading = Resources.GetResource(resourceKey, EnglishCulture);
//                var result = heading.FromAbbreviatedHeading(EnglishCulture);
//                Assert.AreEqual(expectedDegrees, result, 0.01,
//                    $"Failed for heading {heading}, expected {expectedDegrees} degrees");
//            }
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_CaseInsensitive_ReturnsCorrectDegrees() {
//            // Arrange
//            var heading = Resources.GetResource("N_Short", EnglishCulture);

//            // Act & Assert
//            Assert.AreEqual(0.0, heading.ToLower().FromAbbreviatedHeading(EnglishCulture), 0.01);
//            Assert.AreEqual(0.0, heading.ToUpper().FromAbbreviatedHeading(EnglishCulture), 0.01);
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_DifferentCultures_ReturnsCorrectDegrees() {
//            // Arrange
//            var resourceKey = "N_Short";
//            var englishHeading = Resources.GetResource(resourceKey, EnglishCulture);
//            var germanHeading = Resources.GetResource(resourceKey, GermanCulture);

//            // Act
//            var englishResult = englishHeading.FromAbbreviatedHeading(EnglishCulture);
//            var germanResult = germanHeading.FromAbbreviatedHeading(GermanCulture);

//            // Assert
//            Assert.AreEqual(0.0, englishResult, 0.01);
//            Assert.AreEqual(0.0, germanResult, 0.01);
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_NullCulture_UsesCurrentCulture() {
//            // Arrange
//            var originalCulture = CultureInfo.CurrentCulture;
//            try {
//                CultureInfo.CurrentCulture = EnglishCulture;
//                var heading = Resources.GetResource("N_Short", EnglishCulture);

//                // Act
//                var result = heading.FromAbbreviatedHeading(null);

//                // Assert
//                Assert.AreEqual(0.0, result, 0.01);
//            }
//            finally {
//                CultureInfo.CurrentCulture = originalCulture;
//            }
//        }

//        [TestMethod]
//        public void FromAbbreviatedHeading_InvalidHeading_ReturnsNegativeOne() {
//            // Arrange
//            var invalidHeadings = new[] { "INVALID", "XXX", "NOT_A_HEADING", "" };

//            // Act & Assert
//            foreach (var heading in invalidHeadings) {
//                Assert.AreEqual(-1, heading.FromAbbreviatedHeading(EnglishCulture),
//                    $"Invalid heading '{heading}' should return -1");
//            }
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void FromAbbreviatedHeading_NullHeading_ThrowsArgumentNullException() {
//            // Act
//            string nullHeading = null;
//            nullHeading.FromAbbreviatedHeading(EnglishCulture);
//        }
//    }
//}