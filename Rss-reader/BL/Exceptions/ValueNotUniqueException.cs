using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BL.Exceptions
{
    public class ValueNotUniqueException : Exception
    {
        public ValueNotUniqueException():
            base("Texten som skrivits in i rutan är för kort!")
        { 
        }
        public ValueNotUniqueException(string textType):
            base("Texten som skrivits in i rutan är för kort!")
        {
            MessageBox.Show(textType + " finns redan!", "Inmatningsfel");
        }
    }
}
