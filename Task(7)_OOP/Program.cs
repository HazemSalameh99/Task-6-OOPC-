using System;
using System.IO;
using System.Linq;

namespace Task_7__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteToFile("my_information.txt", "Name: Hazem Salameh\nSpecialization: Web Developer\nAge: 24\nDescription: I work as a Web developer and enjoy coding.");


            ReadAndPrintFromFile("my_information.txt");
        }
        static void WriteToFile(string fileName, string content)
        {

            File.WriteAllText(fileName, content);
        }
        static void ReadAndPrintFromFile(string fileName)
        {

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


            int totalCharacters = string.Join("", lines).Replace(" ", "").Length;
            Console.WriteLine($"Total number of characters : {totalCharacters}");

            int totalWords = string.Join(" ", lines).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Total number of words : {totalWords}");
        }
    }
}
