using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Models;

namespace DAL
{
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