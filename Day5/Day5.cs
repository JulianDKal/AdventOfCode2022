using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Day5
{
    public static void PartOne(string inputFileLocation)
    {
        string[] input = File.ReadAllLines(inputFileLocation);
        Stack<char>[] stacks = new Stack<char>[9];
        for (int i = 0; i < stacks.Length; i++)
        {
            stacks[i] = new Stack<char>();
        }
        //filling up the stacks
        int counter = 0;
        string line = "";
        for (int i = 7; i >= 0; i--)
        {
            line = input[i];
            for (int j = 1; j < line.Length; j += 4)
            {
                char charToPush = line[j];
                if (charToPush != ' ') stacks[counter].Push(charToPush);
                counter++;
            }
            counter = 0;
        }

        int startCrate;
        int destinationCrate;
        int amountToMove;

        for (int i = 10; i < input.Length; i++)
        {
            MatchCollection numbers = Regex.Matches(input[i], @"\d+");

            amountToMove = int.Parse(numbers[0].Groups[0].Value);
            startCrate = int.Parse(numbers[1].Groups[0].Value);
            destinationCrate = int.Parse(numbers[2].Groups[0].Value);

            for (int j = 0; j < amountToMove; j++)
            {
                stacks[destinationCrate - 1].Push(stacks[startCrate - 1].Peek());
                stacks[startCrate - 1].Pop();
            }
        }
        string result = "";
        foreach (var item in stacks)
        {
            result += item.Peek();
        }
        Console.WriteLine(result);
    }

    public static void PartTwo(string inputFileLocation)
    {
        string[] input = File.ReadAllLines(inputFileLocation);
        Stack<char>[] stacks = new Stack<char>[9];
        for (int i = 0; i < stacks.Length; i++)
        {
            stacks[i] = new Stack<char>();
        }
        //filling up the stacks
        int counter = 0;
        string line = "";
        for (int i = 7; i >= 0; i--)
        {
            line = input[i];
            for (int j = 1; j < line.Length; j += 4)
            {
                char charToPush = line[j];
                if (charToPush != ' ') stacks[counter].Push(charToPush);
                counter++;
            }
            counter = 0;
        }

        int startCrate;
        int destinationCrate;
        int amountToMove;

        for (int i = 10; i < input.Length; i++)
        {
            MatchCollection numbers = Regex.Matches(input[i], @"\d+");

            startCrate = int.Parse(numbers[1].Groups[0].Value);
            destinationCrate = int.Parse(numbers[2].Groups[0].Value);
            amountToMove = int.Parse(numbers[0].Groups[0].Value);

            Stack<char> stackToPush = new Stack<char>();

            for (int j = 0; j < amountToMove; j++)
            {
                stackToPush.Push(stacks[startCrate - 1].Peek());
                stacks[startCrate - 1].Pop();

            }
            foreach (char item in stackToPush)
            {
                stacks[destinationCrate - 1].Push(item);
            }
        }
        string result = "";
        for (int i = 0; i < stacks.Length; i++)
        {
            result += stacks[i].Peek();
        }
        Console.WriteLine(result);
    }
}

