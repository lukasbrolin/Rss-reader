using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : Repository<Podcast>
    {

        public Dictionary<string, List<Podcast>> listOfPodcasts;

        public PodcastRepository()
        {
            listOfPodcasts = new Dictionary<string, List<Podcast>>();
            listOfPodcasts.Add("Category", objectList);
            Console.WriteLine(listOfPodcasts.Values.FirstOrDefault());
        }

        public override List<Podcast> GetAll()
        {
            List<Podcast> savedPodcasts = new List<Podcast>();
            savedPodcasts = dataManager.Deserialize(objectList, nameof(Podcast));
            return savedPodcasts;
        }
    }
}