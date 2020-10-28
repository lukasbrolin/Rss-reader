﻿using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BL
{
    public static class Validation
    {
        // Metoderna nedan utför en specifik validering.
        public static bool TextIsFilled(TextBox textBox, string textType)
        {
            if (textBox.Text.Length <= 3)
            {
                MessageBox.Show(textType + " måste innehålla minst 3 tecken!");
                return false;
            }
            return true;
        }

        public static bool CategoryIsUnique(TextBox categoryTextBox, CategoryRepository categoryRepository)
        {
            foreach (var category in categoryRepository.GetAll())
            {
                if (categoryTextBox.Text == category.Title)
                {
                    MessageBox.Show("Den angivna kategorin finns redan!");
                    return false;
                }
            }
            return true;
        }

        public static bool UrlIsUnique(TextBox urlTextBox, PodcastRepository podcastRepository)
        {
            foreach (var podcast in podcastRepository.GetAll())
            {
                if (urlTextBox.Text == podcast.Url)
                {
                    MessageBox.Show("Den angivna URL:en finns redan!");
                    return false; }
            }
            return true;
        }

        public static bool UrlIsValid(TextBox urlTextBox)
        {
            if (UrlManager.GetTotalEpisodes(urlTextBox.Text) < 1)
            {
                MessageBox.Show("Den angivna URL:en är ogiltig!");
                return false;
            }

            return true;
        }


        public static bool UrlIsUniqueOrSame(TextBox url, PodcastRepository podcastRepository, string urlToChange)
        {

            return true;
        }

        public static bool NameIsUnique(TextBox name, PodcastRepository podcastRepository)
        {
            foreach (var podcast in podcastRepository.GetAll())
            {
                if (podcast.Name == name.Text)
                {
                    MessageBox.Show("En podcast med detta namn finns redan tillagd!");
                    return false;
                }
            }

            return true;
        }

        public static bool NameIsUniqueOrSame(TextBox name, PodcastRepository podcastRepository, string nameToChange)
        {

            return true;

        }

        public static bool comboBoxItemSelected(ComboBox comboBox, string dataTyp)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("En "+ dataTyp +" värde måste väljas!");
                return false;
            }
            return true;
        }


        // Metoderna nedan grupperar valideringsmetoderna ovan i metoder som utför flera valideringar på en gång.  
        public static bool ValidateNewName(TextBox name, PodcastRepository podcastRepository)
        {
            if (TextIsFilled(name, "Namnfältet"))
            {
                if (NameIsUnique(name, podcastRepository))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ValidateNewUrl(TextBox url, PodcastRepository podcastRepository)
        {
            if (TextIsFilled(url, "URL:en"))
            {
                if (UrlIsUnique(url, podcastRepository))
                {
                    if (UrlIsValid(url))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        //Metoderna nedan är de färdigställda metoderna som kan användas för validering!
        public static bool ValidateNewOrChangedCategory(TextBox name, CategoryRepository categoryRepository)
        {
            if (TextIsFilled(name, "Kategorin"))
            {
                if(CategoryIsUnique(name, categoryRepository))
                {
                    return true;
                }
            }
                return false;
        }

        public static bool ValidateNewPodcast(TextBox name, TextBox url, ComboBox category, ComboBox updateFrequency, PodcastRepository podcastRepository)
        {
            if (ValidateNewName(name, podcastRepository))
            {
                if (ValidateNewUrl(url, podcastRepository))
                {
                    if (comboBoxItemSelected(updateFrequency, "Uppdateringsfrekvens"))
                    {
                        if (comboBoxItemSelected(category, "kategori"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public static bool ValidateChangedPodcast(TextBox name, TextBox url, PodcastRepository podcastRepository)
        {
            


            return true;
        }
        
    }
}
