using System;
using System.Collections.Generic;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : Repository<Podcast>
    {

        public override List<Podcast> GetAll()
        {
            List<Podcast> savedPodcasts = new List<Podcast>();
            savedPodcasts = dataManager.Deserialize(objectList, nameof(Podcast));
            return savedPodcasts;
        }
    }
}