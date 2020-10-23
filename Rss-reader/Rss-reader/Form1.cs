using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models;

namespace Rss_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            PodcastController controller = new PodcastController();
            InitializeComponent();

            // TEST
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            
            

            controller.CreatePodcast("Svt Nyheter", UpdateFrequency.Fifteen, "https://www.svt.se/nyheter/rss.xml", "Nyheter" );

            var podcastList = controller.GetAll();
            Console.WriteLine(podcastList.Count);
            foreach (var p in podcastList)
            {
                Console.WriteLine(p);
                dgwPodcasts.Rows.Add(0, p.Name, "Every " +  p.UpdateFrequency + " seconds", "Historia");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
