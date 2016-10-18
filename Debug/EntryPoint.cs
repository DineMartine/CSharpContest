using System;
using System.Collections.Generic;
using System.IO;
using CSharpContestProject;

namespace Debug
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            var file = new FileStream(Program.FilePath, FileMode.Open);
            var stream = new StreamReader(file);
            var input = new List<string>();
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                input.Add(line);
            }
            Program.Solution(input);
            Console.ReadKey();
        }
    }
}
