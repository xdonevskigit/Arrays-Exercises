using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int oneFourth = array.Length / 4;
            int[] middle = new int[oneFourth * 2];

            for (int i = 0; i < oneFourth * 2; i++)
            {
                middle[i] = array[oneFourth + i];
            }

            int[] leftAndRight = new int[oneFourth * 2];
            
            for (int i = 0,j = oneFourth - 1; i < j ; j--, i++)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            for (int i = 0; i < oneFourth; i++)
            {
                leftAndRight[i] = array[i];
            }

            for (int i = oneFourth * 3, j = array.Length - 1; i < j ;j--, i++)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            for (int i = oneFourth; i < oneFourth * 2; i++)
            {
                leftAndRight[i] = array[oneFourth * 2 + i];
            }

            int[] sumFoldenArray = new int[oneFourth * 2];
            for (int i = 0; i < oneFourth * 2; i++)
            {
                sumFoldenArray[i] = middle[i] + leftAndRight[i];
            }
            Console.WriteLine(String.Join(" ", sumFoldenArray));

            
        }
    }
}
