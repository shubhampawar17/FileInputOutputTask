using FileInputOutputTask.model;

namespace FileInputOutputTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example username input
            Console.Write("Enter your username: ");
            string name = Console.ReadLine();

            // Text file operations
            TextFile.WriteTextFile();
            TextFile.ReadTextFile();
            TextFile.AppendTextFile(name);

            // HTML file operations
            HtmlFile.WriteHtmlFile();
            HtmlFile.ReadHtmlFile();
            HtmlFile.AppendHtmlFile(name);

            // XML file operations
            XmlFile.WriteXmlFile();
            XmlFile.ReadXmlFile();
            XmlFile.AppendXmlFile(name);

            Console.WriteLine("Operations completed successfully.");
        }
    }
    
}
