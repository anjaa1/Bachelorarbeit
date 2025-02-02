//using FluentValidation.Validators;
//using FluentValidation.TestHelper;
//using FluentAssertions;
//using Xunit;

//public class EmptyValidatorTests {
//	[Fact]
//	public void IsValid_returns_true_for_null_value() {
//		// Arrange
//		var validator = new EmptyValidator<string, string>();
//		var context = new ValidationContext<string>("test");

//		// Act
//		var result = validator.IsValid(context, (string)null);

//		// Assert
//		result.Should().BeTrue();
//	}

//	[Fact]
//	public void IsValid_returns_true_for_empty_string() {
//		// Arrange
//		var validator = new EmptyValidator<string, string>();
//		var context = new ValidationContext<string>("test");

//		// Act
//		var result = validator.IsValid(context, string.Empty);

//		// Assert
//		result.Should().BeTrue();
//	}

//	[Fact]
//	public void IsValid_returns_true_for_empty_collection() {
//		// Arrange
//		var validator = new EmptyValidator<string, string[]>();
//		var context = new ValidationContext<string>("test");

//		// Act
//		var result = validator.IsValid(context, new string[0]);

//		// Assert
//		result.Should().BeTrue();
//	}

//	[Fact]
//    using System.Collections;
//    public void IsValid_returns_true_for_empty_enumerable() {
//	// Arrange
//	var validator = new EmptyValidator<string, IEnumerable<string>>();
//	var context = new ValidationContext<string>("test");

//	// Act
//	var result = validator.IsValid(context, new List<string>());

//	// Assert
//	result.Should().BeTrue();
//}

//[Fact]
//public void IsValid_returns_false_for_non_empty_string() {
//	// Arrange
//	var validator = new EmptyValidator<string, string>();
//	var context = new ValidationContext<string>("test");

//	// Act
//	var result = validator.IsValid(context, "test");

//	// Assert
//	result.Should().BeFalse();
//}

//[Fact]
//public void IsValid_returns_false_for_non_empty_collection() {
//	// Arrange
//	var validator = new EmptyValidator<string, string[]>();
//	var context = new ValidationContext<string>("test");

//	// Act
//	var result = validator.IsValid(context, new[] { "test" });

//	// Assert
//	result.Should().BeFalse();
//}

//[Fact]
//public void IsValid_returns_false_for_non_empty_enumerable() {
//	// Arrange
//	var validator = new EmptyValidator<string, IEnumerable<string>>();
//	var context = new ValidationContext<string>("test");

//	// Act
//	var result = validator.IsValid(context, new[] { "test" });

//	// Assert
//	result.Should().BeFalse();
//}

//[Fact]
//public void IsValid_returns_false_for_default_value() {
//	// Arrange
//	var validator = new EmptyValidator<string, string>();
//	var context = new ValidationContext<string>("test");

//	// Act
//	var result = validator.IsValid(context, default);

//	// Assert
//	result.Should().BeFalse();
//}
//}
