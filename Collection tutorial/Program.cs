using System;

namespace Collection_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileParser varible = new FileParser();

            var data = parser.Read("C:/Users/jlang/Documents/jacob/C#/data.txt"); C: \Users\jlang\Documents\jacob\C#

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.ReadKey();
        }
    }
}