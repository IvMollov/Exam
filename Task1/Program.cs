using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            List<string> result = ParseInequalities.Parse(x);

            Console.WriteLine("\nCount of inequalities is: {0}", result.Count);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
                
         
            Console.ReadLine();
        }
    }
}
