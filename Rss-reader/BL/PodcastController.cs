using System;
using System.Collections.Generic;
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

        public List<Podcast> GetAll()
        {
            return podcastRepository.GetAll();
        }

    }
}
