using System;
using System.IO;
namespace Read_File_line_by_line
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"C:\Users\magda\Desktop\ListOfPersons.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(" {0} ", String.IsNullOrEmpty(line) ? "<>" : line);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
