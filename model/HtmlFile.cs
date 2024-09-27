using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputTask.model
{
    internal class HtmlFile
    {
         private static string filePath = "E:\\Monocept\\Mithril Task\\Task\\Task 1 26-09-24\\FileInputOutputTask\\SampleHtml.html";

            public static void ReadHtmlFile()
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("HTML file not found");
                    return;
                }
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }

            public static void WriteHtmlFile()
            {
                File.WriteAllText(filePath, "<html><body>This is Writing HTML file</body></html>");
                Console.WriteLine("Writing to HTML File");
            }

            public static void AppendHtmlFile(string name)
            {
                string content = File.Exists(filePath) ? File.ReadAllText(filePath) : "<html><body></body></html>";

                content = content.Replace("</body>", $"{name}<br /></body>");

                File.WriteAllText(filePath, content);
            }
        }
    }
