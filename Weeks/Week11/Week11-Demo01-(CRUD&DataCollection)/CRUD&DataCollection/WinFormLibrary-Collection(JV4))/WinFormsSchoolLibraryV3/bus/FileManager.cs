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

        public static void WriteToXmlFile(List<Item> listOfItems)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Item>));

            xmlSerializer.Serialize(xmlWriter, listOfItems);

            xmlWriter.Close();
        }

        public static List<Item> ?    ReadFromXmlFile()
        {
            List<Item> ? listFromFile = new List<Item>();

            StreamReader streamReader = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Item>));          

            listFromFile = (List<Item>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            if (listFromFile != null)
                return listFromFile;
                     else return null;
   
        }


    }
}
