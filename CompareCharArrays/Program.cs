using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] someArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] someArrayTwo = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            int countOne = 0;
            int countTwo = 0;

            if (someArray.Length < someArrayTwo.Length)
            {
                countOne++;
            }
            else if (someArray.Length > someArrayTwo.Length)
            {
                countTwo++;
            }
            int minPoints = (Math.Min(someArray.Length, someArrayTwo.Length));
            for (int i = 0; i < Math.Min(someArray.Length, someArrayTwo.Length); i++)
            {
                if (someArray[i] < someArrayTwo[i])
                {
                    countOne += minPoints - i;
                    break;
                }
                else if (someArray[i] > someArrayTwo[i])
                {
                    countTwo += minPoints - i;
                    break;
                }
            }
            if (countOne > countTwo)
            {
                Console.WriteLine(String.Join("", someArray));
                Console.WriteLine(String.Join("", someArrayTwo));
            }
            else
            {
                Console.WriteLine(String.Join("", someArrayTwo));
                Console.WriteLine(String.Join("", someArray));
            }
           
        }
    }
}
