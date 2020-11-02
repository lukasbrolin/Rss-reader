using System;
using System.Windows.Forms;

namespace BL.Exceptions
{
    public class NoItemSelectedException : Exception
    {
        public NoItemSelectedException():
            base("Inget objekt valdes!")
        { 
        }
        public NoItemSelectedException(string textType):
            base("Inget objekt valdes!")
        {
            MessageBox.Show("En " + textType + " måste väljas!");
        }
    }
}
