using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] englishLetters =
            {
                'a','b','c','d','e','f','g','h','i','j',
                'k','l','m','n','o','p','q','r','s','t',
                'u','v','w','x','y','z'
            };

            char[] lettersArray = Console.ReadLine().ToLower().ToArray();

            for (int i = 0; i < lettersArray.Length; i++)
            {
                for (int j = 0; j < englishLetters.Length; j++)
                {
                    if (lettersArray[i] == englishLetters[j])
                    {
                        Console.WriteLine($"{lettersArray[i]} -> {j}");
                    }
                }
            }
        }
    }
}
