using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello my bot!");
            string str = "z";
            string str2 = "Z";

            Console.WriteLine("Here is {0}, again is {1}", str, str2);

            OperatorExamples();
        }
        private static void OperatorExamples()
        {
            int width = 10;
            width++;

            int height = 5;
            int area = height * width;

            string result = "Area";
            result = result + " is " + area;

            Console.WriteLine(result);
        }
    }
}
