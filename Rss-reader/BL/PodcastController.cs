using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using Models;

namespace BL
{
    public class PodcastController : Controller<Podcast>
    {
        private UrlManager urlManager = new UrlManager();

        public override void createRepository()
        {
            objectRepository = new PodcastRepository();
        }

        public void CreatePodcast(string name, UpdateFrequency updateFrequency, string url, string category)
        {
            Category newCategory = new Category(category);
            Podcast newPodcast = new Podcast(name, updateFrequency, url, newCategory, urlManager.GetTotalEpisodes(url), urlManager.GetEpisodes(url));
            objectRepository.Create(newPodcast);
        }
    }
}
