using System;
using System.Collections.Generic;
using System.Reflection;

namespace Models
{
    public class Podcast
    {

        public string Name { get; set; }
        public UpdateFrequency UpdateFrequency { get; }

        public string Url { get; set; }

        private Categories categorie;

        private List<Episode> episodes;




        public Podcast()
        {
            
        }

    }
}
