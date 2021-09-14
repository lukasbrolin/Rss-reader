using System.Threading;
using System.Windows.Forms;

namespace Rss_reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwPodcasts = new System.Windows.Forms.DataGridView();
            this.clmEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnRemovePodcast = new System.Windows.Forms.Button();
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.btnSavePodcast = new System.Windows.Forms.Button();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbEpisodes = new System.Windows.Forms.ListBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.btnSortEpisodes = new System.Windows.Forms.Button();
            this.btnShowAllPodcasts = new System.Windows.Forms.Button();
            this.pnlCategoriesTop = new System.Windows.Forms.Panel();
            this.pnlPodcastsTop = new System.Windows.Forms.Panel();
            this.lblPodcasts = new System.Windows.Forms.Label();
            this.pnlPodcastsRight = new System.Windows.Forms.Panel();
            this.pnlCategoriesRight = new System.Windows.Forms.Panel();
            this.lblCategorytb = new System.Windows.Forms.Label();
            this.pnlEpisodes = new System.Windows.Forms.Panel();
            this.pnlEpisodeInfo = new System.Windows.Forms.Panel();
            this.lblUFInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).BeginInit();
            this.pnlCategoriesTop.SuspendLayout();
            this.pnlPodcastsTop.SuspendLayout();
            this.pnlEpisodes.SuspendLayout();
            this.pnlEpisodeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPodcasts
            // 
            this.dgwPodcasts.AllowUserToAddRows = false;
            this.dgwPodcasts.AllowUserToDeleteRows = false;
            this.dgwPodcasts.AllowUserToResizeColumns = false;
            this.dgwPodcasts.AllowUserToResizeRows = false;
            this.dgwPodcasts.BackgroundColor = System.Drawing.Color.White;
            this.dgwPodcasts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwPodcasts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPodcasts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPodcasts.ColumnHeadersHeight = 43;
            this.dgwPodcasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwPodcasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEpisode,
            this.clmName,
            this.clmFrequency,
            this.clmCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPodcasts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwPodcasts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPodcasts.EnableHeadersVisualStyles = false;
            this.dgwPodcasts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwPodcasts.Location = new System.Drawing.Point(12, 45);
            this.dgwPodcasts.MaximumSize = new System.Drawing.Size(600, 250);
            this.dgwPodcasts.MultiSelect = false;
            this.dgwPodcasts.Name = "dgwPodcasts";
            this.dgwPodcasts.ReadOnly = true;
            this.dgwPodcasts.RowHeadersVisible = false;
            this.dgwPodcasts.RowHeadersWidth = 62;
            this.dgwPodcasts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgwPodcasts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwPodcasts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgwPodcasts.RowTemplate.Height = 40;
            this.dgwPodcasts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPodcasts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwPodcasts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPodcasts.Size = new System.Drawing.Size(600, 244);
            this.dgwPodcasts.TabIndex = 0;
            this.dgwPodcasts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwPodcasts_CellContentClick_1);
            // 
            // clmEpisode
            // 
            this.clmEpisode.HeaderText = "Avsnitt";
            this.clmEpisode.MinimumWidth = 8;
            this.clmEpisode.Name = "clmEpisode";
            this.clmEpisode.ReadOnly = true;
            this.clmEpisode.Width = 80;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Namn";
            this.clmName.MinimumWidth = 8;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmFrequency
            // 
            this.clmFrequency.HeaderText = "Frekvens";
            this.clmFrequency.MinimumWidth = 8;
            this.clmFrequency.Name = "clmFrequency";
            this.clmFrequency.ReadOnly = true;
            this.clmFrequency.Width = 160;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.MinimumWidth = 8;
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Width = 160;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(8, 309);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(55, 20);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL: ";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateFrequency.Location = new System.Drawing.Point(328, 308);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(195, 20);
            this.lblUpdateFrequency.TabIndex = 2;
            this.lblUpdateFrequency.Text = "Uppdateringsfrekvens: ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(328, 355);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori: ";
            // 
            // tbUrl
            // 
            this.tbUrl.BackColor = System.Drawing.SystemColors.Window;
            this.tbUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUrl.Location = new System.Drawing.Point(12, 332);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(280, 20);
            this.tbUrl.TabIndex = 2;
            // 
            // cbUpdateFrequency
            // 
            this.cbUpdateFrequency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateFrequency.FormattingEnabled = true;
            this.cbUpdateFrequency.Location = new System.Drawing.Point(332, 331);
            this.cbUpdateFrequency.Name = "cbUpdateFrequency";
            this.cbUpdateFrequency.Size = new System.Drawing.Size(280, 21);
            this.cbUpdateFrequency.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(332, 378);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(280, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemovePodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemovePodcast.Location = new System.Drawing.Point(618, 256);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(137, 33);
            this.btnRemovePodcast.TabIndex = 10;
            this.btnRemovePodcast.Text = "Ta bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = false;
            this.btnRemovePodcast.Click += new System.EventHandler(this.BtnRemovePodcast_Click);
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddPodcast.Location = new System.Drawing.Point(618, 178);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(137, 33);
            this.btnAddPodcast.TabIndex = 8;
            this.btnAddPodcast.Text = "Lägg till";
            this.btnAddPodcast.UseVisualStyleBackColor = false;
            this.btnAddPodcast.Click += new System.EventHandler(this.BtnAddPodcast_Click);
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSavePodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSavePodcast.Location = new System.Drawing.Point(618, 217);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.Size = new System.Drawing.Size(137, 33);
            this.btnSavePodcast.TabIndex = 9;
            this.btnSavePodcast.Text = "Spara";
            this.btnSavePodcast.UseVisualStyleBackColor = false;
            this.btnSavePodcast.Click += new System.EventHandler(this.BtnSavePodcast_Click_1);
            // 
            // lblEpisode
            // 
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.ForeColor = System.Drawing.Color.White;
            this.lblEpisode.Location = new System.Drawing.Point(4, 6);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(736, 20);
            this.lblEpisode.TabIndex = 13;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(3, 4);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(97, 20);
            this.lblCategories.TabIndex = 15;
            this.lblCategories.Text = "Kategorier:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(780, 332);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(240, 20);
            this.tbCategory.TabIndex = 14;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddCategory.Location = new System.Drawing.Point(1026, 99);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(134, 42);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Lägg till";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSaveCategory.Location = new System.Drawing.Point(1026, 147);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnSaveCategory.TabIndex = 12;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.BtnSaveCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemoveCategory.Location = new System.Drawing.Point(1026, 195);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnRemoveCategory.TabIndex = 13;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(387, 20);
            this.lblDescription.TabIndex = 20;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(780, 465);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(390, 268);
            this.tbDescription.TabIndex = 21;
            this.tbDescription.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 378);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(8, 355);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Namn:";
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbEpisodes.FormattingEnabled = true;
            this.lbEpisodes.ItemHeight = 20;
            this.lbEpisodes.Location = new System.Drawing.Point(12, 465);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(753, 264);
            this.lbEpisodes.TabIndex = 24;
            this.lbEpisodes.TabStop = false;
            this.lbEpisodes.SelectedIndexChanged += new System.EventHandler(this.LbEpisodes_SelectedIndexChanged);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 20;
            this.lbCategories.Location = new System.Drawing.Point(780, 45);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(240, 244);
            this.lbCategories.TabIndex = 25;
            // 
            // btnSortEpisodes
            // 
            this.btnSortEpisodes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortEpisodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSortEpisodes.Location = new System.Drawing.Point(618, 51);
            this.btnSortEpisodes.Name = "btnSortEpisodes";
            this.btnSortEpisodes.Size = new System.Drawing.Size(137, 46);
            this.btnSortEpisodes.TabIndex = 6;
            this.btnSortEpisodes.Text = "Sortera efter Kategori";
            this.btnSortEpisodes.UseVisualStyleBackColor = false;
            this.btnSortEpisodes.Click += new System.EventHandler(this.BtnSortEpisodes_Click);
            // 
            // btnShowAllPodcasts
            // 
            this.btnShowAllPodcasts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllPodcasts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllPodcasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnShowAllPodcasts.Location = new System.Drawing.Point(618, 103);
            this.btnShowAllPodcasts.Name = "btnShowAllPodcasts";
            this.btnShowAllPodcasts.Size = new System.Drawing.Size(137, 46);
            this.btnShowAllPodcasts.TabIndex = 7;
            this.btnShowAllPodcasts.Text = "Visa alla Podcasts";
            this.btnShowAllPodcasts.UseVisualStyleBackColor = false;
            this.btnShowAllPodcasts.Click += new System.EventHandler(this.BtnShowAllPodcasts_Click);
            // 
            // pnlCategoriesTop
            // 
            this.pnlCategoriesTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlCategoriesTop.Controls.Add(this.lblCategories);
            this.pnlCategoriesTop.Location = new System.Drawing.Point(780, 16);
            this.pnlCategoriesTop.Name = "pnlCategoriesTop";
            this.pnlCategoriesTop.Size = new System.Drawing.Size(387, 29);
            this.pnlCategoriesTop.TabIndex = 28;
            // 
            // pnlPodcastsTop
            // 
            this.pnlPodcastsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlPodcastsTop.Controls.Add(this.lblPodcasts);
            this.pnlPodcastsTop.Location = new System.Drawing.Point(12, 16);
            this.pnlPodcastsTop.Name = "pnlPodcastsTop";
            this.pnlPodcastsTop.Size = new System.Drawing.Size(753, 29);
            this.pnlPodcastsTop.TabIndex = 29;
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.BackColor = System.Drawing.Color.Transparent;
            this.lblPodcasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcasts.ForeColor = System.Drawing.Color.White;
            this.lblPodcasts.Location = new System.Drawing.Point(3, 4);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(88, 20);
            this.lblPodcasts.TabIndex = 15;
            this.lblPodcasts.Text = "Podcasts:";
            // 
            // pnlPodcastsRight
            // 
            this.pnlPodcastsRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlPodcastsRight.ForeColor = System.Drawing.Color.Transparent;
            this.pnlPodcastsRight.Location = new System.Drawing.Point(761, 16);
            this.pnlPodcastsRight.Name = "pnlPodcastsRight";
            this.pnlPodcastsRight.Size = new System.Drawing.Size(4, 382);
            this.pnlPodcastsRight.TabIndex = 30;
            // 
            // pnlCategoriesRight
            // 
            this.pnlCategoriesRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlCategoriesRight.ForeColor = System.Drawing.Color.Transparent;
            this.pnlCategoriesRight.Location = new System.Drawing.Point(1166, 16);
            this.pnlCategoriesRight.Name = "pnlCategoriesRight";
            this.pnlCategoriesRight.Size = new System.Drawing.Size(4, 382);
            this.pnlCategoriesRight.TabIndex = 31;
            // 
            // lblCategorytb
            // 
            this.lblCategorytb.AutoSize = true;
            this.lblCategorytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategorytb.Location = new System.Drawing.Point(776, 309);
            this.lblCategorytb.Name = "lblCategorytb";
            this.lblCategorytb.Size = new System.Drawing.Size(125, 20);
            this.lblCategorytb.TabIndex = 32;
            this.lblCategorytb.Text = "Kategorinamn:";
            // 
            // pnlEpisodes
            // 
            this.pnlEpisodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlEpisodes.Controls.Add(this.lblEpisode);
            this.pnlEpisodes.Location = new System.Drawing.Point(12, 436);
            this.pnlEpisodes.Name = "pnlEpisodes";
            this.pnlEpisodes.Size = new System.Drawing.Size(753, 29);
            this.pnlEpisodes.TabIndex = 33;
            // 
            // pnlEpisodeInfo
            // 
            this.pnlEpisodeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.pnlEpisodeInfo.Controls.Add(this.lblDescription);
            this.pnlEpisodeInfo.Location = new System.Drawing.Point(780, 436);
            this.pnlEpisodeInfo.Name = "pnlEpisodeInfo";
            this.pnlEpisodeInfo.Size = new System.Drawing.Size(390, 29);
            this.pnlEpisodeInfo.TabIndex = 34;
            // 
            // lblUFInfo
            // 
            this.lblUFInfo.AutoSize = true;
            this.lblUFInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFInfo.Location = new System.Drawing.Point(533, 315);
            this.lblUFInfo.Name = "lblUFInfo";
            this.lblUFInfo.Size = new System.Drawing.Size(79, 13);
            this.lblUFInfo.TabIndex = 35;
            this.lblUFInfo.Text = "Anges i minuter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.lblUFInfo);
            this.Controls.Add(this.pnlEpisodeInfo);
            this.Controls.Add(this.pnlEpisodes);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategorytb);
            this.Controls.Add(this.pnlCategoriesRight);
            this.Controls.Add(this.pnlPodcastsRight);
            this.Controls.Add(this.pnlPodcastsTop);
            this.Controls.Add(this.btnShowAllPodcasts);
            this.Controls.Add(this.btnSortEpisodes);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.lbEpisodes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnSavePodcast);
            this.Controls.Add(this.btnAddPodcast);
            this.Controls.Add(this.btnRemovePodcast);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbUpdateFrequency);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdateFrequency);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.dgwPodcasts);
            this.Controls.Add(this.pnlCategoriesTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS-READER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).EndInit();
            this.pnlCategoriesTop.ResumeLayout(false);
            this.pnlCategoriesTop.PerformLayout();
            this.pnlPodcastsTop.ResumeLayout(false);
            this.pnlPodcastsTop.PerformLayout();
            this.pnlEpisodes.ResumeLayout(false);
            this.pnlEpisodeInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPodcasts;
        private Label lblUrl;
        private Label lblUpdateFrequency;
        private Label lblCategory;
        private TextBox tbUrl;
        private ComboBox cbUpdateFrequency;
        private ComboBox cbCategory;
        private Button btnRemovePodcast;
        private Button btnAddPodcast;
        private Button btnSavePodcast;
        private Label lblEpisode;
        private Label lblCategories;
        private TextBox tbCategory;
        private Button btnAddCategory;
        private Button btnSaveCategory;
        private Button btnRemoveCategory;
        private Label lblDescription;
        private TextBox tbDescription;
        private TextBox tbName;
        private Label lblName;
        private ListBox lbEpisodes;
        private ListBox lbCategories;
        private Button btnSortEpisodes;
        private Button btnShowAllPodcasts;
        private Panel pnlCategoriesTop;
        private Panel pnlPodcastsTop;
        private Label lblPodcasts;
        private Panel pnlPodcastsRight;
        private Panel pnlCategoriesRight;
        private Label lblCategorytb;
        private Panel pnlEpisodes;
        private Panel pnlEpisodeInfo;
        private DataGridViewTextBoxColumn clmEpisode;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmFrequency;
        private DataGridViewTextBoxColumn clmCategory;
        private Label lblUFInfo;
    }
}

