using System;
using System.IO;
using System.Text;

namespace Excercise_3_2
{
    class Program
    {



static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText); // Create a file and write the content of writeText to it


            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content


            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}
