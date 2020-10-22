using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Rss_reader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PodcastController controller = new PodcastController();
            controller.CreatePodcast();


            
               

            Application.EnableVisualStyles();
            Application.Run(new Form1());

            
        }
    }
}
