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
                // Write basic HTML structure if the file doesn't exist
                File.WriteAllText(filePath, "<html><body>This is Writing HTML file</body></html>");
                Console.WriteLine("Writing to HTML File");
            }

            public static void AppendHtmlFile(string name)
            {
                // Read the existing content or create basic HTML if file doesn't exist
                string content = File.Exists(filePath) ? File.ReadAllText(filePath) : "<html><body></body></html>";

                // Append the new name just before the closing body tag
                content = content.Replace("</body>", $"{name}<br /></body>");

                // Write back the updated content to the file
                File.WriteAllText(filePath, content);
            }
        }
    }
