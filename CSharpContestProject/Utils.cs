using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpContestProject
{
    public static class Utils
    {
        public static void LocalPrint(string s)
        {
            Console.WriteLine(s);
        }

        public static void LocalPrintArray(IEnumerable<string> s)
        {
            Console.WriteLine(String.Join(" ", s));
        }
    }
}
