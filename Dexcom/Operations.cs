using System;
namespace Dexcom
{
	public class Operations
	{
    public int[] FindMissingNumbersInArray(int[] numbers)
    {
      List<int> missingNumbers = new List<int>();

      for (var i = 1; i <= numbers.Length; i++)
      {
        // Add the current number if is not contained in the array
        if (!numbers.Contains(i)) missingNumbers.Add(i);
      }

      return missingNumbers.ToArray();
    }

    public int[] FindTwoIndexes(int[] numbers, int target)
    {
      // Create a dictionary to add seen numbers
      Dictionary<int, int> existingNumbers = new Dictionary<int, int>();

      for (var i = 0; i < numbers.Length; i++)
      {
        var neededNumber = target - numbers[i];

        // returns the current index and the index of the number seen if the value of the required number exists in the dictionary
        if (existingNumbers.ContainsKey(neededNumber)) return new int[] { existingNumbers[neededNumber], i };

        existingNumbers[numbers[i]] = i;
      }

      return Array.Empty<int>();
    }
  }
}

