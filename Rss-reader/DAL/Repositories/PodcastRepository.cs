using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : Repository<Podcast>, IRepository
    {
        public CategoryRepository CategoryRepository;

        public PodcastRepository(CategoryRepository catRepository)
        {
            this.CategoryRepository = catRepository;
            ObjectList = new List<Podcast>();
            ObjectList = GetAll();
        }

        public override void SaveChanges()
        {
            foreach (var c in CategoryRepository.GetList)
            {
                List<Podcast> temporaryList = new List<Podcast>();
                var query = from podcast in ObjectList where podcast.category.Title.Equals(c.Title) select podcast;
                foreach (var podcast in query)
                {
                    temporaryList.Add(podcast);
                }

                DataManager.Serialize(temporaryList, (c.Title + ".xml"));
            }
        }

        public List<Podcast> GetList
        {
            get
            {
                return ObjectList;
            }
        }

        public override List<Podcast> GetAll()
        {
            try
            {
                ObjectList.Clear();
                foreach (var c in CategoryRepository.GetList)
                {
                    List<Podcast> temporaryList = GetPodcastsByCategoyTitle(c.Title);
                    try
                    {
                        if (temporaryList != null)
                        {
                            for (int i = 0; i < temporaryList.Count; i++)
                            {
                                temporaryList[i].category = c;
                            }

                            if (ObjectList.Count() == 0)
                            {
                                ObjectList = temporaryList;
                            }
                            else
                            {
                                ObjectList.AddRange(temporaryList);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return ObjectList;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Var god lägg till en podcast");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void UpdateCategory(string name,Category category)
        {
            GetPodcast(name).category = category;
            SaveChanges();
        }

        public void UpdateUrl(string name, string url)
        {
            GetPodcast(name).Url = url;
            SaveChanges();
        }

        public void UpdateName(string valueBefore, string value)
        {
            GetPodcast(valueBefore).Name = value;
            SaveChanges();
        }

        public void UpdateFrequency(string name, UpdateFrequency newFrequency)
        {
            GetPodcast(name).UpdateFrequency = newFrequency;
            SaveChanges();
        }
        public Podcast GetPodcast(string value)
        {
            return (from p in ObjectList where p.Name.Equals(value) select p).FirstOrDefault();
        }

        public override void Delete(string value)
        {
            bool match = false;

            foreach (var c in CategoryRepository.GetList)
            {
                if (!match)
                {
                    if (c.Title.Equals(value))
                    {
                        match = true;
                        DeleteByCategory(value);
                        break;
                    }
                }
            }
            if (!match)
            {
                DeleteByName(value);
            }
        }

        private void DeleteByCategory(string value)
        {
            ObjectList.RemoveAll(p => p.category.Equals(value));
            SaveChanges();
        }

        private void DeleteByName(string value)
        {
            ObjectList.RemoveAll(p => p.Name.Equals(value));
            SaveChanges();
        }

        public List<Podcast> GetPodcastsByCategoyTitle(string name)
        {
            name += ".xml";
            List<Podcast> savedPodcasts = DataManager.Deserialize<List<Podcast>>(name);
            return savedPodcasts;
        }
    }
}