using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BL.Exceptions
{
    public class ValueNotUniqueException : Exception
    {
        public ValueNotUniqueException():
            base("Inputen från användaren finns redan i ett annat objekt!")
        { 
        }
        public ValueNotUniqueException(string textType):
            base("TeInputen från användaren finns redan i ett annat objekt!")
        {
            MessageBox.Show(textType + " finns redan!", "Inmatningsfel");
        }
    }
}
