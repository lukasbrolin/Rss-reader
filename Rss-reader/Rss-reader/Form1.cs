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

        private void FilldgwPodcast()
        {
            cbUpdateFrequency.DataSource = Enum.GetValues(typeof(UpdateFrequency));
            FillPodcasts();
            FillCategories();
        }

        private void FillPodcasts()
        {
            foreach (var p in controller.GetListPodcasts())
            {
                Console.WriteLine(p);
                dgwPodcasts.Rows.Add(p.TotalEpisodes, p.Name, "Every " + p.UpdateFrequency + " seconds", p.category.Title);
            }
        }

        private void FillCategories()
        {
            lbCategories.Items.Clear();
            cbCategory.DataSource = null;
            cbCategory.Items.Clear();

            cbCategory.DataSource = controller.GetListCategories();
            cbCategory.DisplayMember = "Title";

            foreach (var c in controller.GetListCategories())
            {
                lbCategories.Items.Add(c.Title);
            }
        }

        public Form1()
        {
            InitializeComponent();
            FilldgwPodcast();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateNewPodcast(tbName, tbUrl, cbCategory, cbUpdateFrequency, controller.GetListPodcasts()))
            {
                controller.CreatePodcast(tbName.Text, (UpdateFrequency)cbUpdateFrequency.SelectedValue, tbUrl.Text, (Category)cbCategory.SelectedValue);
                dgwPodcasts.Rows.Clear();
                FilldgwPodcast();
            }
            
        }

        private void dgwPodcasts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


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

        private void lbEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                String text;

                text = lbEpisodes.SelectedItem.ToString();
                
                foreach (var p in controller.GetListPodcasts())
                {
                    var episodeList = p.episodes;
                    foreach (var j in episodeList)
                    {
                        if (j.Title == text)
                        {
                            lblDescription.Text = text + " - " + j.Length;
                            tbDescription.Text = j.Description;
                            break;
                        }
                    }
                }

            
        }

        private void dgwPodcasts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int chosenPodcastIndex = 0;
            lbEpisodes.Items.Clear();

            int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            chosenPodcastIndex = 0;

            string name = dgwPodcasts.SelectedRows[chosenPodcastIndex].Cells[1].Value.ToString();
            lblEpisode.Text = name;

            foreach (var p in controller.GetListPodcasts())
            {
                string podName = p.Name;
                if (podName == name)
                {

                    var episodeList = p.episodes;
                    foreach (var c in episodeList)
                    {
                        lbEpisodes.Items.Add(c.Title);
                        lbEpisodes.Items.Add("");
                    }
                }
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateNewCategory(tbCategory, controller.GetListCategories()))
            {
                string newcat = tbCategory.Text;
                controller.CreateCategory(newcat);

                FillCategories();
            }
            

        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateChangedCategory(tbCategory, lbCategories, controller.GetListCategories()))
            {
                string oldCategory = lbCategories.SelectedItem.ToString();
                string newCategory = tbCategory.Text;
                controller.ChangeCategory(oldCategory, newCategory);
                


                FillCategories();
            }
        }
    }
}
