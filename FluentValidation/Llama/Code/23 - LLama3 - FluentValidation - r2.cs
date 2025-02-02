//using FluentValidation;
//using FluentValidation.TestHelper;
//using Xunit;

//public class MemberNameValidatorSelectorTests {
//	[Fact]
//	public void CanExecute_TypicalCase_ExecutesValidator() {
//		// Arrange
//		var memberNames = new[] { "Orders[].Name", "Orders[].Amount" };
//		var validatorSelector = new MemberNameValidatorSelector(memberNames);
//		var rule = new IncludeRule<string>(new StringLengthValidator(), _ => CascadeMode.Always);
//		var context = new ValidationContext<string>("Hello");

//		// Act
//		var result = validatorSelector.CanExecute(rule, "Orders[].Name", context);

//		// Assert
//		Assert.True(result);
//	}

//	[Fact]
//	public void CanExecute_InvalidMemberName_DoesNotExecuteValidator() {
//		// Arrange
//		var memberNames = new[] { "Orders[].Name", "Orders[].Amount" };
//		var validatorSelector = new MemberNameValidatorSelector(memberNames);
//		var rule = new IncludeRule<string>(new StringLengthValidator(), _ => CascadeMode.Always);
//		var context = new ValidationContext<string>("Hello");

//		// Act
//		var result = validatorSelector.CanExecute(rule, "Invalid.Name", context);

//		// Assert
//		Assert.False(result);
//	}

//	[Fact]
//	public void CanExecute_CollectionIndex_NormalizesPropertyPath() {
//		// Arrange
//		var memberNames = new[] { "Orders[].Name" };
//		var validatorSelector = new MemberNameValidatorSelector(memberNames);
//		var rule = new IncludeRule<string>(new StringLengthValidator(), _ => CascadeMode.Always);
//		var context = new ValidationContext<string>("Hello");

//		// Act
//		var result = validatorSelector.CanExecute(rule, "Orders[0].Name", context);

//		// Assert
//		Assert.True(result);
//	}

//	[Fact]
//	public void CanExecute_ChildContext_CascadeEnabled_ExecutesValidator() {
//		// Arrange
//		var memberNames = new[] { "Orders[].Name" };
//		var validatorSelector = new MemberNameValidatorSelector(memberNames);
//		var rule = new IncludeRule<string>(new StringLengthValidator(), _ => CascadeMode.Always);
//		var context = new ValidationContext<string>("Hello");

//		// Act
//		var result = validatorSelector.CanExecute(rule, "Orders[].Name", context);

//		// Assert
//		Assert.True(result);
//	}

//	[Fact]
//	public void CanExecute_ChildContext_CascadeDisabled_DoesNotExecuteValidator() {
//		// Arrange
//		var memberNames = new[] { "Orders[].Name" };
//		var validatorSelector = new MemberNameValidatorSelector(memberNames);
//		var rule = new IncludeRule<string>(new StringLengthValidator(), _ => CascadeMode.Always);
//		var context = new ValidationContext<string>("Hello");
//		context.RootContextData[MemberNameValidatorSelector.DisableCascadeKey] = true;

//		// Act
//		var result = validatorSelector.CanExecute(rule, "Orders[].Name", context);

//		// Assert
//		Assert.False(result);
//	}
//}
