using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookAuto
{
    public class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi, it is working");
            Console.WriteLine("hi, it is working");
            Console.WriteLine("hi, it is from Program");

            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + @"../../").FullName;
            Console.WriteLine(directory);
            directory = directory + "\\Results\\";

            Console.WriteLine(directory);
            //Append the html report file to current project path
            Console.WriteLine("   ");
            string reportPath = directory + "Reports\\myReport.html";
            Console.WriteLine(reportPath);

            Thread.Sleep(20000);
        }

    }
}
