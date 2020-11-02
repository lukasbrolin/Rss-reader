using System;
using System.Collections.Generic;
using System.IO;
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
            urlManager = XDocument.Load(url);

            return urlManager.Descendants(("item")).Select(i =>
            {
                XNamespace Prefix = "http://www.itunes.com/dtds/podcast-1.0.dtd";
                return new Episode
                {
                    Title = i.Element("title")?.Value ?? "",
                    Description = i.Element("description")?.Value.Replace(@"<p>", "").Replace(@"</p>", "") ?? "",
                    Length = i.Descendants(Prefix + "duration").FirstOrDefault()?.Value ?? "0"
                };
            }).ToList();
        }

        public static int GetTotalEpisodesCount(string url)
        {
            try
            {
                urlManager = XDocument.Load(url);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                return 0;
            }
            return urlManager.Descendants(("item")).Select(i => i.Element("title")).Count();

        }
    }
}