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
        public Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();

            //controller.CreatePodcast("Svt Nyheter", UpdateFrequency.Fifteen, "https://www.svt.se/nyheter/rss.xml", "Nyheter" );
            //controller.CreatePodcast("The Daily", UpdateFrequency.Sixty, "http://rss.art19.com/the-daily", "Nyheter");
            Console.WriteLine();
            foreach (var p in controller.GetList())
            {
                Console.WriteLine(p);
                dgwPodcasts.Rows.Add(p.TotalEpisodes, p.Name, "Every " + p.UpdateFrequency + " seconds", p.category.Title);
            }
            //controller.CreateCategory("Nyheter");
            //controller.CreatePodcast("The Daily", UpdateFrequency.Thirty, "http://rss.art19.com/the-daily", controller.GetCategoryByName("Nyheter"));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            //controller.CreatePodcast(tbName.Text, cbUpdateFrequency.SelectedItem, tbUrl.Text, cbCategory.SelectedItem);
        }

        private void dgwPodcasts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenPodcastIndex = 0;
            lwEpisodes.Items.Clear();



            int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            chosenPodcastIndex = 0;

            string name = dgwPodcasts.SelectedRows[chosenPodcastIndex].Cells[1].Value.ToString();
            lblEpisode.Text = name;

            Controller controller = new Controller();
            var podcastList = controller.GetAll();



            foreach (var p in podcastList)
            {
                string podName = p.Name;
                if (podName == name)
                {



                    var episodeList = p.episodes;
                    foreach (var j in episodeList)
                    {
                        lwEpisodes.Items.Add(j.Title);
                    }
                }
            }


        }

        private void lwEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text;

            text = lwEpisodes.SelectedItems[0].Text;
            lblDescription.Text = text;
            Controller controller = new Controller();


            var podcastList = controller.GetAll();

           

            foreach (var p in podcastList)
            {
               

                    var episodeList = p.episodes;
                    foreach (var j in episodeList)
                    {
                    if (j.Title == text) { 
                        tbDescription.Text=j.Description;
                        break;
                    }
                    }
                
            }
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newcat = tbCategory.Text;

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var catetgory = controller.GetAllCategories();
            foreach (var cat in catetgory) {
                cbCategory.Items.Add(cat.Title);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUpdateFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (var up in Enum.GetValues(typeof(UpdateFrequency)))
            {
                cbUpdateFrequency.Items.Add(up.ToString());
                    }
        }
    }
}
