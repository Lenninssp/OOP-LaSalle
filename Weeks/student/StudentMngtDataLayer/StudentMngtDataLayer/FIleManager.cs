using System.Net.NetworkInformation;
using System.Xml;
using System.Xml.Serialization;
using StudentMngtBusLayer;

namespace StudentMngtDataLayer
{
    public class FIleManager
    {
        private static string filePath = @"../../../studentList.xml";
        public static void Serialize(List<Student> listOfStudents)
        {
            XmlWriter xmlWriter = XmlWriter.Create(filePath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(xmlWriter, listOfStudents);
            xmlWriter.Close();

        }

        public static List<Student> Deserialize(){
            List<Student> listFromFile = new List<Student>();
            StreamReader streamReader = new StreamReader(filePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

            listFromFile = (List<Student>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            if(listFromFile != null)
            {
                return listFromFile;
            }
            else
            {
                return null;
            }
        }

    }
}
