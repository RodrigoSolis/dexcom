using System;
namespace Dexcom.Test.ProblemsTests
{
	public class Problem1Tests
	{
		[Fact]
    public void Pass_An_Empty_Array_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = Array.Empty<int>();

			// Act
      var result = operations.FindMissingNumbersInArray(numbers);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
		public void Pass_An_Array_With_A_Complete_Sequence_Should_Return_An_Empty_Array()
		{
			// Arrange
			var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] { 1, 2, 3, 4, 5 };

			// Act
      var result = operations.FindMissingNumbersInArray(numbers);

			// Assert
      Assert.Empty(result);
		}

		[Fact]
		public void Pass_An_Array_With_A_Missing_Numbers_In_Range_Should_Return_An_Array_With_2_Elements()
		{
			// Arrange
			var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] { 1, 4, 5, 6, 7 };

			// Act
      var result = operations.FindMissingNumbersInArray(numbers);

			// Assert
      Assert.NotEmpty(result);
			Assert.True(result.Length == 2);
			Assert.Contains(2, result);
			Assert.Contains(3, result);
		}

		[Fact]
		public void Pass_An_Array_With_A_Missing_Numbers_In_Range_Should_Return_An_Array_With_4_Elements()
		{
			// Arrange
			var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] { 3, 2, 2, 8, 1, 9, 10, 3 };

			// Act
      var result = operations.FindMissingNumbersInArray(numbers);

			// Assert
      Assert.NotEmpty(result);
			Assert.True(result.Length == 4);
			Assert.Contains(4, result);
			Assert.Contains(5, result);
			Assert.Contains(6, result);
			Assert.Contains(7, result);
		}
	}
}

