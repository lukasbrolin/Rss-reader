using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Models;

namespace DAL
{
    internal class DataManager
    {
        public void Serialize<T>(List<T> objects, string c)
        {
            
            //string xmlName = (objects.LastOrDefault().ToString().Split('.')[1]) + ".xml";
            XmlSerializer xmlSerializer = new XmlSerializer(objects.GetType());
            using (FileStream outFile = new FileStream(c, FileMode.Open,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, objects);
            }
        }

        public void Serialize(string c)
        {
            //using (FileStream outFile = new FileStream(c, FileMode.Create,
            //    FileAccess.Write))
            //var sampleText = "";
            //XmlSerializer xmlSerializer = new XmlSerializer("".GetType());
            using (FileStream outFile = new FileStream(c, FileMode.Create))
            {
                //xmlSerializer.Serialize(outFile, sampleText);
            }

        }

        public void SerializeDelete(string c)
        {
            File.Delete(c);
        }

        /*public List<T> Deserialize<T>(List<T> objectList, string value)
        {
            string xmlName = value + ".xml";
            List<T> listOfObjectToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream inFile = new FileStream(xmlName, FileMode.Open,
                FileAccess.Read))
            {
                listOfObjectToBeReturned = (List<T>)xmlSerializer.Deserialize(inFile);
            }
            return listOfObjectToBeReturned;
        }*/

        public List<Podcast> Deserialize<T>(string value)
        {
            try
            {
                string xmlName = value;
                List<Podcast> listOfObjectToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream(xmlName, FileMode.Open,
                    FileAccess.Read))
                {
                    listOfObjectToBeReturned = (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
                return listOfObjectToBeReturned;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
                return null;
            }
        }
    }
}