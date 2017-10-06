using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int getMax = 0;

            int endIndex = 0;
            int bestEnd = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    counter++;
                    endIndex = i + 1;
                    if (counter > getMax)
                    {
                        bestEnd = endIndex;
                        getMax = counter;
                    }
                }
                else
                {
                    counter = 1;
                    endIndex = 0;
                }
            }

            int[] result = new int[getMax];
            int count = 0;

            for (int i = getMax - 1; i >= 0; i--)
            {
                result[getMax - 1 - count] = array[bestEnd - count];
                count++;
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}

