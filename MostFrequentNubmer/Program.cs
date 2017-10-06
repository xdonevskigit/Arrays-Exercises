using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNubmer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int bestCount = 0;
            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            currentIndex = i;
                        }
                    }
                }
                count = 1;
            }
            Console.WriteLine(array[currentIndex]);
        }
    }
}
