using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Day1
{
    public static void PartOne(string inputFileLocation)
    {
        Dictionary<int, int> elfDictionary = new Dictionary<int, int>()
        {
            {0,0 }
        };
        List<int> caloriesList = new List<int>();
        int finalValue = 0;

        string[] input = File.ReadAllLines(inputFileLocation);
        int elfCount = 0;
        foreach (string item in input)
        {
            if (item != "")
            {
                elfDictionary[elfCount] += Convert.ToInt32(item);
            }
            else
            {
                caloriesList.Add(elfDictionary[elfCount]);
                elfCount++;
                elfDictionary.Add(elfCount, 0);
            }
        }

        finalValue = caloriesList.Max();

        Console.WriteLine(finalValue);
        Console.Read();
    }

    public static void PartTwo(string inputFileLocation)
    {
        Dictionary<int, int> elfDictionary = new Dictionary<int, int>()
        {
            {0,0 }
        };
        List<int> caloriesList = new List<int>();
        int topThree = 0;

        string[] input = File.ReadAllLines(@inputFileLocation);
        int elfCount = 0;
        foreach (string item in input)
        {
            if (item != "")
            {
                elfDictionary[elfCount] += Convert.ToInt32(item);
            }
            else
            {
                caloriesList.Add(elfDictionary[elfCount]);
                elfCount++;
                elfDictionary.Add(elfCount, 0);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            topThree += caloriesList.Max();
            caloriesList.Remove(caloriesList.Max());
        }

        Console.WriteLine(topThree);
        Console.Read();
    }
}