﻿using BL.Exceptions;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BL
{
    public static class Validation
    {
        // Metoderna nedan utför en specifik validering.
        public static bool TextIsFilled(TextBox textBox, string textType)
        {
            try
            {
                if (textBox.Text.Length <= 2)
                {
                    throw new EmptyTextBoxException(textType);
                }
                return true;
            }
            catch (EmptyTextBoxException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool NameIsUnique(TextBox name, List<Podcast> podcastList)
        {
            try
            {
                foreach (var podcast in podcastList)
                {
                    if (podcast.Name == name.Text)
                    {
                        throw new ValueNotUniqueException("En podcast med detta namn");
                    }
                }
                return true;

            }
            catch (ValueNotUniqueException e){
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool CategoryIsUnique(TextBox categoryTextBox, List<Category> categoryList)
        {
            try
            {
                foreach (var category in categoryList)
                {
                    if (categoryTextBox.Text == category.Title)
                    {
                        throw new ValueNotUniqueException("Den angivna kategorin");
                    }
                }
                return true;
            }
            catch (ValueNotUniqueException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool UrlIsUnique(TextBox urlTextBox, List<Podcast> podcastList)
        {
            try
            {
                foreach (var podcast in podcastList)
                {
                    if (urlTextBox.Text == podcast.Url)
                    {
                        throw new ValueNotUniqueException("En podcast med den angivna URL:en");
                    }
                }
                return true;
            }
            catch (ValueNotUniqueException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool UrlIsValid(TextBox urlTextBox)
        {
            try
            {
                if (UrlManager.GetTotalEpisodesCount(urlTextBox.Text) < 1)
                {
                    throw new UrlNotValidException();
                }
                return true;
            }
            catch(UrlNotValidException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }

        public static bool ComboBoxItemSelected(ComboBox comboBox, string dataTyp)
        {
            try
            {
                if (comboBox.SelectedItem == null)
                {
                    throw new NoItemSelectedException(dataTyp);
                }
                return true;
            }
            catch (NoItemSelectedException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static bool ListBoxItemSelected(ListBox listBox, string dataTyp)
        {
            try
            {
                if (listBox.SelectedItem == null)
                {
                    throw new NoItemSelectedException(dataTyp);
                }
                return true;
            }
            catch (NoItemSelectedException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool UrlIsUnchanged(TextBox url, string oldPodcastUrl)
        {
            if (!url.Text.Equals(oldPodcastUrl))
            {
                return false;
            }
            return true;
        }

        public static bool NameIsUnchanged(TextBox name, string oldPodcastName)
        {
            if (!name.Text.Equals(oldPodcastName))
            {
                return false;
            }
            return true;
        }

        // Metoderna nedan grupperar valideringsmetoderna ovan i metoder som utför flera valideringar på en gång.  
        public static bool ValidateNewName(TextBox name, List<Podcast> podcastList)
        {
            if (TextIsFilled(name, "Namnet"))
            {
                if (NameIsUnique(name, podcastList))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidateNewUrl(TextBox url, List<Podcast> podcastList)
        {
            if (TextIsFilled(url, "URL:en"))
            {
                if (UrlIsUnique(url, podcastList))
                {
                    if (UrlIsValid(url))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidateChangedUrl(TextBox url, List<Podcast> podcastList, string oldPodcastUrl)
        {
            if(TextIsFilled(url, "URL:en"))
            {
                if (UrlIsUnchanged(url, oldPodcastUrl) || UrlIsUnique(url, podcastList))
                {
                    if (UrlIsValid(url))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ValidateChangedName(TextBox name, List<Podcast> podcastList, string oldPodcastName)
        {
            if(TextIsFilled(name, "Namnet"))
            {
                if(NameIsUnchanged(name, oldPodcastName) || NameIsUnique(name, podcastList))
                {
                    return true;
                }
            }
            return false;
        }

        //Metoderna nedan är de färdigställda metoderna som kan användas för validering!
        public static bool ValidateNewCategory(TextBox name, List<Category> categoryList)
        {
            if (TextIsFilled(name, "Kategorin"))
            {
                if(CategoryIsUnique(name, categoryList))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidateChangedCategory(TextBox name, ListBox category, List<Category> categoryList)
        {
            if (TextIsFilled(name, "Kategorin"))
            {
                if (ListBoxItemSelected(category, "kategori"))
                {
                    if (CategoryIsUnique(name, categoryList))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public static bool ValidateNewPodcast(TextBox name, TextBox url, ComboBox category, ComboBox updateFrequency, List<Podcast> podcastList)
        {
            if (ValidateNewName(name, podcastList))
            {
                if (ValidateNewUrl(url, podcastList))
                {
                    if (ComboBoxItemSelected(updateFrequency, "uppdateringsfrekvens"))
                    {
                        if (ComboBoxItemSelected(category, "kategori"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool ValidateChangedPodcast(TextBox name, TextBox url, List<Podcast> podcastList, ComboBox category, ComboBox updateFrequency, string oldPodcastName, string oldPodcastUrl)
        {
            if (ValidateChangedName(name, podcastList, oldPodcastName))
            {
                if(ValidateChangedUrl(url, podcastList, oldPodcastUrl))
                {
                    if(ComboBoxItemSelected(updateFrequency, "uppdateringsfrekvens"))
                    {
                        if(ComboBoxItemSelected(category, "kategori"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
    }
}