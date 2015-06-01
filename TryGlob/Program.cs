using IronRuby.Builtins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGlob
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            if (args.Length == 0) input = Console.ReadLine();
            else input = args[0];
            var results = Glob.GetMatches(input, 0);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
