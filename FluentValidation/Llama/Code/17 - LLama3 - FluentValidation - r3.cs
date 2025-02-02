//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Validators;

//namespace UnitTests {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {
//		[TestMethod]
//		public void Init_WithValidScaleAndPrecision_UpdatesValidatorProperties() {
//			// Arrange
//			int scale = 2;
//			int precision = 5;
//			var validator = new ScalePrecisionValidator<int>(scale, precision);

//			// Act and Assert
//			Assert.AreEqual(scale, validator.Scale);
//			Assert.AreEqual(precision, validator.Precision);
//		}

//		[TestMethod]
//		public void Init_WithInvalidScale_ThrowsArgumentOutOfRangeException() {
//			// Arrange
//			int invalidScale = -1;
//			int precision = 5;
//			var validator = new ScalePrecisionValidator<int>(invalidScale, precision);

//			// Act and Assert
//			Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.Init(invalidScale, precision));
//		}

//		[TestMethod]
//		public void Init_WithInvalidPrecision_ThrowsArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 2;
//			int invalidPrecision = -1;
//			var validator = new ScalePrecisionValidator<int>(scale, invalidPrecision);

//			// Act and Assert
//			Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.Init(scale, invalidPrecision));
//		}

//		[TestMethod]
//		public void Init_WithPrecisionLessThanScale_ThrowsArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 5;
//			int precision = 2;
//			var validator = new ScalePrecisionValidator<int>(scale, precision);

//			// Act and Assert
//			Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.Init(scale, precision));
//		}

//		[TestMethod]
//		public void Init_WithZeroScale_ThrowsArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 0;
//			int precision = 5;
//			var validator = new ScalePrecisionValidator<int>(scale, precision);

//			// Act and Assert
//			Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.Init(scale, precision));
//		}

//		[TestMethod]
//		public void Init_WithZeroPrecision_ThrowsArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 2;
//			int precision = 0;
//			var validator = new ScalePrecisionValidator<int>(scale, precision);

//			// Act and Assert
//			Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.Init(scale, precision));
//		}
//	}
//}
