using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

/*******
 * Read input from Console
 * Use Console.WriteLine to output your result.
 * Use:
 *       Utils.LocalPrint( variable); 
 * to display simple variables in a dedicated area.
 * 
 * Use:
 *      
		Utils.LocalPrintArray( collection)
 * to display collections in a dedicated area.
 * ***/

namespace CSharpContestProject
{
    public class Program
    {
        public const string FilePath = @"C:\Users\Adrien\Downloads\sample-X90wf5Qq7VOBQNMCXGALtlng7tJXdc4Mb97Dmf5BrWg\input1.txt";

        static void Main(string[] args)
        {
            string line;
            var input = new List<string>();
            while ((line = Console.ReadLine()) != null)
            {
                input.Add(line);
            }
            Solution(input);
        }

        public static void Solution(List<string> input)
        {
        }
    }
}