using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

        public Podcast GetPodcast(string value)
        {
            return PodcastRepository.GetPodcast(value);
        }

        public List<Podcast> GetPodcastsPerCategory(string value)
        {
            List<Podcast> temporaryList = new List<Podcast>();
            var query = from podcast in PodcastRepository.objectList
                where podcast.category.Equals(value)
                select podcast;
            foreach (var podcast in query)
            {
                temporaryList.Add(podcast);
            }

            return temporaryList;
        }

        public Episode GetPodcastEpisode(string podName, string episodeName)
        {
            Podcast podcast = (from p in PodcastRepository.objectList
                where p.Name.Equals(podName)
                select p).FirstOrDefault();
            Episode episode = (from e in podcast.episodes where e.Title.Equals(episodeName) select e).FirstOrDefault();
            return episode;
        }

        public void ChangePodcastName(string nameBefore, string name)
        {
            PodcastRepository.UpdateName(nameBefore, name);
        }

        public void ChangePodcastCategory(string podcastName, string valueBefore, string value)
        {
            PodcastRepository.UpdateCategory(podcastName, valueBefore,value);
        }

        public void ChangePodcastFrequency(string podcastName, UpdateFrequency newFrequency)
        {
            PodcastRepository.UpdateFrequency(podcastName, newFrequency);
        }

        public void DeletePodcast(string value)
        {
            PodcastRepository.Delete(value);
        }

        public void CreateCategory(string value)
        {
            Category newCategory = new Category(value);
            CategoryRepository.Create(newCategory);
        }

        public void ChangeCategory(string valueBefore, string value)
        {
            CategoryRepository.UpdateCategory(valueBefore, value);
        }

        public void DeleteCategory(string value)
        {
            CategoryRepository.Delete(value);
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
