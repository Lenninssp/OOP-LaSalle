using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace WinFormsSchoolLibraryV3.bus
{
    public class FileManager
    {
        private static String xmlFilePath = @"../../../data/library.xml";

        public static void WriteToXmlFile(List<Book> listOfBooks)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            xmlSerializer.Serialize(xmlWriter, listOfBooks);
            xmlWriter.Close();
        }

        public static List<Book> ReadFromXmlFile()
        {
            List<Book> listFromFile = new List<Book>();

            StreamReader streamReader = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

            listFromFile = (List<Book>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            return listFromFile;

        }


    }
}
