using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC2021.Days
{
    public class Day1 : Base
    {
        string inputTxt = System.IO.File.ReadAllText(@"../../../Inputs/Input1.txt");
        List<int> input = new List<int>();
        public Day1()
        {
            input = inputTxt.Split('\n').Select(int.Parse).ToList();
        }
        public override void Part1()
        {
            var count = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i -1] < input[i])
                {
                    count++;
                }
            }

            Console.WriteLine("amount of increased measurements is " + count);
        }

        public override void Part2()
        {
            var count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (i + 3 < input.Count)
                {
                    var sumA = input[i] + input[i + 1] + input[i + 2];

                    var sumB = input[i + 1] + input[i + 2] + input[i + 3];
                    if (sumA < sumB)
                    {
                        count++;
;                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
