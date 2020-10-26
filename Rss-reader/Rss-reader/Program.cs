using System;
using System.Collections.Generic;
using System.IO;
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

        //    string[] XMLfiles = Directory.GetFiles(@"..\Debug\", "*.XML");
        //    foreach(string file in XMLfiles)
        //{
        //    Console.WriteLine(Path.GetFileName(file));
        //}

            ;

    /*PodcastController controller = new PodcastController();
    controller.CreatePodcast();*/

    //string[] folders = System.IO.Directory.GetDirectories(@"..\Debug\");

    //        foreach (var d in System.IO.Directory.GetDirectories(@"..\Debug\"))
    //        {
    //            var dir = new DirectoryInfo(d);
    //            var dirName = dir.Name;
    //            Console.WriteLine(dirName);
    //        }
    //        Console.WriteLine(folders[0]);
            //catcontroller.CreateCategory();

            Application.EnableVisualStyles();
            Application.Run(new Form1());
            
        }
    }
}
