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

namespace Rss_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //dgwPodcasts.Rows.RemoveAt(0);
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            PodcastController controller = new PodcastController();
            var podcastList = controller.GetAll();
            Console.WriteLine(podcastList.Count);
            foreach (var p in podcastList)
            {
                Console.WriteLine(p);
                dgwPodcasts.Rows.Add(0, p.Name, p.UpdateFrequency, "Historia");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
