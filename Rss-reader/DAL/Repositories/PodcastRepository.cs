using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : Repository<Podcast>
    {

        public CategoryRepository CatRepository;

        public PodcastRepository(CategoryRepository catRepository)
        {
            this.CatRepository = catRepository;
            objectList = new List<Podcast>();
            objectList = GetAll();
        }

        public override void SaveChanges()
        {
            foreach (var c in CatRepository.objectList)
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
            foreach (var c in CatRepository.objectList)
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


        public void UpdateForeach(string valueBefore, string value)
        {
            
        }

        public override void UpdateCategory(string valueBefore, string value)
        {
            Console.WriteLine();
        }

        public override void Delete(string value)
        {
            bool match = false;
            foreach (var c in CatRepository.objectList)
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

        public void DeleteByCategory(string value)
        {
            objectList.RemoveAll(p => p.category.Equals(value));
            SaveChanges();
        }

        public void DeleteByName(string value)
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