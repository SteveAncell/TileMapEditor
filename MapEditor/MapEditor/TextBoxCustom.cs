using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    class TextBoxCustom : TextBox
    {
        public string storedText;

        public void StoreText()
        {
            this.storedText = this.Text;

        }
        
        public void RevertText()
        {
            this.Text = this.storedText;

        }

    }

}
