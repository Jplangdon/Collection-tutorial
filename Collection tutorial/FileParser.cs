using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_tutorial
{
    class FileParser : IFileParser
    {
       public string[] Read(string path)
        {

            var reader = new StreamReader(path);

           int arraySize = int.Parse(reader.ReadLine());

           string[] array = new string[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = reader.ReadLine();
            }

            reader.Close();

            reader.Dispose();

            return array;                
        }
    }
}
