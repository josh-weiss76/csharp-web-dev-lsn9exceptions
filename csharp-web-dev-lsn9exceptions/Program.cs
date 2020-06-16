using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y != 0)
            {
                 double result = x / y;
                 return result;
            }
            throw new ArgumentOutOfRangeException("y","Cannot divide by zero");
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName.Contains(".cs"))
            {
                int pointValue = 1;
                return pointValue;
            }
            else if (fileName != "")
            {
                int pointValue = 0;
                return pointValue;
            }
            else 
            {
                throw new ArgumentNullException("fileName","No student submission");
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double x = 8;
            double y = 0;
            double z = 4;
            Console.WriteLine(Divide(x, z));
            try
            {
                Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> student in students)
            { 
                try
                {
                    Console.WriteLine(student.Key + " : " + CheckFileExtension(student.Value));
                }
                catch(ArgumentNullException)
                { 
                    Console.WriteLine(student.Key + " does not have a file submission in the system, check with student on status of project.");
                }

            }
        }
    }
}
