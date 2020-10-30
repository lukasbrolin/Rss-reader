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
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPodcasts
            // 
            this.dgwPodcasts.AllowUserToAddRows = false;
            this.dgwPodcasts.AllowUserToDeleteRows = false;
            this.dgwPodcasts.AllowUserToResizeColumns = false;
            this.dgwPodcasts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPodcasts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPodcasts.ColumnHeadersHeight = 50;
            this.dgwPodcasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwPodcasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEpisode,
            this.clmName,
            this.clmFrequency,
            this.clmCategory});
            this.dgwPodcasts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPodcasts.Location = new System.Drawing.Point(12, 12);
            this.dgwPodcasts.MaximumSize = new System.Drawing.Size(600, 250);
            this.dgwPodcasts.MultiSelect = false;
            this.dgwPodcasts.Name = "dgwPodcasts";
            this.dgwPodcasts.ReadOnly = true;
            this.dgwPodcasts.RowHeadersVisible = false;
            this.dgwPodcasts.RowHeadersWidth = 62;
            this.dgwPodcasts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwPodcasts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgwPodcasts.RowTemplate.Height = 40;
            this.dgwPodcasts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPodcasts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwPodcasts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPodcasts.Size = new System.Drawing.Size(600, 250);
            this.dgwPodcasts.TabIndex = 0;
            this.dgwPodcasts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPodcasts_CellContentClick_1);
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
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(12, 289);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(62, 20);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL: *";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFrequency.Location = new System.Drawing.Point(255, 289);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(202, 20);
            this.lblUpdateFrequency.TabIndex = 2;
            this.lblUpdateFrequency.Text = "Uppdateringsfrekvens: *";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(471, 289);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori: *";
            // 
            // tbUrl
            // 
            this.tbUrl.BackColor = System.Drawing.SystemColors.Window;
            this.tbUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbUrl.Location = new System.Drawing.Point(16, 312);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(211, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbUpdateFrequency
            // 
            this.cbUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateFrequency.FormattingEnabled = true;
            this.cbUpdateFrequency.Location = new System.Drawing.Point(259, 312);
            this.cbUpdateFrequency.Name = "cbUpdateFrequency";
            this.cbUpdateFrequency.Size = new System.Drawing.Size(186, 21);
            this.cbUpdateFrequency.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(475, 312);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(137, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.Location = new System.Drawing.Point(521, 345);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(91, 33);
            this.btnRemovePodcast.TabIndex = 9;
            this.btnRemovePodcast.Text = "Ta bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = true;
            this.btnRemovePodcast.Click += new System.EventHandler(this.btnRemovePodcast_Click);
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(259, 345);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(117, 33);
            this.btnAddPodcast.TabIndex = 10;
            this.btnAddPodcast.Text = "Lägg till";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.Location = new System.Drawing.Point(396, 345);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.Size = new System.Drawing.Size(91, 33);
            this.btnSavePodcast.TabIndex = 11;
            this.btnSavePodcast.Text = "Spara";
            this.btnSavePodcast.UseVisualStyleBackColor = true;
            this.btnSavePodcast.Click += new System.EventHandler(this.btnSavePodcast_Click_1);
            // 
            // lblEpisode
            // 
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(16, 386);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(596, 20);
            this.lblEpisode.TabIndex = 13;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(626, 65);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(97, 20);
            this.lblCategories.TabIndex = 15;
            this.lblCategories.Text = "Kategorier:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(630, 277);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(422, 20);
            this.tbCategory.TabIndex = 16;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(630, 303);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(136, 42);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "Lägg till";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(778, 303);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnSaveCategory.TabIndex = 18;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(918, 303);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(632, 386);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(420, 20);
            this.lblDescription.TabIndex = 20;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Location = new System.Drawing.Point(632, 409);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(420, 268);
            this.tbDescription.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 358);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 20);
            this.tbName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 335);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Namn:";
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpisodes.FormattingEnabled = true;
            this.lbEpisodes.ItemHeight = 24;
            this.lbEpisodes.Location = new System.Drawing.Point(16, 409);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(596, 268);
            this.lbEpisodes.TabIndex = 24;
            this.lbEpisodes.SelectedIndexChanged += new System.EventHandler(this.lbEpisodes_SelectedIndexChanged);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 24;
            this.lbCategories.Location = new System.Drawing.Point(628, 90);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(424, 172);
            this.lbCategories.TabIndex = 25;
            // 
            // btnSortEpisodes
            // 
            this.btnSortEpisodes.Location = new System.Drawing.Point(628, 16);
            this.btnSortEpisodes.Name = "btnSortEpisodes";
            this.btnSortEpisodes.Size = new System.Drawing.Size(137, 46);
            this.btnSortEpisodes.TabIndex = 26;
            this.btnSortEpisodes.Text = "Sortera efter Kategori";
            this.btnSortEpisodes.UseVisualStyleBackColor = true;
            this.btnSortEpisodes.Click += new System.EventHandler(this.btnSortEpisodes_Click);
            // 
            // btnShowAllPodcasts
            // 
            this.btnShowAllPodcasts.Location = new System.Drawing.Point(778, 16);
            this.btnShowAllPodcasts.Name = "btnShowAllPodcasts";
            this.btnShowAllPodcasts.Size = new System.Drawing.Size(137, 46);
            this.btnShowAllPodcasts.TabIndex = 27;
            this.btnShowAllPodcasts.Text = "Visa alla Podcasts";
            this.btnShowAllPodcasts.UseVisualStyleBackColor = true;
            this.btnShowAllPodcasts.Click += new System.EventHandler(this.btnShowAllPodcasts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 690);
            this.Controls.Add(this.btnShowAllPodcasts);
            this.Controls.Add(this.btnSortEpisodes);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.lbEpisodes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblEpisode);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPodcasts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEpisode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategory;
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
    }
}

