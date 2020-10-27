using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using Models;

namespace BL
{
    public class Controller : IController<Podcast>
    {
        private UrlManager _urlManager;
        public CategoryRepository CategoryRepository;
        public PodcastRepository PodcastRepository;
        

        public Controller()
        {
            _urlManager = new UrlManager();
            CategoryRepository = new CategoryRepository();
            PodcastRepository = new PodcastRepository(CategoryRepository);
            CategoryRepository.onCategoryDelete += this.onCategoryDelete;
        }

        private void onCategoryDelete(object sender, CategoryEvent e)
        {
            PodcastRepository.Delete(e.Title);
            PodcastRepository.SaveChanges();
            PodcastRepository.GetAll();
        }


        public void CreatePodcast(string name, UpdateFrequency updateFrequency, string url, Category category)
        {
            Podcast newPodcast = new Podcast(name, updateFrequency, url, category, _urlManager.GetTotalEpisodes(url), _urlManager.GetEpisodes(url));
            PodcastRepository.Create(newPodcast);
        }


        public List<Podcast> GetAll()
        {
            return PodcastRepository.GetAll();
        }

        public List<Category> GetAllCategories()
        {
            return CategoryRepository.GetAll();
        }
    }
}
