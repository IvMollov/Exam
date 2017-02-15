using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public  class ParseOperations
    {
       static MobilePhones results = new MobilePhones();
        static MobileAccessories accessoryReasults = new MobileAccessories();
        public static void Parse()
        {
            using (StreamReader reader = new StreamReader(@"D:\Projects\Exam\Task2\bin\Sample.txt"))
            {
                string line = "";
                char[] separators = new char[] { '(', ')', ' ', ',' };
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); 

                    //if (parts[0] == "AddPhone")
                    //{
                    //    results.AddPhone(parts[1], parts[2], Convert.ToDecimal(parts[3]));
                    //}
                    //if (parts[0] == "AddAccessory")
                    //{
                    //    StringBuilder title = new StringBuilder();
                    //    for (int i = 1; i < parts.Length - 2; i++)
                    //    {
                    //        title.Append(parts[i] + " ");

                    //    }
                       
                    //    accessoryReasults.AddAccessory(title.ToString(), Convert.ToDecimal(parts[parts.Length - 1]));
                    //}
                    if (parts[0] == "PrintAccesories")
                    {
                        accessoryReasults.PrintAccessory();
                    }

                }
                //return inequalities;
            }
        }
        }
}
