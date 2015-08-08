using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sprite_Editor
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            rtbAbout.SelectionAlignment = HorizontalAlignment.Center;
            rtbAbout.SelectionFont = new Font("Tahoma", 20, FontStyle.Regular);

            rtbAbout.SelectedText = "Sprite Editor - Beta 0.3\n";

            rtbAbout.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);

            rtbAbout.SelectedText = "An OpenDarkEden project.\n";

            rtbAbout.SelectionAlignment = HorizontalAlignment.Left;
            rtbAbout.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
            rtbAbout.SelectedText = "\n";
            rtbAbout.SelectedText = "This is a sprite editor for the DarkEden game.\n\n";
            rtbAbout.SelectedText = "It's still in beta, so there are more features to come and bugs to be fixed.\n";
            rtbAbout.SelectedText = "If you want to contact me, report a bug or download a newer version please refer to http://falcoinvictus.com/forum\n";
            rtbAbout.SelectedText = "It's where i'll be answering questions, taking suggestions and bug reports for the time being.\n\n";
            rtbAbout.SelectedText = "Features:\n\n";
            rtbAbout.SelectedText = "SPK Editing.\n";
            rtbAbout.SelectedText = "ISPK Editing. (Chroma Key Support - NEW)\n";
            rtbAbout.SelectedText = "SSPK Editing.\n";
            rtbAbout.SelectedText = "ASPK Editing.\n";
            rtbAbout.SelectedText = "Transparency support.\n";
            rtbAbout.SelectedText = "Convert from PNG/TIFF/BMP.\n\n";
            rtbAbout.SelectedText = "Version: Beta 0.3\n";
            rtbAbout.SelectedText = "Developer: Matheus M. Cardoso";
        }
    }
}