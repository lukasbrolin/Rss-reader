using System;
using System.Collections.Generic;
using System.Reflection;

namespace Models
{
    public class Podcast
    {

        public string Name { get; set; }
        public UpdateFrequency UpdateFrequency { get; set; }

        public string Url { get; set; }

        private Category category;

        private int TotalEpisodes { get; set; }

        private List<Episode> episodes;




        public Podcast()
        {
            this.Name = "";
            UpdateFrequency = UpdateFrequency;
            this.Url = "";
            this.category = category;
            this.TotalEpisodes = TotalEpisodes;
            this.episodes = episodes;
        }

        public Podcast(string name, UpdateFrequency updateFrequency, string url, Category category, int totalEpisodes,
            List<Episode> episodes)
        {
            this.Name = name;
            this.UpdateFrequency = updateFrequency;
            this.Url = url;
            this.category = category;
            this.TotalEpisodes = totalEpisodes;
            this.episodes = episodes;
        }
    }
}
