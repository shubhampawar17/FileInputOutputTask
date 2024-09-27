using FileInputOutputTask.model;

namespace FileInputOutputTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your username:");
            string name = Console.ReadLine();

            TextFile.WriteTextFile();
            TextFile.ReadTextFile();
            TextFile.AppendTextFile(name);

            HtmlFile.WriteHtmlFile();
            HtmlFile.ReadHtmlFile();
            HtmlFile.AppendHtmlFile(name);

            XmlFile.WriteXmlFile();
            XmlFile.ReadXmlFile();
            XmlFile.AppendXmlFile(name);

            Console.WriteLine("Operations completed successfully.");
        }
    }
    
}
