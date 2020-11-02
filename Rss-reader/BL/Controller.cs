using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories;
using Models;

namespace BL
{
    public class Controller : IController<Podcast>
    {
        public CategoryRepository CategoryRepository;
        public PodcastRepository PodcastRepository;

        public Controller()
        {
            CategoryRepository = new CategoryRepository();
            PodcastRepository = new PodcastRepository(CategoryRepository);
            CategoryRepository.OnCategoryDelete += this.OnCategoryDelete;
        }

        private void OnCategoryDelete(object sender, CategoryEvent e)
        {
            CategoryRepository.GetAll();
            PodcastRepository.GetAll();
        }

        public async Task CheckforEpisodes()
        {
            if ((!PodcastRepository.ObjectList.Any()) && (PodcastRepository.ObjectList != null) || PodcastRepository != null)
            {

                try
                {
                    var query = from pod in PodcastRepository.ObjectList.ToList()
                        where pod.NeedsUpdate.Equals(true)
                                select pod;

                    foreach (var p in query)
                    {
                        var result = await Task.Run(() => UrlManager.GetEpisodes(p.Url)).ConfigureAwait(false);
                        p.Update();
                        if (!p.episodes[0].Title.Equals(result[0].Title))
                        {
                            p.episodes = result;
                            p.TotalEpisodes = result.Count;
                            Console.WriteLine(p.Name + " Have added Episodes");
                            PodcastRepository.SaveChanges();
                            PodcastRepository.GetAll();
                        }

                        Console.WriteLine("Updated");
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Tom lista ej Uppdateringsbar");
                    Console.WriteLine(e.Message);
                }
            }
           
        }

        public List<Podcast> GetListPodcasts()
        {
            return PodcastRepository.GetList;
        }

        public void SaveChanges()
        {
            PodcastRepository.SaveChanges();
        }

        public List<Category> GetListCategories()
        {
            return CategoryRepository.GetList;
        }

        public void CreatePodcast(string name, UpdateFrequency updateFrequency, string url, Category category)
        {
            var result = UrlManager.GetEpisodes(url);
            Podcast newPodcast = new Podcast(name, updateFrequency, url, category, result.Count, result);
            PodcastRepository.Create(newPodcast);
        }

        public Podcast GetPodcast(string value)
        {
            return PodcastRepository.GetPodcast(value);
        }

        public void ChangePodcastName(string nameBefore, string name)
        {
            PodcastRepository.UpdateName(nameBefore, name);
        }

        public void ChangePodcastCategory(string podcastName, Category category)
        {
            PodcastRepository.UpdateCategory(podcastName, category);
        }

        public void ChangeUrl(string name, string url)
        {
            PodcastRepository.UpdateUrl(name, url);
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
            PodcastRepository.SaveChanges();
        }

        public void ChangeCategory(string valueBefore, string value)
        {
            CategoryRepository.UpdateCategory(valueBefore, value);
            PodcastRepository.SaveChanges();
        }

        public void DeleteCategory(string value)
        {
            CategoryRepository.Delete(value);
        }

        public List<Podcast> GetAll()
        {
            return PodcastRepository.GetAll();
        }
    }
}
