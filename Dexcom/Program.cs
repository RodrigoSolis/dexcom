using Dexcom;

class Program
{
  public static void Main()
  {
    var operation = new Operations();
    // Problem 1
    int[] numbers1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
    Console.WriteLine("[{0}]", string.Join(", ", operation.FindMissingNumbersInArray(numbers1)));

    // Problem 2
    int[] numbers2 = {2, 7, 11, 15};
    var target = 9;

    Console.WriteLine("[{0}]", string.Join(", ", operation.FindTwoIndexes(numbers2, target)));

    Console.ReadKey();
  }
}