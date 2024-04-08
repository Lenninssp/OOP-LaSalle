using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace CounterApp.bus
{
    public class FileManager
    {
        private static String xmlFilePath = @"../../../data/library.xml";

        public static void WriteToXMLFile(List<Counter> listOfCounters)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Counter>), new Type[] { typeof(StepCounter), typeof(ModuloNCounter) });
            xmlSerializer.Serialize(xmlWriter, listOfCounters);
            xmlWriter.Close();
        }



        public static List<Counter> ReadFromXMLFile()
        {
            List<Counter> listFromFile = null;

            using (StreamReader streamReader = new StreamReader(xmlFilePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Counter>), new Type[] { typeof(StepCounter), typeof(ModuloNCounter) });
                listFromFile = (List<Counter>)xmlSerializer.Deserialize(streamReader);
            }

            return listFromFile;
        }


    }
}
