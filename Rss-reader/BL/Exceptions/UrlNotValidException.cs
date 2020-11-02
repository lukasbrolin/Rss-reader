using System;
using System.Windows.Forms;

namespace BL.Exceptions
{
    public class UrlNotValidException : Exception
    {
        public UrlNotValidException():
            base("Den inmatade URL:en kan inte läsas av UrlManager")
        {
            MessageBox.Show("URL:en är inte giltig!", "Inmatningsfel");
        }
    }
}
