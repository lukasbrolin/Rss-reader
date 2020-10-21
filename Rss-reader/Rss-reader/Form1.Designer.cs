﻿using System.Windows.Forms;

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
            this.dgwPodcasts = new System.Windows.Forms.DataGridView();
            this.clmEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnRemovePodcast = new System.Windows.Forms.Button();
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.btnSavePodcast = new System.Windows.Forms.Button();
            this.lwEpisodes = new System.Windows.Forms.ListView();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.lwCategories = new System.Windows.Forms.ListView();
            this.lblCategories = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodcasts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPodcasts
            // 
            this.dgwPodcasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPodcasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEpisode,
            this.clmName,
            this.clmFrequency,
            this.clmCategory});
            this.dgwPodcasts.Location = new System.Drawing.Point(12, 12);
            this.dgwPodcasts.MaximumSize = new System.Drawing.Size(600, 250);
            this.dgwPodcasts.Name = "dgwPodcasts";
            this.dgwPodcasts.RowHeadersVisible = false;
            this.dgwPodcasts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwPodcasts.Size = new System.Drawing.Size(600, 250);
            this.dgwPodcasts.TabIndex = 0;
            // 
            // clmEpisode
            // 
            this.clmEpisode.HeaderText = "Avsnitt";
            this.clmEpisode.Name = "clmEpisode";
            this.clmEpisode.Width = 80;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Namn";
            this.clmName.Name = "clmName";
            this.clmName.Width = 200;
            // 
            // clmFrequency
            // 
            this.clmFrequency.HeaderText = "Frekvens";
            this.clmFrequency.Name = "clmFrequency";
            this.clmFrequency.Width = 160;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.Width = 160;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(12, 289);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(50, 20);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFrequency.Location = new System.Drawing.Point(255, 289);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(190, 20);
            this.lblUpdateFrequency.TabIndex = 2;
            this.lblUpdateFrequency.Text = "Uppdateringsfrekvens:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(471, 289);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(475, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.Location = new System.Drawing.Point(521, 339);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(91, 33);
            this.btnRemovePodcast.TabIndex = 9;
            this.btnRemovePodcast.Text = "Ta bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = true;
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(259, 339);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(117, 33);
            this.btnAddPodcast.TabIndex = 10;
            this.btnAddPodcast.Text = "Lägg till";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.Location = new System.Drawing.Point(396, 339);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.Size = new System.Drawing.Size(91, 33);
            this.btnSavePodcast.TabIndex = 11;
            this.btnSavePodcast.Text = "Spara";
            this.btnSavePodcast.UseVisualStyleBackColor = true;
            // 
            // lwEpisodes
            // 
            this.lwEpisodes.HideSelection = false;
            this.lwEpisodes.Location = new System.Drawing.Point(16, 409);
            this.lwEpisodes.Name = "lwEpisodes";
            this.lwEpisodes.Size = new System.Drawing.Size(596, 260);
            this.lwEpisodes.TabIndex = 12;
            this.lwEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(12, 386);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(0, 20);
            this.lblEpisode.TabIndex = 13;
            // 
            // lwCategories
            // 
            this.lwCategories.HideSelection = false;
            this.lwCategories.Location = new System.Drawing.Point(630, 39);
            this.lwCategories.Name = "lwCategories";
            this.lwCategories.Size = new System.Drawing.Size(422, 223);
            this.lwCategories.TabIndex = 14;
            this.lwCategories.UseCompatibleStateImageBehavior = false;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(626, 12);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(97, 20);
            this.lblCategories.TabIndex = 15;
            this.lblCategories.Text = "Kategorier:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 20);
            this.textBox2.TabIndex = 16;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(630, 303);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(136, 42);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "Lägg till";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(778, 303);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnSaveCategory.TabIndex = 18;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(918, 303);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(134, 42);
            this.btnRemoveCategory.TabIndex = 19;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(628, 409);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(424, 20);
            this.lblDescription.TabIndex = 20;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Location = new System.Drawing.Point(632, 432);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(420, 237);
            this.tbDescription.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lwCategories);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lwEpisodes);
            this.Controls.Add(this.btnSavePodcast);
            this.Controls.Add(this.btnAddPodcast);
            this.Controls.Add(this.btnRemovePodcast);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdateFrequency);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.dgwPodcasts);
            this.Name = "Form1";
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
        private Label lblURL;
        private Label lblUpdateFrequency;
        private Label lblCategory;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnRemovePodcast;
        private Button btnAddPodcast;
        private Button btnSavePodcast;
        private ListView lwEpisodes;
        private Label lblEpisode;
        private ListView lwCategories;
        private Label lblCategories;
        private TextBox textBox2;
        private Button btnAddCategory;
        private Button btnSaveCategory;
        private Button btnRemoveCategory;
        private Label lblDescription;
        private TextBox tbDescription;
    }
}

