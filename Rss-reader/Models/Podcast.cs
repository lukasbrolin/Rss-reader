using System;
using System.Collections.Generic;
using System.Reflection;

namespace Models
{
    public class Podcast
    {

        public string Name { get; set; }
        public UpdateFrequency UpdateFrequency { get; set; }

        public string Url { get; set; }

        //private Categories categorie;

        private List<Episode> episodes;




        public Podcast()
        {
            Name = "Kalles kaviar";
            UpdateFrequency = UpdateFrequency.Fifteen;
            Console.WriteLine(UpdateFrequency);
            Url = @"file:///C:/Users/Lukas/AppData/Local/Temp/2519-1";
        }

    }
}
