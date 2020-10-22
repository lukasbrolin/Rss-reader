using System;
using System.Collections.Generic;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : IRepository<Podcast>
    {

        DataManager dataManager;
        List<Podcast> podcasts;

        public PodcastRepository()
        {
            podcasts = new List<Podcast>();
            dataManager = new DataManager();
            podcasts = GetAll();
            
        }

        public void Create(Podcast podcast)
        {
            podcasts.Add(podcast);
            SaveChanges();
        }

        public void Delete(int index)
        {

        }

        public void Update(int index, Podcast podcast)
        {

        }

        public void SaveChanges()
        {
            dataManager.Serialize(podcasts);
        }

        /*public List<Podcast> GetAll()
        {
            List<Podcast> savedPodcasts = new List<Podcast>();
            savedPodcasts = dataManager.DeserializePodcasts();
            return savedPodcasts;
        }*/

        public List<Podcast> GetAll()
        {
            List<Podcast> savedPodcasts = new List<Podcast>();
            savedPodcasts = dataManager.Deserialize(podcasts, nameof(Podcast));
            return savedPodcasts;
        }
    }
}