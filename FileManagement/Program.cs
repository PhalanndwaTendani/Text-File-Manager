using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream strm = new FileStream("Questions.txt", FileMode.Create, FileAccess.Write);
            StreamWriter f = new StreamWriter(strm);
            Console.Write("What is your question?");
            string sText = Console.ReadLine();
            f.Write(sText);
            f.Close();
            strm.Close();
            Console.Write("Do you want to see your question? (Y/N)");
            string sInput = Console.ReadLine().ToUpper();

            if (sInput =="Y")
            {
                FileStream str = new FileStream("Questions.txt", FileMode.Open, FileAccess.Read);
                StreamReader s = new StreamReader(str);
                Console.Write("Your question is: " + s.ReadToEnd());
                str.Close();
                s.Close();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
            Console.ReadKey();
        }
    }
}
