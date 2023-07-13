using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Day3
{
    public static void PartOne(string inputFileLocation)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        alphabet += alphabet.ToUpper();

        Dictionary<char, int> alphabetDictionary = new Dictionary<char, int>();
        for (int i = 1; i <= alphabet.Length; i++)
        {
            alphabetDictionary.Add(alphabet[i - 1], i);
        }

        string[] input = File.ReadAllLines(inputFileLocation);
        int sum = 0;

        string firstString = "";
        string secondString = "";

        for (int i = 0; i < input.Length; i++)
        {
            firstString = input[i].Substring(0,input[i].Length / 2);
            secondString = input[i].Substring(input[i].Length / 2, input[i].Length / 2);

            char doubleChar = firstString.Where(x => secondString.Contains(x)).First();
            sum += alphabetDictionary[doubleChar];
        }

        Console.WriteLine(sum);
    }

    public static void PartTwo(string inputFileLocation)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        alphabet += alphabet.ToUpper();

        Dictionary<char, int> alphabetDictionary = new Dictionary<char, int>();
        for (int i = 1; i <= alphabet.Length; i++)
        {
            alphabetDictionary.Add(alphabet[i - 1], i);
        }

        string[] input = File.ReadAllLines(inputFileLocation);
        int sum = 0;

        string firstString = "";
        string secondString = "";
        string thirdString = "";

        for (int i = 1; i <= input.Length; i++)
        {
            if (i % 3 == 1) firstString = input[i - 1];
            else if (i % 3 == 2) secondString = input[i - 1];
            else if (i % 3 == 0)
            {
                thirdString = input[i - 1];
                foreach (char character in firstString)
                {
                    if (secondString.Contains(character) && thirdString.Contains(character))
                    {
                        sum += alphabetDictionary[character];
                        break;
                    }
                }
            }
        }
        Console.WriteLine(sum);
    }
}

