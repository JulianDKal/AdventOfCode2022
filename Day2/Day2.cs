using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public class Day2
{
    class ShapeClass
    {
        private int returnWinnerNumber(int input)
        {
            if ((input + 1) <= 2) return input + 1;
            else return 0;
        }

        private int returnLoserNumber(int input)
        {
            if ((input - 1) >= 0) return input - 1;
            else return 2;
        }

        public int shapeToBePlayed(int theirShape, int outcome)
        {
            if (outcome == 1) return theirShape;
            else if (outcome == 0) return returnLoserNumber(theirShape);
            else if (outcome == 2) return returnWinnerNumber(theirShape);
            else return -1;
        }
    }

    public static void PartOne(string inputFileLocation)
    {
        string[] input = File.ReadAllLines(inputFileLocation);
        int points = 0;
        foreach (string line in input)
        {
            switch (line)
            {
                case "A X":
                    points += 4;
                    break;
                case "A Y":
                    points += 8;
                    break;
                case "A Z":
                    points += 3;
                    break;
                case "B X":
                    points += 1;
                    break;
                case "B Y":
                    points += 5;
                    break;
                case "B Z":
                    points += 9;
                    break;
                case "C X":
                    points += 7;
                    break;
                case "C Y":
                    points += 2;
                    break;
                case "C Z":
                    points += 6;
                    break;
            }
        }

        Console.WriteLine(points);
    }

    public static void PartTwo()
    {
        
        string[] input = File.ReadAllLines(@"C:\Users\Julian\Dropbox\Work in Progress\AdventOfCode\AdventOfCode\res\rockPaperScissorsInput.txt");
        int points = 0;
        List<char> shapesToAnswer = new List<char>()
            {
                'Z','X','Y','X','Y','Z','Y','Z','X'
            };
        Dictionary<char, int> translator_abc = new Dictionary<char, int>()
            {
                //translating a,b and c to 0,1 and 2
                {'A',0 },
                {'B',1 },
                {'C',2 }
            };

        Dictionary<char, int> translator_xyz = new Dictionary<char, int>()
            {
                //translating x,y and z to 0,1 and 2
                {'X',0 },
                {'Y',1 },
                {'Z',2 }
            };
        ShapeClass newShapeClass = new ShapeClass();


        foreach (string item in input)
        {
            int shapeToPlay = newShapeClass.shapeToBePlayed(translator_abc[item[0]], translator_xyz[item[2]]);
            string newItem = item[0] + " " + translator_xyz.FirstOrDefault(x => x.Value == shapeToPlay).Key;

            switch (newItem)
            {
                case "A X":
                    points += 4;
                    break;
                case "A Y":
                    points += 8;
                    break;
                case "A Z":
                    points += 3;
                    break;
                case "B X":
                    points += 1;
                    break;
                case "B Y":
                    points += 5;
                    break;
                case "B Z":
                    points += 9;
                    break;
                case "C X":
                    points += 7;
                    break;
                case "C Y":
                    points += 2;
                    break;
                case "C Z":
                    points += 6;
                    break;
            }
        }
        Console.WriteLine(points);
    }
}

