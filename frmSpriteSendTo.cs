using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite_Editor
{
    public partial class frmSpriteSendTo : Form
    {
        public int Index;

        private int maxIndex;

        public bool OK = false;
        public frmSpriteSendTo(int _maxIndex)
        {
            maxIndex = _maxIndex;

            InitializeComponent();

            btnSend.Enabled = false;
        }

        private void tbSend_TextChanged(object sender, EventArgs e)
        {
            if (tbSend.Text.Length > 0)
            {
                if (Convert.ToInt32(tbSend.Text) > maxIndex || tbSend.Text.Length < 1)
                    btnSend.Enabled = false;
                else
                    btnSend.Enabled = true;
            }
            else
                btnSend.Enabled = false;
        }

        private void tbSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Index = Convert.ToInt32(tbSend.Text);
            OK = true;

            this.Close();
        }
    }
}
