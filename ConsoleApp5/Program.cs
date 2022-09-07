using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[4] { "Hello", "2", "world", ":-D" };
            string[] array2 = new string[array1.Length];

            void CreateResultArray(string[] arr1, string[] arr2)
            {
                int count = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length <= 3)
                    {
                        array2[count] = array1[i];
                        count++;
                    }
                }
            }

            void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
