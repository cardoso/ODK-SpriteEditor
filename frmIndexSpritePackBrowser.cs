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
using SpriteLib;

namespace Sprite_Editor
{
    public partial class frmIndexSpritePackBrowser : Form
    {
        /// <summary>
        /// The currently loaded Index Sprite Package.
        /// </summary>
        private CIndexSpritePack loadedISPK;
        /// <summary>
        /// The directory info for the loaded Index Sprite Package.
        /// </summary>
        private DirectoryInfo dirInfo;

        private Color colItem;
        public frmIndexSpritePackBrowser(CIndexSpritePack ispk, string filename)
        {
            InitializeComponent();

            loadedISPK = ispk;
            dirInfo = new DirectoryInfo(filename);
            Text = WindowManager.GetTitle(dirInfo.Name, WindowManager.WindowType.ISPKWindow);

            pbSprite.Image = loadedISPK.Sprites[0].ToImage();

            foreach (CIndexSprite spr in loadedISPK.Sprites)
            {
                lbSprites.Items.Add(spr.Name);
            }

            lbSprites.SelectedIndices.Add(0);

            UpdateStatusLabel();
        }

        public frmIndexSpritePackBrowser(string title)
        {
            InitializeComponent();

            this.loadedISPK = new CIndexSpritePack();

            this.Text = WindowManager.GetTitle(title, WindowManager.WindowType.ISPKWindow);
        }

        public void AddSprite(CIndexSprite spr)
        {
            loadedISPK.Sprites.Add(spr);

            lbSprites.Items.Add(spr.Name);
            lbSprites.SelectedItems.Clear();
        }

        public void RemoveSprite(int index)
        {
            loadedISPK.Sprites.RemoveAt(index);
            lbSprites.Items.RemoveAt(index);

            pbSprite.Image = null;

            UpdateStatusLabel();
        }

        private void MoveSpriteToIndex(int srcindex, int dstindex)
        {
            if (srcindex != -1 && dstindex != -1)
            {
                CIndexSprite ispr = loadedISPK.Sprites[srcindex];

                loadedISPK.Sprites.RemoveAt(srcindex);
                loadedISPK.Sprites.Insert(dstindex, ispr);

                lbSprites.Items.RemoveAt(srcindex);
                lbSprites.Items.Insert(dstindex, ispr.Name);

                lbSprites.SelectedIndices.Add(dstindex);

                UpdateStatusLabel();
            }
        }

        private void UpdateStatusLabel()
        {
            if (lbSprites.SelectedItems.Count > 0)
            {
                int i = lbSprites.SelectedIndex;

                string str = "Index: {0}/{1} | Resolution: {2}x{3} | Size: {4} | Color keyed pixels: {5}";
                object[] objs = {i, loadedISPK.Sprites.Count - 1,loadedISPK.Sprites[i].Width,
                                    loadedISPK.Sprites[i].Height, loadedISPK.Sprites[i].ByteCount,
                                loadedISPK.Sprites[i].CKPixCount};

                tsStatusLabel.Text = String.Format(str, objs);
            }
            else
            {
                if(this.loadedISPK.Sprites.Count == 0)
                {
                    tsStatusLabel.Text = "No sprites in this package.";
                }

                tsStatusLabel.Text = "No sprite selected.";
            }
        }

        private void lbSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbSprites.SelectedIndex;
            if (i != -1)
            {
                tsStatusLabel.Text = "Loading...";
                this.Refresh();

                pbSprite.Image = loadedISPK.Sprites[i].ToImage();

                UpdateStatusLabel();
            }
        }

