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
        //Writes to file
        public void Serialize<T>(List<T> objects, string c)
        {
            
            SerializeDelete(c);
            XmlSerializer xmlSerializer = new XmlSerializer(objects.GetType());
            using (FileStream outFile = new FileStream(c, FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, objects);
            }
        }


        //Creates new file
        public void Serialize(string c)
        {
            using (FileStream outFile = new FileStream(c, FileMode.Create))
            {
            }
        }


        //Changes name of file
        public void SerializeRename(string valueBefore, string value)
        {
            File.Move(valueBefore, value);
        }


        //Deletes file
        public void SerializeDelete(string c)
        {
            File.Delete(c);
        }

        //Reads file
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
                return null;
            }
        }
    }
}