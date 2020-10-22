using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Models;

namespace DAL
{
    internal class DataManager
    {
        public void Serialize<T>(List<T> podcasts)
        {
            string xmlName = (podcasts.LastOrDefault().ToString().Split('.')[1]) + ".xml";
            XmlSerializer xmlSerializer = new XmlSerializer(podcasts.GetType());
            using (FileStream outFile = new FileStream(xmlName, FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, podcasts);
            }
        }

        public List<Podcast> DeserializePodcasts()
        {

            List<Podcast> listOfPodcastsToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream inFile = new FileStream("Podcast.xml", FileMode.Open,
                FileAccess.Read))
            {
                listOfPodcastsToBeReturned = (List<Podcast>)xmlSerializer.Deserialize(inFile);
            }
            return listOfPodcastsToBeReturned;


        }

        public List<Category> DeserializeCategories()
        {

            List<Category> listOfCategoriesToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream inFile = new FileStream("Category.xml", FileMode.Open,
                FileAccess.Read))
            {
                listOfCategoriesToBeReturned = (List<Category>)xmlSerializer.Deserialize(inFile);
            }
            return listOfCategoriesToBeReturned;


        }

        public List<T> Deserialize<T>(List<T> objectList, string value)
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
        }
    }
}