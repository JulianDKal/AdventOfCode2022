using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Reflection;

public class Day6
{
    public static void PartOne(string inputFileLocation)
    {
        string input = File.ReadAllText(inputFileLocation);
        char[] lastFourCharacters = new char[4];
        for (int i = 0; i < input.Length; i++)
        {
            lastFourCharacters = input.Substring(i, 4).ToCharArray();
            char[] afterSorting = lastFourCharacters.Distinct<char>().ToArray();
            if (afterSorting.Length < 4) continue;
            Console.WriteLine(i+4);
            break;
        }

    }

    public static void PartTwo(string inputFileLocation)
    {
        string input = File.ReadAllText(inputFileLocation);
        char[] lastFourteenCharacters = new char[14];
        for (int i = 13; i < input.Length; i++)
        {
            lastFourteenCharacters = input.Substring(i, 14).ToArray();
            char[] afterSorting = lastFourteenCharacters.Distinct<char>().ToArray();
            if (afterSorting.Length != 14) continue;
            Console.WriteLine(i + 14);
            break;
        }
    }
}

