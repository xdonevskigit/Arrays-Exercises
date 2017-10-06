using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotateCount = int.Parse(Console.ReadLine());
            int[] sumArr = new int[arr.Length];

            while (rotateCount > 0)
            {
                int temp = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i >= 1; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = temp;

                for (int i = 0; i < arr.Length; i++)
                {
                    sumArr[i] = sumArr[i] + arr[i];
                }

                rotateCount--;
            }

            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
