using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BikeStoreMngtBusiness;


namespace BikeStoreMngtData
{
    public class FileManager
    {
        private static string xmlFilePath = @"C:\Users\lenni\Developer\lasalle\OOP-LaSalle\Projects\BikeStorePart3\BikeStoreMngtData\BikeStoreMngtData\bikes.xml"; 
        //private static string xmlFilePath = @"..\..\..\bikes.xml";


        public static void SerializeToXMLFile(List<Bike> listOfBikes)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>), new Type[] { typeof(Mountain), typeof(Road) });
            xmlSerializer.Serialize(xmlWriter, listOfBikes);
            xmlWriter.Close();
        }

        public static List<Bike>? DeserializeFromXmlFile()
        {
            List<Bike>? listFromFile = new List<Bike>();

            StreamReader streamReader = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));

            listFromFile = (List<Bike>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            if (listFromFile != null)
                return listFromFile;
            else return null;
        }
    }
}


