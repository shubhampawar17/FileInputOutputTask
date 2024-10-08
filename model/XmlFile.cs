﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileInputOutputTask.model
{
    internal class XmlFile
    {
        private static string filePath = "E:\\Monocept\\Mithril Task\\Task\\Task 1 26-09-24\\FileInputOutputTask\\SampleXml.xml";

        public static void ReadXmlFile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("XML file not found");
                return;
            }

            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }

        public static void WriteXmlFile()
        {
            File.WriteAllText(filePath, "<Users></Users>");
            Console.WriteLine("Writing to XML file");
        }

        public static void AppendXmlFile(string name)
        {
            XmlDocument doc = new XmlDocument();

            if (File.Exists(filePath))
            {
                doc.Load(filePath);
            }
            else
            {
                XmlElement root = doc.CreateElement("Users");
                doc.AppendChild(root);
            }
            XmlElement userElement = doc.CreateElement("User");
            userElement.InnerText = name;
            doc.DocumentElement.AppendChild(userElement);

            doc.Save(filePath);
        }
    }
}




