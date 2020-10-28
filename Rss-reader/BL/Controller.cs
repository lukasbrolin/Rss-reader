using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Timers;
using DAL;
using DAL.Repositories;
using Models;

namespace BL
{
    public class Controller : IController<Podcast>
    {
        //private UrlManager _urlManager;
        public CategoryRepository CategoryRepository;
        public PodcastRepository PodcastRepository;
        private Timer timer = new Timer(15000);
        

        public Controller()
        {
            timer.Elapsed += UpdatePodcast;
            timer.Start();
            //_urlManager = new UrlManager();
            CategoryRepository = new CategoryRepository();
            PodcastRepository = new PodcastRepository(CategoryRepository);
            CategoryRepository.onCategoryDelete += this.onCategoryDelete;
        }

        private void onCategoryDelete(object sender, CategoryEvent e)
        {
            PodcastRepository.Delete(e.Title);
            PodcastRepository.SaveChanges();
            PodcastRepository.objectList.Clear();
            CategoryRepository.objectList.Clear();
            CategoryRepository.GetAll();
            PodcastRepository.GetAll();
        }

        public void UpdatePodcast(object sender, EventArgs e)
        {
            if ((!PodcastRepository.objectList.Any()) && (PodcastRepository.objectList!=null) || PodcastRepository!=null)
            {
                foreach (var p in PodcastRepository.objectList)
                {
                    if (p.NeedsUpdate)
                    {
                        p.Update();
                        if (!p.episodes[0].Title.Equals(UrlManager.GetEpisodes(p.Url)[0].Title))
                        {
                            p.episodes = UrlManager.GetEpisodes(p.Url);
                            p.TotalEpisodes = UrlManager.GetTotalEpisodes(p.Url);
                            Console.WriteLine(p.Name + " Have added Episodes");
                        }

                        Console.WriteLine(p.Name + " WAS UPDATED");
                    }
                }

                PodcastRepository.SaveChanges();
                PodcastRepository.objectList.Clear();
                PodcastRepository.GetAll();
            }
        }

        public List<Podcast> GetListPodcasts()
        {
            return PodcastRepository.GetList;
        }

        public List<Category> GetListCategories()
        {
            return CategoryRepository.GetList;
        }

        public void CreatePodcast(string name, UpdateFrequency updateFrequency, string url, Category category)
        {
            Podcast newPodcast = new Podcast(name, updateFrequency, url, category, UrlManager.GetTotalEpisodes(url), UrlManager.GetEpisodes(url));
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

        public Category GetCategoryByName(string value)
        {
            
            return CategoryRepository.objectList.Where(c => c.Title.Equals(value)).Select(c => c).FirstOrDefault();
        }
    }
}
