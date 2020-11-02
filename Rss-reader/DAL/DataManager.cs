using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;

namespace DAL
{
    internal static class DataManager
    {
        //Writes to file
        public static void Serialize<T>(List<T> objects, string c)
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
        public static void Serialize(string c)
        {
            using (FileStream outFile = new FileStream(c, FileMode.Create))
            {
            }
        }


        //Changes name of file
        public static void SerializeRename(string valueBefore, string value)
        {
            File.Move(valueBefore, value);
        }


        //Deletes file
        public static void SerializeDelete(string c)
        {
            File.Delete(c);
        }

        //Reads file
        public static List<Podcast> Deserialize<T>(string value)
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