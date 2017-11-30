using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MapEditor
{
    public partial class ColourPicker : Form
    {
        public Color colour;
        public int red;
        public int green;
        public int blue;
        
        public ColourPicker(int currentRed, int currentGreen, int currentBlue)
        {
            InitializeComponent();

            trackBarRed.Value = currentRed;
            trackBarGreen.Value = currentGreen;
            trackBarBlue.Value = currentBlue;
            
            panelCustomColourSample.Invalidate();

        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelRed.Text = tb.Value.ToString();
            red = tb.Value;

            panelCustomColourSample.Invalidate();

        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelGreen.Text = tb.Value.ToString();
            green = tb.Value;

            panelCustomColourSample.Invalidate();

        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            labelBlue.Text = tb.Value.ToString();
            blue = tb.Value;

            panelCustomColourSample.Invalidate();
            
        }

        private void panelCustomColourSample_Paint(object sender, PaintEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            colour = Color.FromArgb(red, green, blue);
            panel.BackColor = colour;
            
        }
        
    }

}
