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
        string oldcat = "";
        string oldname = "";
        string oldcategory = "";
        
        public Form1()
        {
            InitializeComponent();
            Filldgw();

            // TEST
            //dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            //dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            //dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");
            //dgwPodcasts.Rows.Add("1", "n", "resdtfgy", "GVHJ,");



            //controller.CreatePodcast("Svt Nyheter", UpdateFrequency.Fifteen, "https://www.svt.se/nyheter/rss.xml", "Nyheter" );
            //controller.CreatePodcast("The Daily", UpdateFrequency.Sixty, "http://rss.art19.com/the-daily", "Nyheter");
            //    var podcastList = controller.GetAll();
            //    Console.WriteLine(podcastList.Count);
            //    foreach (var p in podcastList)
            //    {
            //        Console.WriteLine(p);
            //        dgwPodcasts.Rows.Add(p.TotalEpisodes, p.Name, "Every " + p.UpdateFrequency + " seconds", p.category.Title);
            //    }

            //}

            
        }
          private void Filldgw()
            {
                var podcastList = controller.GetAll();
                Console.WriteLine(podcastList.Count);
                foreach (var p in podcastList)
                {
                    Console.WriteLine(p);
                    dgwPodcasts.Rows.Add(p.TotalEpisodes, p.Name, "Every " + p.UpdateFrequency + " seconds", p.category.Title);
                }
            var catetgory = controller.GetAllCategories();
            foreach (var cat in catetgory)
            {
                cbCategory.Items.Add(cat.Title);
                lbCategories.Items.Add(cat.Title);
            }

            foreach (var up in Enum.GetValues(typeof(UpdateFrequency)))
            {
                cbUpdateFrequency.Items.Add(up.ToString());
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            //controller.CreatePodcast(tbName.Text, (UpdateFrequency)cbUpdateFrequency.SelectedItem, tbUrl.Text, (Category)cbCategory.SelectedItem);
            //controller.CreatePodcast(tbName.Text, cbUpdateFrequency.SelectedItem, tbUrl.Text, cbCategory.SelectedItem);
        }

      
        

       

        

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void dgwPodcasts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                int chosenPodcastIndex = 0;
                lbEpisodes.Items.Clear();



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

                        oldname = p.Name;
                        tbName.Text = p.Name;
                        oldcategory = p.category.Title;

                        cbCategory.Text = p.category.ToString();
                        UpdateFrequency updateFrequency;
                        

                        var episodeList = p.episodes;
                        foreach (var j in episodeList)
                        {
                            lbEpisodes.Items.Add(j.Title);
                        }
                    }
                }

               


            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //var catetgory = controller.GetAllCategories();
            //foreach (var cat in catetgory)
            //{
            //    cbCategory.Items.Add(cat.Title);
            //    lbCategories.Items.Add(cat.Title);
            //}

            //foreach (var up in Enum.GetValues(typeof(UpdateFrequency)))
            //{
            //    cbUpdateFrequency.Items.Add(up.ToString());
            //}


            

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newcat = tbCategory.Text;
            controller.CreateCategory(newcat);
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            
            string newcatname = tbCategory.Text;
            controller.ChangeCategory(oldcat, newcatname);
        }

        private void tbCategory_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text;

            text = lbEpisodes.SelectedItem.ToString();
            lblDescription.Text = text;
            Controller controller = new Controller();


            var podcastList = controller.GetAll();



            foreach (var p in podcastList)
            {


                var episodeList = p.episodes;
                foreach (var j in episodeList)
                {
                    if (j.Title == text)
                    {
                        tbDescription.Text = j.Description;
                        break;
                    }
                }

            }

        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCategory.Text = lbCategories.SelectedItem.ToString();
            oldcat = lbCategories.SelectedItem.ToString();
            
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            controller.DeleteCategory(tbCategory.Text);
            Filldgw();
        }

        private void btnSavePodcast_Click(object sender, EventArgs e)
        {
            if (oldname != tbName.Text)
            {
                controller.ChangePodcastName(oldname, tbName.Text);
            }
            if (oldcategory != cbCategory.SelectedItem.ToString())
            {
                controller.ChangeCategory(oldcategory, cbCategory.SelectedItem.ToString());
            }
        }
    }
}
