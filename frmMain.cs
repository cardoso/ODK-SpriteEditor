using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpriteLib;

namespace Sprite_Editor
{
    public partial class frmMain : Form
    {
        public frmMain(string file)
        {
            WindowManager.spkWindows = new List<frmSpritePackBrowser>();
            WindowManager.ispkWindows = new List<frmIndexSpritePackBrowser>();
            WindowManager.sspkWindows = new List<frmShadowSpritePackBrowser>();
            WindowManager.aspkWindows = new List<frmAlphaSpritePackBrowser>();
            InitializeComponent();

            openFileDialog.FileOk += openFileDialog_FileOk;

            if(file != String.Empty)
            {
                OpenSpritePackage(file);
            }
        }

        private void OpenSpritePackage(string filename)
        {
            string ext = Path.GetExtension(filename);

            if (ext == ".spk" || ext == ".ispk" || ext == ".sspk" || ext == ".aspk")
            {
                tsStatusLabel.Text = "Loading " + filename + ". Please wait...";
                this.Refresh();

                if (ext == ".spk")
                {
                    CSpritePack spk = CSpritePackHelper.LoadFromFile(filename);

                    if (spk.Initialized)
                    {
                        frmSpritePackBrowser spkbrowser = new frmSpritePackBrowser(spk, filename);

                        WindowManager.spkWindows.Add(spkbrowser);

                        spkbrowser.MdiParent = this;
                        spkbrowser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sprite.");

                        return;
                    }
                }

                if (ext == ".ispk")
                {
                    CIndexSpritePack ispk = CIndexSpritePackHelper.LoadFromFile(filename);

                    if (ispk.Initialized)
                    {
                        frmIndexSpritePackBrowser ispkbrowser = new frmIndexSpritePackBrowser(ispk, filename);

                        WindowManager.ispkWindows.Add(ispkbrowser);

                        ispkbrowser.MdiParent = this;
                        ispkbrowser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sprite.");

                        return;
                    }


                }

                if (ext == ".sspk")
                {
                    CShadowSpritePack sspk = CShadowSpritePackHelper.LoadFromFile(filename);

                    if (sspk.Initialized)
                    {
                        frmShadowSpritePackBrowser sspkbrowser = new frmShadowSpritePackBrowser(sspk, filename);

                        WindowManager.sspkWindows.Add(sspkbrowser);

                        sspkbrowser.MdiParent = this;
                        sspkbrowser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sprite.");

                        return;
                    }
                }

                if (ext == ".aspk")
                {
                    CAlphaSpritePack aspk = CAlphaSpritePackHelper.LoadFromFile(filename);

                    if (aspk.Initialized)
                    {
                        frmAlphaSpritePackBrowser aspkbrowser = new frmAlphaSpritePackBrowser(aspk, filename);

                        WindowManager.aspkWindows.Add(aspkbrowser);

                        aspkbrowser.MdiParent = this;
                        aspkbrowser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sprite.");

                        return;
                    }
                }

                tsStatusLabel.Text = "";
            }
        }

        private void GenerateIndexFile(string[] files)
        {
            string type = Path.GetExtension(files[0]);

            if(type == ".aspk")
            {
                CAlphaSpritePack[] pkarray = new CAlphaSpritePack[files.Length];

                for (int i = 0; i < files.Length; i++)
                {
                    pkarray[i] = CAlphaSpritePackHelper.LoadFromFile(files[i]);
                }

                saveFileDialog.Filter = "ASPKI File|*.aspki";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".aspki";

                saveFileDialog.InitialDirectory = Path.GetDirectoryName(files[0]);
                saveFileDialog.FileName = "new index.aspki";

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, CAlphaSpritePackHelper.GenerateIndexFile(ref pkarray));
                }
            }

            if (type == ".ispk")
            {
                CIndexSpritePack[] pkarray = new CIndexSpritePack[files.Length];

                for (int i = 0; i < files.Length; i++)
                {
                    pkarray[i] = CIndexSpritePackHelper.LoadFromFile(files[i]);
                }

                saveFileDialog.Filter = "ISPKI File|*.ispki";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".ispki";

                saveFileDialog.InitialDirectory = Path.GetDirectoryName(files[0]);
                saveFileDialog.FileName = "new index.ispki";

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, CIndexSpritePackHelper.GenerateIndexFile(ref pkarray));
                }
            }
        }

        public void MergePacks(string[] files)
        {
            string type = Path.GetExtension(files[0]);

            if(type == ".ispk")
            {
                CIndexSpritePack respack = new CIndexSpritePack();

                foreach(string f in files)
                {
                    CIndexSpritePack pack = CIndexSpritePackHelper.LoadFromFile(f);

                    foreach(CIndexSprite s in pack.Sprites)
                        respack.Sprites.Add(s);
                }

                saveFileDialog.Filter = "ISPK File|*.ispk";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".ispk";

                saveFileDialog.InitialDirectory = Path.GetDirectoryName(files[0]);
                saveFileDialog.FileName = "new index.ispk";

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    respack.SaveToFile(saveFileDialog.FileName);
                }
            }
        }

        private void openFileDialog_FileOk(object sender, EventArgs e)
        {
            OpenFileDialog ofd = sender as OpenFileDialog;

            if (ofd.Title == "Open Sprite Pack")
            {
                OpenSpritePackage(ofd.FileName);
                return;
            }

            if (ofd.Title == "Generate Index File")
            {
                GenerateIndexFile(ofd.FileNames);
                return;
            }

            if (ofd.Title == "Merge Packs")
            {
                if (ofd.FileNames.Length > 1)
                    MergePacks(ofd.FileNames);
                else
                    MessageBox.Show("Select more than one pack!");
            }
        }

        private void msiFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Sprite Pack";
            openFileDialog.Filter = "All Sprite Pack files|*.spk;*.ispk;*.sspk;*.aspk|Sprite Pack Files|*.spk|Index Sprite Pack files|*.ispk|Shadow Sprite Pack files|*.sspk|Alpha Sprite Pack files|*.aspk";
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                OpenSpritePackage(file);
            }
        }

        private void tsmiFileNewSPK_Click(object sender, EventArgs e)
        {
            frmSpritePackBrowser frm = new frmSpritePackBrowser("New SPK");
            frm.MdiParent = this;

            WindowManager.spkWindows.Add(frm);

            frm.Show();
        }

        private void tsmiFileNewISPK_Click(object sender, EventArgs e)
        {
            frmIndexSpritePackBrowser frm = new frmIndexSpritePackBrowser("New ISPK");
            frm.MdiParent = this;

            WindowManager.ispkWindows.Add(frm);

            frm.Show();
        }

        private void tsmiFileNewASPK_Click(object sender, EventArgs e)
        {
            frmAlphaSpritePackBrowser frm = new frmAlphaSpritePackBrowser("New ASPK");
            frm.MdiParent = this;

            WindowManager.aspkWindows.Add(frm);

            frm.Show();
        }

        private void tsmiToolsGenerateIndex_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Generate Index File";
            openFileDialog.Filter = "Sprite Pack Files|*.spk|Index Sprite Pack files|*.ispk|Shadow Sprite Pack files|*.sspk|Alpha Sprite Pack files|*.aspk";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
        }

        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;

            frm.Show();
        }

        private void tsmiToolsMergePacks_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Merge Packs";
            openFileDialog.Filter = "Sprite Pack Files|*.spk|Index Sprite Pack files|*.ispk|Shadow Sprite Pack files|*.sspk|Alpha Sprite Pack files|*.aspk";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
        }
    }
}
