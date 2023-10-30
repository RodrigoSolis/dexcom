using System;
namespace Dexcom.Test.ProblemsTests
{
	public class Problem2Tests
	{
		[Fact]
    public void Pass_An_Empty_Array_And_Number_Zero_As_Target_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = Array.Empty<int>();
			int target = 0;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
    public void Pass_Number_Three_As_Target_And_An_Empty_Array_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = Array.Empty<int>();
			int target = 3;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
    public void Pass_Number_Zero_As_Target_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] {1, 2, 3, 4, 5 };
			int target = 0;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
    public void Pass_Number_Nine_As_Target_And_An_Array_With_No_Possible_Combinations_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] {1, 2, 3, 5 };
			int target = 9;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
    public void Pass_Number_Two_As_Target_And_An_Array_With_No_Possible_Combinations_Should_Return_An_Empty_Array()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] {1, 3, 4, 5 };
			int target = 2;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.Empty(result);
    }

		[Fact]
    public void Pass_Number_Six_As_Target_And_An_Array_With_Possible_Combinations_Should_Return_An_Array_With_The_Two_Indexes()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] {1, 2, 3, 4, 5 };
			int target = 6;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.NotEmpty(result);
			Assert.True(result.Length == 2);
			Assert.Contains(1, result);
			Assert.Contains(3, result);
    }

		[Fact]
    public void Pass_Number_Ten_As_Target_And_An_Array_With_Possible_Combinations_Should_Return_An_Array_With_The_Two_Indexes()
    {
			// Arrange
      var operations = new Bogus.Faker<Operations>()
        .Generate();

      int[] numbers = new int[] {1, 2, 3, 4, 5, 6 };
			int target = 10;

			// Act
      var result = operations.FindTwoIndexes(numbers, target);

			// Assert
      Assert.NotEmpty(result);
			Assert.True(result.Length == 2);
			Assert.Contains(5, result);
			Assert.Contains(3, result);
    }
	}
}

