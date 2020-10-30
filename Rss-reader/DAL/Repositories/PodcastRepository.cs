using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : Repository<Podcast>, IRepository
    {
        public CategoryRepository CategoryRepository;

        public PodcastRepository(CategoryRepository catRepository)
        {
            this.CategoryRepository = catRepository;
            objectList = new List<Podcast>();
            objectList = GetAll();
        }

        public override void SaveChanges()
        {
            foreach (var c in CategoryRepository.GetList)
            {
                List<Podcast> temporaryList = new List<Podcast>();
                var query = from podcast in objectList where podcast.category.Title.Equals(c.Title) select podcast;
                foreach (var podcast in query)
                {
                    temporaryList.Add(podcast);
                }

                dataManager.Serialize(temporaryList, (c.Title + ".xml"));
            }
        }

        public List<Podcast> GetList
        {
            get
            {
                return objectList;
            }
        }

        public override List<Podcast> GetAll()
        {
            try
            {
                objectList.Clear();
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

                            if (objectList.Count() == 0)
                            {
                                objectList = temporaryList;
                            }
                            else
                            {
                                objectList.AddRange(temporaryList);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return objectList;
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
            foreach (var p in objectList)
            {
                if (p.Name.Equals(value))
                {
                    return p;
                }
            }
            return null;
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
            objectList.RemoveAll(p => p.category.Equals(value));
            SaveChanges();
        }

        private void DeleteByName(string value)
        {
            objectList.RemoveAll(p => p.Name.Equals(value));
            SaveChanges();
        }

        public List<Podcast> GetPodcastsByCategoyTitle(string name)
        {
            name += ".xml";
            List<Podcast> savedPodcasts = new List<Podcast>();
            savedPodcasts = dataManager.Deserialize<List<Podcast>>(name);
            return savedPodcasts;
        }
    }
}