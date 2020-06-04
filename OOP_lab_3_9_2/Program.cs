using System;
using System.IO;

namespace OOP_lab_3_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("input.txt");

            string str = fromFile.ReadToEnd();

            string[] elements = str.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            int[] array = new int[elements.Length];

            int index = 0;

            foreach (string element in elements)
            {
                array[index] = element.Length;

                ++index;
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
