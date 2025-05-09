using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string filePath = args[0];
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input)) break;
                    sw.WriteLine(input);
                }
            }
            
        }
    }
}