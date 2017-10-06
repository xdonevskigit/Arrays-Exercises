using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //bullshit method
            WriteAPrimeNumber(number);
        }

        static void WriteAPrimeNumber(int number)
        {
            int[] array = new int[number];
            int count = 0;
            
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    array[count] = i;
                       count++;
                }
                              
            }
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    count++;
                }
            }
            int[] primeArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                primeArr[i] = array[i];
            }
          Console.WriteLine(String.Join(" ", primeArr));
        }
    }
}
