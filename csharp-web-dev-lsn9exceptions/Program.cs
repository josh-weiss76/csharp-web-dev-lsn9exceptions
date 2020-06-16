using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
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
            try
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
                    throw new ArgumentNullException("No student submission");
                }
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("The student does not have a file submission in the system, check with student on status of project.");
                int pointValue = 0;
                return pointValue;
            }
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


            List<string> name = new List<string>();
            List<string> submission = new List<string>();
            foreach (string student in students.Keys)
            {
                name.Add(student);
            }
            foreach (string project in students.Values)
            {
                submission.Add(project);
            }
            for (int j = 0; j < name.Count; j++)
            {
                Console.WriteLine(name[j] + " : " + CheckFileExtension(submission[j]));
            }

        }
    }
}