        private void tsmiFileExportAll_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < loadedISPK.Sprites.Count; i++)
                {

                    string str = "{0}/{1}.png";
                    object[] objs = { folderBrowserDialog.SelectedPath, lbSprites.Items[i]};

                    loadedISPK.Sprites[i].ToImage()
                        .Save(String.Format(str, objs), System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void tsmiFileExportSelected_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var sel = lbSprites.SelectedIndices;

                for (int i = 0; i < sel.Count; i++)
                {
                    int i2 = sel[i];

                    string str = "{0}/{1}.png";
                    object[] objs = { folderBrowserDialog.SelectedPath, loadedISPK.Sprites[i2].Name };

                    loadedISPK.Sprites[i2].ToImage()
                        .Save(String.Format(str, objs), System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dirInfo == null)
                tsmiFileSave.Enabled = false;
            else
                tsmiFileSave.Enabled = true;

            if (lbSprites.SelectedItems.Count > 0)
                tsmiFileExportSelected.Enabled = true;
            else
                tsmiFileExportSelected.Enabled = false;

            if (this.loadedISPK.Sprites.Count > 0)
                tsmiFileExportAll.Enabled = true;
            else
                tsmiFileExportAll.Enabled = false;
        }

        private void tsmiFileSave_Click(object sender, EventArgs e)
        {
            loadedISPK.SaveToFile(dirInfo.FullName);
        }

        private void tsmiFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "ISPK File|*.ispk";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".ispk";

            if (dirInfo != null)
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(dirInfo.FullName);
                saveFileDialog.FileName = dirInfo.Name;
            }

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dirInfo = new DirectoryInfo(saveFileDialog.FileName);

                Text = WindowManager.GetTitle(dirInfo.Name, WindowManager.WindowType.ISPKWindow);

                loadedISPK.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void tsmiFileImportImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "PNG Files|*.png|TIFF Files|*.tiff|BMP Files|*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Length == 1)
                {
                    DirectoryInfo dir = new DirectoryInfo(openFileDialog.FileName);

                    Image img = Image.FromFile(openFileDialog.FileName);
                    CIndexSprite ispr = new CIndexSprite(img);

                    ispr.Name = dir.Name;

                    loadedISPK.Sprites.Add(ispr);
                    lbSprites.Items.Add(ispr.Name);
                }
                else
                {
                    foreach(string fn in openFileDialog.FileNames)
                    {
                        DirectoryInfo dir = new DirectoryInfo(fn);

                        Image img = Image.FromFile(fn);
                        CIndexSprite ispr = new CIndexSprite(img);

                        ispr.Name = dir.Name;

                        loadedISPK.Sprites.Add(ispr);
                        lbSprites.Items.Add(ispr.Name);
                    }
                }
            }

            openFileDialog.Multiselect = false;
        }

        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            tsmiSpriteMoveUp.Enabled = false;
            tsmiSpriteMoveDown.Enabled = false;
            if (cmsMain.SourceControl == lbSprites && lbSprites.SelectedIndex > -1)
            {
                int i = lbSprites.SelectedIndex;
                if (i > 0) tsmiSpriteMoveUp.Enabled = true;

                var sel = lbSprites.SelectedIndices;
                if (sel[sel.Count - 1] < loadedISPK.Sprites.Count - 1) tsmiSpriteMoveDown.Enabled = true;

                tsmiSendToWindow.DropDownItems.Clear();
                foreach(frmIndexSpritePackBrowser frm in WindowManager.ispkWindows)
                {
                    if (frm != this)
                    {
                        var tsmi = new ToolStripFormItem(frm);
                        tsmi.Text = frm.Text;
                        tsmi.Click += tsmiISPKWindow_Click;

                        tsmiSendToWindow.DropDownItems.Add(tsmi);
                    }
                }

                if (tsmiSendToWindow.HasDropDownItems)
                {
                    tsmiSendToWindow.Enabled = true;
                }
                else
                {
                    tsmiSendToWindow.Enabled = false;
                }
            }
            else
            { e.Cancel = true; }
        }

        private void tsmiISPKWindow_Click(object sender, EventArgs e)
        {
            var form = (sender as ToolStripFormItem).form;
            var ispkform = (form as frmIndexSpritePackBrowser);

            ispkform.lbSprites.SelectedItems.Clear();

            for (int i = 0; i < lbSprites.SelectedIndices.Count; i++)
            {
                ispkform.AddSprite(loadedISPK.Sprites[lbSprites.SelectedIndices[i]]);

                ispkform.lbSprites.SelectedIndices.Add(ispkform.lbSprites.Items.Count - 1);
            }

            ispkform.lbSprites.TopIndex = ispkform.lbSprites.Items.Count - 1;
            ispkform.Focus();
        }

        private void tsmiSpriteMoveUp_Click(object sender, EventArgs e)
        {
            var sel = lbSprites.SelectedIndices;

            if (sel[0] > 0)
            {
                for (int i = 0; i < lbSprites.SelectedIndices.Count; i++)
                {
                    int n = lbSprites.SelectedIndices[i];

                    MoveSpriteToIndex(n, n - 1);
                }
            }
        }

        private void tsmiSpriteMoveDown_Click(object sender, EventArgs e)
        {
            var sel = lbSprites.SelectedIndices;

            if (sel[sel.Count - 1] < loadedISPK.Sprites.Count - 1)
            {
                for(int i = lbSprites.SelectedIndices.Count - 1; i > -1; i--)
                {
                    int n = lbSprites.SelectedIndices[i];

                    MoveSpriteToIndex(n, n + 1);
                }
            }
        }

        private void tsmiSpriteMoveToIndex_Click(object sender, EventArgs e)
        {
            frmSpriteSendTo form = new frmSpriteSendTo(loadedISPK.Sprites.Count - 1);

            form.ShowDialog();

            if (form.OK)
            {
                var sel = lbSprites.SelectedIndices;

                if (sel.Count == 1)
                {
                    MoveSpriteToIndex(sel[0], form.Index);

                    return;
                }

                if (form.Index > sel[0])
                {
                    int o = form.Index - sel[0];

                    if (sel[sel.Count - 1] + o < loadedISPK.Sprites.Count)
                    {
                        int[] seli = new int[lbSprites.SelectedIndices.Count];
                        lbSprites.SelectedIndices.CopyTo(seli, 0);
                        lbSprites.SelectedIndices.Clear();
                        for (int i = 0; i < seli.Length; i++)
                        {
                            int n = seli[i];

                            MoveSpriteToIndex(n + (i * -1), n + (i * -1) + (seli.Length - 1) + o);
                        }

                        return;
                    }
                    else
                    {
                        string msg = "You cannot move that many sprites to this index.\n" +
                            "Select fewer sprites or lower the index.";

                        MessageBox.Show(msg, "Error");

                        return;
                    }
                }

                if (form.Index < sel[0])
                {
                    int o = sel[0] - form.Index;
                    for (int i = 0; i < lbSprites.SelectedIndices.Count; i++)
                    {
                        int n = lbSprites.SelectedIndices[i];

                        MoveSpriteToIndex(n, n - o);
                    }
                }
            }
        }

        private void tsmiSpriteDelete_Click(object sender, EventArgs e)
        {
            int[] indices = new int[lbSprites.SelectedIndices.Count];
            lbSprites.SelectedIndices.CopyTo(indices, 0);

            for (int i = 0; i < indices.Length; i++)
            {
                RemoveSprite(indices[0]);
            }
        }

        private void tsmiViewBGColorPick_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbSprite.BackColor = colorDialog.Color;
            }
        }

        private void tsmiViewBGColorPStyle_CheckedChanged(object sender, EventArgs e)
        {
            bool b = tsmiViewBGColorPStyle.Checked;

            if (b)
                pbSprite.BackgroundImage = Sprite_Editor.Properties.Resources.pschkbrd;
            else
                pbSprite.BackgroundImage = null;

        }

        private void tsmiViewItemColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colItem = colorDialog.Color;
            }
        }

        private void frmIndexSpritePackBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowManager.ispkWindows.Remove(this);
        }

        private void tsmiSpriteColorKeyApply_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSpriteColorKeyRemove_Click(object sender, EventArgs e)
        {

        }
    }
}