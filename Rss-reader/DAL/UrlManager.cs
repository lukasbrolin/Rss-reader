using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using Models;

namespace DAL
{
    public static class UrlManager
    {
        public static XDocument urlManager = new XDocument();


        public static List<Episode> GetEpisodes(string url)
        {
            List<Episode> episodeList = new List<Episode>();
            urlManager = XDocument.Load(url);
            return urlManager.Descendants(("item")).Select(i =>
            {
                XNamespace xd = "http://www.itunes.com/dtds/podcast-1.0.dtd";
                return new Episode
                {
                    Title = i.Element("title").Value,
                    Description = i.Element("description").Value,
                    Length = i.Descendants(xd + "duration").FirstOrDefault()?.Value ?? "0"
                };
            }).ToList();

            // {{http://www.itunes.com/dtds/podcast-1.0.dtd}duration}

            //foreach (var item in urlManager.Descendants(("item")))
            //{
            //    var testGetFuckingLength = item.DescendantNodes();
            //    var episode = new Episode
            //    {
            //        Title = item.Element("title").Value,
            //        Description = item.Element("description").Value
            //    };

            //    episodeList.Add(episode);
            //}

            //episodeList = (from item in urlManager.Descendants("item")
            
            //    select new Episode
            //    {
            //        Length = item.Descendants(XName.Get("duration", "itunes")).FirstOrDefault().Value,
            //        Title = item.Element("title").Value,
            //        Description = item.Element("description").Value
            //        //Length = item.Element("itunes:duration").Value
            //    }).ToList();

            //return episodeList;
        }

        public static int GetTotalEpisodes(string url)
        {
            urlManager = XDocument.Load(url);
            var items = from e in urlManager.Descendants("item") 
                select new { title = e.Element("title")};
            
            int totalEpisodes = items.Count();
            return totalEpisodes;
        }
    }
}