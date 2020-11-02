using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast
    {
        public string Name { get; set; }
        public UpdateFrequency UpdateFrequency { get; set; }
        public DateTime NextUpdate { get; set; }
        public string Url { get; set; }
        public Category category;
        public int TotalEpisodes { get; set; }

        public List<Episode> episodes;

        public Podcast()
        {
            this.Name = "";
            UpdateFrequency = UpdateFrequency;
            this.Url = "";
            this.category = null;
            this.TotalEpisodes = TotalEpisodes;
            this.episodes = null;
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
            Update();
        }

        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }

        public void Update()
        {
            NextUpdate = DateTime.Now.AddSeconds((double) UpdateFrequency);
        }
    }
}
