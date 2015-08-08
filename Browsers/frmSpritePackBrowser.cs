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
    public partial class frmSpritePackBrowser : Form
    {
        /// <summary>
        /// The currently loaded Sprite Package.
        /// </summary>
        private CSpritePack loadedSPK;
        /// <summary>
        /// The directory info for the loaded Sprite Package.
        /// </summary>
        private DirectoryInfo dirInfo;
        public frmSpritePackBrowser(CSpritePack spk, string filename)
        {
            InitializeComponent();

            loadedSPK = spk;
            dirInfo = new DirectoryInfo(filename);
            Text = WindowManager.GetTitle(dirInfo.Name, WindowManager.WindowType.SPKWindow);

            Image[] imgs = new Image[loadedSPK.Sprites.Count];

            pbSprite.Image = loadedSPK.Sprites[0].ToImage();

            foreach(CSprite spr in loadedSPK.Sprites)
            {
                lbSprites.Items.Add(spr.Name);
            }

            lbSprites.SelectedIndices.Add(0);

            UpdateStatusLabel();
        }

        public frmSpritePackBrowser(string title)
        {
            InitializeComponent();

            this.loadedSPK = new CSpritePack();

            this.Text = WindowManager.GetTitle(title, WindowManager.WindowType.SPKWindow);
        }

        public void AddSprite(CSprite spr)
        {
            loadedSPK.Sprites.Add(spr);

            lbSprites.Items.Add(spr.Name);
            lbSprites.SelectedItems.Clear();
        }

        public void RemoveSprite(int index)
        {
            loadedSPK.Sprites.RemoveAt(index);
            lbSprites.Items.RemoveAt(index);

            pbSprite.Image = null;

            UpdateStatusLabel();
        }

        private void MoveSpriteToIndex(int srcindex, int dstindex)
        {
            if (srcindex != -1 && dstindex != -1)
            {
                CSprite spr = loadedSPK.Sprites[srcindex];

                loadedSPK.Sprites.RemoveAt(srcindex);
                loadedSPK.Sprites.Insert(dstindex, spr);

                lbSprites.Items.RemoveAt(srcindex);
                lbSprites.Items.Insert(dstindex, spr.Name);

                lbSprites.SelectedIndices.Add(dstindex);

                UpdateStatusLabel();
            }
        }

        private void UpdateStatusLabel()
        {
            if (lbSprites.SelectedItems.Count > 0)
            {
                int i = lbSprites.SelectedIndex;

                string str = "Index: {0}/{1} | Resolution: {2}x{3} | Size: {4}";
                object[] objs = {i, loadedSPK.Sprites.Count - 1,loadedSPK.Sprites[i].Width,
                                    loadedSPK.Sprites[i].Height, loadedSPK.Sprites[i].ByteCount};

                tsStatusLabel.Text = String.Format(str, objs);
            }
            else
            {
                if (this.loadedSPK.Sprites.Count == 0)
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

                pbSprite.Image = loadedSPK.Sprites[i].ToImage();

                UpdateStatusLabel();
            }
        }

        private void tsmiEditExportAll_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < loadedSPK.Sprites.Count; i++)
                {
                    string str = "{0}/{1}.png";
                    object[] objs = { folderBrowserDialog.SelectedPath, loadedSPK.Sprites[i].Name };

                    loadedSPK.Sprites[i].ToImage()
                        .Save(String.Format(str, objs), System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void tsmiEditExportSelected_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var sel = lbSprites.SelectedIndices;

                for (int i = 0; i < sel.Count; i++)
                {
                    int i2 = sel[i];

                    string str = "{0}/{1}.png";
                    object[] objs = { folderBrowserDialog.SelectedPath, loadedSPK.Sprites[i2].Name };

                    loadedSPK.Sprites[i2].ToImage()
                        .Save(String.Format(str, objs), System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dirInfo == null)
                tsmiEditSave.Enabled = false;
            else
                tsmiEditSave.Enabled = true;

            if (lbSprites.SelectedItems.Count > 0)
                tsmiEditExportSelected.Enabled = true;
            else
                tsmiEditExportSelected.Enabled = false;

            if (this.loadedSPK.Sprites.Count > 0)
                tsmiEditExportAll.Enabled = true;
            else
                tsmiEditExportAll.Enabled = false;
        }

        private void tsmiEditSave_Click(object sender, EventArgs e)
        {
            loadedSPK.SaveToFile(dirInfo.FullName);
        }

        private void tsmiEditSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "SPK File|*.spk";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".spk";

            if (dirInfo != null)
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(dirInfo.FullName);
                saveFileDialog.FileName = dirInfo.Name;
            }

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dirInfo = new DirectoryInfo(saveFileDialog.FileName);
                
                Text = WindowManager.GetTitle(dirInfo.Name, WindowManager.WindowType.SPKWindow);

                loadedSPK.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void tsmiEditImportImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "PNG Files|*.png|TIFF Files|*.tiff|BMP Files|*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Length == 1)
                {
                    DirectoryInfo dir = new DirectoryInfo(openFileDialog.FileName);

                    Image img = Image.FromFile(openFileDialog.FileName);
                    CSprite spr = new CSprite(img);

                    spr.Name = dir.Name;

                    loadedSPK.Sprites.Add(spr);
                    lbSprites.Items.Add(spr.Name);
                }
                else
                {
                    foreach(string fn in openFileDialog.FileNames)
                    {
                        DirectoryInfo dir = new DirectoryInfo(fn);

                        Image img = Image.FromFile(fn);
                        CSprite spr = new CSprite(img);

                        spr.Name = dir.Name;

                        loadedSPK.Sprites.Add(spr);
                        lbSprites.Items.Add(spr.Name);
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
                if (sel[sel.Count - 1] < loadedSPK.Sprites.Count - 1) tsmiSpriteMoveDown.Enabled = true;

                tsmiSendToWindow.DropDownItems.Clear();
                foreach(frmSpritePackBrowser frm in WindowManager.spkWindows)
                {
                    if (frm != this)
                    {
                        var tsmi = new ToolStripFormItem(frm);
                        tsmi.Text = frm.Text;
                        tsmi.Click += tsmiSPKWindow_Click;

                        tsmiSendToWindow.DropDownItems.Add(tsmi);
                    }
                }

                if(tsmiSendToWindow.HasDropDownItems)
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

        private void tsmiSPKWindow_Click(object sender, EventArgs e)
        {
            var form = (sender as ToolStripFormItem).form;
            var spkform = (form as frmSpritePackBrowser);

            spkform.lbSprites.SelectedItems.Clear();

            for (int i = 0; i < lbSprites.SelectedIndices.Count; i++)
            {
                spkform.AddSprite(loadedSPK.Sprites[lbSprites.SelectedIndices[i]]);

                spkform.lbSprites.SelectedIndices.Add(spkform.lbSprites.Items.Count - 1);
            }

            spkform.lbSprites.TopIndex = spkform.lbSprites.Items.Count - 1;
            spkform.Focus();
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

            if (sel[sel.Count - 1] < loadedSPK.Sprites.Count - 1)
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
            frmSpriteSendTo form = new frmSpriteSendTo(loadedSPK.Sprites.Count - 1);

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

                    if (sel[sel.Count - 1] + o < loadedSPK.Sprites.Count)
                    {
                        int[] seli = new int[lbSprites.SelectedIndices.Count];
                        lbSprites.SelectedIndices.CopyTo(seli, 0);
                        lbSprites.SelectedIndices.Clear();
                        for (int i = 0; i < seli.Length; i++)
                        {
                            int n = seli[i];

                            MoveSpriteToIndex(n + (i*-1), n + (i*-1) + (seli.Length - 1) + o);
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

        private void frmSpritePackBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowManager.spkWindows.Remove(this);
        }
    }
}