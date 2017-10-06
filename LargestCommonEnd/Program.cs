using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(' ').ToArray();
            string[] secondLine = Console.ReadLine()
                .Split(' ').ToArray();
            WriteLaegestCommonString(firstLine, secondLine);

        }

        static void WriteLaegestCommonString(string[] firstLine, string[] secondLine)
        {
            int leftCount = 0;
            int rightCount = 0;

            while (rightCount < firstLine.Length && rightCount < secondLine.Length)
            {
                if (firstLine[firstLine.Length - 1 - rightCount] 
                    == secondLine[secondLine.Length - 1 - rightCount])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            while (leftCount < firstLine.Length && leftCount < secondLine.Length)
            {
                if (firstLine[leftCount] == secondLine[leftCount])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
