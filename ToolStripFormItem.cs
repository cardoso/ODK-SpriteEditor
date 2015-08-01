using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite_Editor
{
    public class ToolStripFormItem : ToolStripMenuItem
    {
        public Form form { get; private set; }

        public ToolStripFormItem(Form _form)
        {
            this.form = _form;
        }
    }
}
