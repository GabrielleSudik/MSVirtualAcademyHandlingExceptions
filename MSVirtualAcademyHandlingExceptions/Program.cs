using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyHandlingExceptions
{
    //walkthrough of how exception handling works
    //you did some in IT1050 too. check it out.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
                //if you hover your mouse over the method (ReadAllText)
                //you'll get a list of all possible exceptions. nice.
                //you can look them up to see what they mean
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
            }

            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory C:\Lesson22 exists.");
                //there's a nice trick: looks like the @ symbol
                //allows some(?) special symbols inside the quotes
            }

            catch (Exception ex)
            //"exception" is the most general kind of exception
            //this will catch whatever the more specific ones miss
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                //this wraps up whatever exception was caught
                //and gives final instructions or whatever
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();
        }
    }
}
