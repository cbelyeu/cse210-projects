using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int input = -1;
        while (input != 0) {
            input = int.Parse(Console.ReadLine());
            if (input != 0) {
                numbers.Add(input);
            }
        }
        int largestNumber = 0;
        int mySum = 0;
        for (int i = 0; i<numbers.Count; i++) {
            if (numbers[i] > largestNumber) {
                largestNumber = numbers[i];
            }
            mySum += numbers[i];
        }
        float myAverage = (float)mySum / numbers.Count;
        Console.WriteLine($"The sum is: {mySum}");
        Console.WriteLine($"The average is: {myAverage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}