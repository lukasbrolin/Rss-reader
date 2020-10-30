﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
                XNamespace xd = "http://www.itunes.com/dtds/podcast-1.0.dtd";
                return new Episode
                {
                    Title = i.Element("title")?.Value ?? "",
                    Description = i.Element("description")?.Value ?? "",
                    Length = i.Descendants(xd + "duration").FirstOrDefault()?.Value ?? "0"
                };
            }).ToList();
        }

        public static int GetTotalEpisodes(string url)
        {
            try
            {
                urlManager = XDocument.Load(url);
            }
            catch (FileNotFoundException e)
            {
                return 0;
            }
            return urlManager.Descendants(("item")).Select(i => i.Element("title")).Count();

        }
    }
}