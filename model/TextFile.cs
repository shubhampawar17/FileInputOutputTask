using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputTask.model
{
    internal class TextFile
    {
        private static string filePath = "E:\\Monocept\\Mithril Task\\Task\\Task 1 26-09-24\\FileInputOutputTask\\SampleText.txt";

        public static void ReadTextFile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Text File Not Found");
                return;
            }
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }

        public static void WriteTextFile()
        {
            File.WriteAllText(filePath, "This is Writing Text File");
            Console.WriteLine("Writing to Text File");
        }

        public static void AppendTextFile(string namess)
        {
            
            string path = "E:\\Monocept\\Mithril Task\\Task\\Task 1 26-09-24\\FileInputOutputTask\\model\\TextDocument.txt";
            using (StreamWriter sw = new StreamWriter(path , true))
            {
                sw.WriteLine(namess);
            }
        }

    }
}

