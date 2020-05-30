using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKG.Pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            var line1 = System.Console.ReadLine().Trim();
            var N = Int32.Parse(line1);
            for (var i = 0; i < N; i++)
            {
                str = System.Console.ReadLine().Trim();
                string str1 = new string(str.ToCharArray().Reverse().ToArray());
                if (str1 == str)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
