using System;
using DAL.Repositories;
using Models;

namespace BL
{
    public class PodcastController
    {
        private IRepository<Podcast> podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void CreatePodcast()
        {
            Podcast newPodcast = new Podcast();
            podcastRepository.Create(newPodcast);
        }
    }
}
