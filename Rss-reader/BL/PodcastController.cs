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
            objectRepository = new PodcastRepository(categoryRepository);
            categoryRepository.onCategoryDelete += this.onCategoryDelete;
        }



        public void onCategoryDelete(object sender, CategoryEvent e)
        {

            objectRepository.Delete(e.Title);
            objectRepository.SaveChanges();
            objectRepository.GetAll();
        }


        public void CreatePodcast(string name, UpdateFrequency updateFrequency, string url, string category)
        {
            Category newCategory = new Category(category);
            Podcast newPodcast = new Podcast(name, updateFrequency, url, newCategory, urlManager.GetTotalEpisodes(url), urlManager.GetEpisodes(url));
            objectRepository.Create(newPodcast);
            categoryRepository.Delete("Podcast");
        }

    }
}
