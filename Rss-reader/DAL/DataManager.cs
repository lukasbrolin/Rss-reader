using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Models;

namespace DAL
{
    internal class DataManager
    {
        public void Serialize<T>(List<T> objects)
        {
            string xmlName = (objects.LastOrDefault().ToString().Split('.')[1]) + ".xml";
            XmlSerializer xmlSerializer = new XmlSerializer(objects.GetType());
            using (FileStream outFile = new FileStream(xmlName, FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, objects);
            }
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

    public class UrlManager
    {
        public XDocument urlManager = new XDocument();


        public List<Episode> GetEpisodes(string url)
        {
            List<Episode> episodeList = new List<Episode>();
            urlManager = XDocument.Load(url);
            episodeList = (from item in urlManager.Descendants("item")
                select new Episode
                {
                    Title = item.Element("title").Value,
                    Description = item.Element("description").Value
                }).ToList();
            return episodeList;
        }

        public int GetTotalEpisodes(string url)
        {
            urlManager = XDocument.Load(url);
            var items = from e in urlManager.Descendants("item") 
                                        select new { title = e.Element("title")};
            
            int totalEpisodes = items.Count();
            return totalEpisodes;
        }
    }
}