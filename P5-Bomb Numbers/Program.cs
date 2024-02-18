using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] == bombNumber)
            {
                int start = Math.Max(0, i - bombPower);
                int end = Math.Min(sequence.Count - 1, i + bombPower);

                sequence.RemoveRange(start, end - start + 1);
                i = start - 1;
            }
        }

        Console.WriteLine(sequence.Sum());
    }
}
