using System;
using System.IO;
using System.Text;
namespace Read_File_line_by_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            var lines = File.ReadLines(@"C:\Users\magda\Desktop\ListOfPersons.txt", Encoding.ASCII);
            foreach (var line in lines)
            {
                Console.WriteLine(" {0} ", String.IsNullOrEmpty(line) ? "<>" : line);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
