using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("No files");
                    return;
                }
                
                HashSet<char> uniqueChars = new HashSet<char>();
                
                foreach (string fileName in args)
                {
                    ProcessFile(fileName, uniqueChars);
                }
                
                var sortedChars = uniqueChars.OrderBy(c => c).ToList();
                foreach (char c in sortedChars)
                {
                    Console.WriteLine(c);
                }
            }
            catch
            {
                Console.Error.WriteLine($"Error");
                Environment.Exit(1);
            }
        }

        private static void ProcessFile(string fileName, HashSet<char> uniqueChars)
        {
            if (!File.Exists(fileName))
            {
                Console.Error.WriteLine($"File does not exist");
                return;
            }
            
            string[] lines = File.ReadAllLines(fileName);
            
            for (int lineNum = 0; lineNum < lines.Length; lineNum++)
            {
                string line = lines[lineNum];
                
                if (string.IsNullOrEmpty(line))
                    continue;
                
                if (line.Length != 1)
                {
                    Console.Error.WriteLine($"A line has more than 1 char");
                    return;
                }
                
                uniqueChars.Add(line[0]);
            }
        }
    }
}