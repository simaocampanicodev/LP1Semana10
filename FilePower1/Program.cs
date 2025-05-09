using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string filePath = args[0];
            Queue<string> strings = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                strings.Enqueue(input);
            }
            
            File.WriteAllLines(filePath, strings);
        }
    }
}