using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;

namespace DAL
{
    internal class DataManager
    {
        public void Serialize<T>(List<T> podcasts)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(podcasts.GetType());
            using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create,
                FileAccess.Write))
            {

                /* string x = cars[0].GetType().ToString();
                string[] xy = x.Split('.');
                Console.WriteLine(xy[1] + "s"); */

                xmlSerializer.Serialize(outFile, podcasts);
            }


        }

        public List<Podcast> Deserialize()
        {

            List<Podcast> listOfPodcastsToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                FileAccess.Read))
            {
                listOfPodcastsToBeReturned = (List<Podcast>)xmlSerializer.Deserialize(inFile);
            }
            return listOfPodcastsToBeReturned;


        }

        public List<Categories> Deserialize<T>()
        {

            List<Categories> listOfCarsToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream inFile = new FileStream("Cars.xml", FileMode.Open,
                FileAccess.Read))
            {
                listOfCarsToBeReturned = (List<Categories>)xmlSerializer.Deserialize(inFile);
            }
            return listOfCarsToBeReturned;


        }
    }
}