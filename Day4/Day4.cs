using System;
using System.IO;

public class Day4
{
    public static void PartOne(string inputFileLocation)
    {
        string[] input = File.ReadAllLines(inputFileLocation);
        int result = 0;
        char[] splitCharacters = { ',', '-' };

        foreach (string item in input)
        {
            string[] ids = item.Split(splitCharacters);
            int[] numbers = new int[4];
            for (int i = 0; i < ids.Length; i++)
            {
                numbers[i] = Convert.ToInt32(ids[i]);
            }

            if (numbers[0] <= numbers[2] && numbers[1] >= numbers[3] || numbers[2] <= numbers[0] && numbers[3] >= numbers[1]) result++;
        }
        Console.WriteLine(result);
    }

    public static void PartTwo(string inputFileLocation)
    {
        string[] input = File.ReadAllLines(inputFileLocation);
        int result = 0;
        char[] splitCharacters = { ',', '-' };
        foreach (string item in input)
        {
            string[] ids = item.Split(splitCharacters);
            int[] numbers = new int[4];
            for (int i = 0; i < ids.Length; i++)
            {
                numbers[i] = Convert.ToInt32(ids[i]);
            }

            if ((numbers[2] >= numbers[0] && numbers[2] <= numbers[1]) || (numbers[3] >= numbers[0] && numbers[3] <= numbers[1]) || (numbers[0] >= numbers[2] && numbers[0] <= numbers[3]))
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}

