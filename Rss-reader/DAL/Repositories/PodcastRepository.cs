using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
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
            foreach (var c in CategoryRepository.objectList)
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

        public override List<Podcast> GetAll()
        {
            foreach (var c in CategoryRepository.objectList)
            {
                List<Podcast> temporaryList = GetPodcastsByCategoyTitle(c.Title);
                for (int i = 0; i < temporaryList.Count; i++)
                {
                    temporaryList[i].category = c;
                }

                if (objectList == null)
                {
                    objectList = temporaryList;
                }
                else
                {
                    objectList.AddRange(temporaryList);
                }
                
            }
            return objectList;
        }


        public void UpdateCategory(string name,string valueBefore, string value)
        {
            foreach (var c in CategoryRepository.objectList)
            { 
                if (c.Title.Equals(valueBefore))
                {
                    GetPodcast(name).category = c;
                }
            }
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
        private Podcast GetPodcast(string value)
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
            foreach (var c in CategoryRepository.objectList)
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