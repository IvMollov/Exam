using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class ParseInequalities
    {
        public static List<string> Parse(int x)
        {
            List<string> inequalities = new List<string>();
            using (StreamReader reader = new StreamReader(@"D:\Projects\Exam\Task1\bin\Sample.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');

                    if (parts[1] == "=")
                    {
                        if (x == Convert.ToInt32(parts[2]))
                        {
                            inequalities.Add(line);
                        }
                    }
                    else if (parts[1] == ">=")
                    {
                        if (x >= Convert.ToInt32(parts[2]))
                        {
                            inequalities.Add(line);
                        }
                    }
                    else if (parts[1] == ">")
                    {
                        if (x > Convert.ToInt32(parts[2]))
                        {
                            inequalities.Add(line);
                        }
                    }
                    else if (parts[1] == "<")
                    {
                        if (x < Convert.ToInt32(parts[2]))
                        {
                            inequalities.Add(line);
                        }
                    }
                    else if (parts[1] == "<=")
                    {
                        if (x <= Convert.ToInt32(parts[2]))
                        {
                            inequalities.Add(line);
                        }
                    }

                }
                return inequalities;
            }
        }

    }
}
