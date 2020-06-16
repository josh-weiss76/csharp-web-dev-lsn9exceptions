using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            try
            {
                if (y != 0)
                {
                    double result = x / y;
                    return result;
                }
                throw new ArgumentOutOfRangeException("Cannot divide by zero");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot divide by zero, check your input and rerun program");
                double fail = 0;
                return fail;
            }
            

        }

        static int CheckFileExtension(string fileName)
        {
            int result = 0;
            return result;// Write your code here!
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double test1 = Divide(8, 2);
            Console.WriteLine(test1);
            double test2 = Divide(8,0);
            Console.WriteLine(test2);
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
