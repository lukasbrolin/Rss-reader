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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCategorytb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPodcasts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPodcasts.ColumnHeadersHeight = 40;
            this.dgwPodcasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwPodcasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEpisode,
            this.clmName,
            this.clmFrequency,
            this.clmCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgwPodcasts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPodcasts_CellContentClick_1);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(8, 309);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(60, 22);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL: *";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateFrequency.Location = new System.Drawing.Point(328, 308);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(205, 22);
            this.lblUpdateFrequency.TabIndex = 2;
            this.lblUpdateFrequency.Text = "Uppdateringsfrekvens: *";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(328, 355);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 22);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori: *";
            // 
            // tbUrl
            // 
            this.tbUrl.BackColor = System.Drawing.SystemColors.Window;
            this.tbUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUrl.Location = new System.Drawing.Point(12, 332);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(280, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbUpdateFrequency
            // 
            this.cbUpdateFrequency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateFrequency.FormattingEnabled = true;
            this.cbUpdateFrequency.Location = new System.Drawing.Point(332, 331);
            this.cbUpdateFrequency.Name = "cbUpdateFrequency";
            this.cbUpdateFrequency.Size = new System.Drawing.Size(280, 21);
            this.cbUpdateFrequency.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(332, 378);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(280, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemovePodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePodcast.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnRemovePodcast.Location = new System.Drawing.Point(618, 256);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(137, 33);
            this.btnRemovePodcast.TabIndex = 9;
            this.btnRemovePodcast.Text = "Ta bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = false;
            this.btnRemovePodcast.Click += new System.EventHandler(this.btnRemovePodcast_Click);
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPodcast.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnAddPodcast.Location = new System.Drawing.Point(618, 178);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(137, 33);
            this.btnAddPodcast.TabIndex = 10;
            this.btnAddPodcast.Text = "Lägg till";
            this.btnAddPodcast.UseVisualStyleBackColor = false;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSavePodcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePodcast.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnSavePodcast.Location = new System.Drawing.Point(618, 217);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.Size = new System.Drawing.Size(137, 33);
            this.btnSavePodcast.TabIndex = 11;
            this.btnSavePodcast.Text = "Spara";
            this.btnSavePodcast.UseVisualStyleBackColor = false;
            this.btnSavePodcast.Click += new System.EventHandler(this.btnSavePodcast_Click_1);
            // 
            // lblEpisode
            // 
            this.lblEpisode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblCategories.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(3, 4);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(99, 22);
            this.lblCategories.TabIndex = 15;
            this.lblCategories.Text = "Kategorier:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(780, 332);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(240, 20);
            this.tbCategory.TabIndex = 16;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnAddCategory.Location = new System.Drawing.Point(1026, 99);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(134, 42);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "Lägg till";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnSaveCategory.Location = new System.Drawing.Point(1026, 147);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnSaveCategory.TabIndex = 18;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnRemoveCategory.Location = new System.Drawing.Point(1026, 195);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbDescription.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(780, 465);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(390, 268);
            this.tbDescription.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 378);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 20);
            this.tbName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(8, 355);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 22);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Namn:";
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lbEpisodes.FormattingEnabled = true;
            this.lbEpisodes.ItemHeight = 22;
            this.lbEpisodes.Location = new System.Drawing.Point(12, 465);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(753, 268);
            this.lbEpisodes.TabIndex = 24;
            this.lbEpisodes.SelectedIndexChanged += new System.EventHandler(this.lbEpisodes_SelectedIndexChanged);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 22;
            this.lbCategories.Location = new System.Drawing.Point(780, 45);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(240, 246);
            this.lbCategories.TabIndex = 25;
            // 
            // btnSortEpisodes
            // 
            this.btnSortEpisodes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortEpisodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortEpisodes.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnSortEpisodes.Location = new System.Drawing.Point(618, 51);
            this.btnSortEpisodes.Name = "btnSortEpisodes";
            this.btnSortEpisodes.Size = new System.Drawing.Size(137, 46);
            this.btnSortEpisodes.TabIndex = 26;
            this.btnSortEpisodes.Text = "Sortera efter Kategori";
            this.btnSortEpisodes.UseVisualStyleBackColor = false;
            this.btnSortEpisodes.Click += new System.EventHandler(this.btnSortEpisodes_Click);
            // 
            // btnShowAllPodcasts
            // 
            this.btnShowAllPodcasts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllPodcasts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllPodcasts.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnShowAllPodcasts.Location = new System.Drawing.Point(618, 103);
            this.btnShowAllPodcasts.Name = "btnShowAllPodcasts";
            this.btnShowAllPodcasts.Size = new System.Drawing.Size(137, 46);
            this.btnShowAllPodcasts.TabIndex = 27;
            this.btnShowAllPodcasts.Text = "Visa alla Podcasts";
            this.btnShowAllPodcasts.UseVisualStyleBackColor = false;
            this.btnShowAllPodcasts.Click += new System.EventHandler(this.btnShowAllPodcasts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.lblCategories);
            this.panel1.Location = new System.Drawing.Point(780, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 29);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 29);
            this.panel2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kategorier:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(761, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 382);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(1166, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 382);
            this.panel4.TabIndex = 31;
            // 
            // lblCategorytb
            // 
            this.lblCategorytb.AutoSize = true;
            this.lblCategorytb.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategorytb.Location = new System.Drawing.Point(776, 309);
            this.lblCategorytb.Name = "lblCategorytb";
            this.lblCategorytb.Size = new System.Drawing.Size(131, 22);
            this.lblCategorytb.TabIndex = 32;
            this.lblCategorytb.Text = "Kategorinamn:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel5.Controls.Add(this.lblEpisode);
            this.panel5.Location = new System.Drawing.Point(12, 436);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 29);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panel6.Controls.Add(this.lblDescription);
            this.panel6.Location = new System.Drawing.Point(780, 436);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 29);
            this.panel6.TabIndex = 34;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.MinimumWidth = 8;
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Width = 160;
            // 
            // clmFrequency
            // 
            this.clmFrequency.HeaderText = "Frekvens";
            this.clmFrequency.MinimumWidth = 8;
            this.clmFrequency.Name = "clmFrequency";
            this.clmFrequency.ReadOnly = true;
            this.clmFrequency.Width = 160;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Namn";
            this.clmName.MinimumWidth = 8;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmEpisode
            // 
            this.clmEpisode.HeaderText = "Avsnitt";
            this.clmEpisode.MinimumWidth = 8;
            this.clmEpisode.Name = "clmEpisode";
            this.clmEpisode.ReadOnly = true;
            this.clmEpisode.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Anges i minuter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategorytb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rss-Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label lblCategorytb;
        private Panel panel5;
        private Panel panel6;
        private DataGridViewTextBoxColumn clmEpisode;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmFrequency;
        private DataGridViewTextBoxColumn clmCategory;
        private Label label2;
    }
}

