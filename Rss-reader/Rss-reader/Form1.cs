using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
using BL;
using Models;

namespace Rss_reader
{
    public partial class Form1 : Form
    {
        public Controller controller = new Controller();
        private Timer timer;
        


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
                dgwPodcasts.Rows.Add(p.TotalEpisodes, p.Name, "Var " + p.UpdateFrequency + " minut", p.category.Title);
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
            //controller;
            
            InitializeComponent();
            StartTimer();
            FilldgwPodcast();
            //controller.onUpdatePodcast += UpdateTables;

        }

        public void StartTimer()
        {
            timer = new Timer{Interval = 15000, Enabled = true, Tag = "123"};
            timer.Tick += controller.UpdatePodcast;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            UpdatePodcastTable();
            UpdateEpisodesList();
        }

        private void UpdatePodcastTable()
        {

            if (dgwPodcasts.RowCount != 0 )
            {
                lbEpisodes.Items.Clear();
            

            int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int chosenPodcastIndex = 0;

            string name = dgwPodcasts.SelectedRows[chosenPodcastIndex].Cells[1].Value.ToString();
            lblEpisode.Text = name;

            foreach (var p in controller.GetListPodcasts().ToList())
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

        

        private void RefreshView()
        {
            dgwPodcasts.Rows.Clear();
            FilldgwPodcast();
            lblDescription.Text = "";
            tbDescription.Clear();
            lbEpisodes.Items.Clear();
            lblEpisode.Text = "";
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
            
            if(lbEpisodes.SelectedItem != null){
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
        }

        

        private void btnSavePodcast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemovePodcast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1;
                string podcastToDelete = dgwPodcasts.SelectedRows[selectedRowCount].Cells[1].Value.ToString();
                if (podcastToDelete != null)
                {
                    controller.DeletePodcast(podcastToDelete);
                    MessageBox.Show("Podcasten togs bort!");
                    RefreshView();
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("There is no podcasts in the list");
            }
            
        }

        private void dgwPodcasts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgwPodcasts.SelectedRows[0].Cells[1].Value.ToString();
            tbName.Text = name;
            tbUrl.Text = controller.GetPodcast(name).Url;
            cbUpdateFrequency.SelectedItem = controller.GetPodcast(name).UpdateFrequency;

            UpdateEpisodesList();

        }

        private void UpdateEpisodesList()
        {

            try
            {
                string selectedPod = dgwPodcasts.SelectedRows[0].Cells[1].Value.ToString();
                tbName.Text = selectedPod;
                tbUrl.Text = controller.GetPodcast(selectedPod).Url;
                cbUpdateFrequency.SelectedItem = controller.GetPodcast(selectedPod).UpdateFrequency;

                if (lbEpisodes.Items.Count != 0)
                {
                    lbEpisodes.Items.Clear();
                }

                int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected);
                int chosenPodcastIndex = 0;

                string name = dgwPodcasts.SelectedRows[chosenPodcastIndex].Cells[1].Value.ToString();
                lblEpisode.Text = name;

                foreach (var p in controller.GetListPodcasts().ToList())
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
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("There is no podcasts in the list");
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

                dgwPodcasts.Rows.Clear();
                FilldgwPodcast();
            }
            
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
                string categoryToDelete = lbCategories.SelectedItem.ToString();
                if (categoryToDelete != null)
                {
                    DialogResult deleteCategory = MessageBox.Show("Vill du ta bort kategorin och alla podcasts i denna?", "Ta bort kategori", MessageBoxButtons.YesNo);
                    if (deleteCategory == DialogResult.Yes)
                    {
                        controller.DeleteCategory(categoryToDelete);
                        MessageBox.Show("Kategorin togs bort!");
                    RefreshView();
                    }
                }
            
        }

        private void btnSavePodcast_Click_1(object sender, EventArgs e)
        {
            //int selectedRowCount = dgwPodcasts.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1;
            try
            {
                string oldPodcastName = dgwPodcasts.SelectedRows[0].Cells[1].Value.ToString();
                string oldPodcastUrl = controller.GetPodcast(oldPodcastName).Url;
                if (Validation.ValidateChangedPodcast(tbName, tbUrl, controller.GetListPodcasts(), cbCategory,
                    cbUpdateFrequency, oldPodcastName, oldPodcastUrl))
                {
                    controller.ChangePodcastName(oldPodcastName, tbName.Text);
                    controller.ChangePodcastCategory(tbName.Text, (Category) cbCategory.SelectedItem);
                    controller.ChangePodcastFrequency(tbName.Text, (UpdateFrequency) cbUpdateFrequency.SelectedValue);
                    controller.ChangeUrl(tbName.Text, tbUrl.Text);
                    RefreshView();
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("There is no podcasts in the list");

            }
        }

        private void btnSortEpisodes_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < (dgwPodcasts.Rows.Count); i++)
                {
                    Console.WriteLine(dgwPodcasts.Rows[i].Cells[3].Value.ToString());

                    //ta bort lbCategories.SelectedItem != null && ?
                
                    if (!dgwPodcasts.Rows[i].Cells[3].Value.ToString()
                        .Equals(lbCategories.SelectedItem.ToString()))
                    {
                        dgwPodcasts.Rows[i].Visible = false;
                    }
                    else
                    {
                        dgwPodcasts.Rows[i].Visible = true;
                    }
                }

                lbEpisodes.Items.Clear();
                lblEpisode.Text = "";
                lblDescription.Text = "";
                tbDescription.Clear();
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("No category is selected");
                MessageBox.Show("Det finns ingen vald kategori", "Inmatningsfel");
            }
        }
        


        private void btnShowAllPodcasts_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (dgwPodcasts.Rows.Count); i++)
            {
                dgwPodcasts.Rows[i].Visible = true;
            }
            lbEpisodes.Items.Clear();
            lblEpisode.Text = "";
            lblDescription.Text = "";
            tbDescription.Clear();
        }
    }
}
