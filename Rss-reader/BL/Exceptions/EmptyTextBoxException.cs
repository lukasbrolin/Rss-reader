using System;
using System.Windows.Forms;

namespace BL.Exceptions
{
    public class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException():
            base("Texten som skrivits in i rutan är för kort!")
        { 

        }
        public EmptyTextBoxException(string textType):
            base("Texten som skrivits in i rutan är för kort!")
        {
            MessageBox.Show(textType + " måste innehålla minst 3 tecken!", "Inmatningsfel");
        }
    }
}
