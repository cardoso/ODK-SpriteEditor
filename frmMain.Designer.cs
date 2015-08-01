namespace Sprite_Editor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNewSPK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNewISPK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNewSSPK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNewASPK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolsGenerateIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tsmiToolsMergePacks = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile,
            this.tsmiTools,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiFileOpen,
            this.tsmiFileNew});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(37, 20);
            this.msiFile.Text = "File";
            // 
            // tmsiFileOpen
            // 
            this.tmsiFileOpen.Name = "tmsiFileOpen";
            this.tmsiFileOpen.Size = new System.Drawing.Size(103, 22);
            this.tmsiFileOpen.Text = "Open";
            this.tmsiFileOpen.Click += new System.EventHandler(this.msiFileOpen_Click);
            // 
            // tsmiFileNew
            // 
            this.tsmiFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileNewSPK,
            this.tsmiFileNewISPK,
            this.tsmiFileNewSSPK,
            this.tsmiFileNewASPK});
            this.tsmiFileNew.Name = "tsmiFileNew";
            this.tsmiFileNew.Size = new System.Drawing.Size(103, 22);
            this.tsmiFileNew.Text = "New";
            // 
            // tsmiFileNewSPK
            // 
            this.tsmiFileNewSPK.Name = "tsmiFileNewSPK";
            this.tsmiFileNewSPK.Size = new System.Drawing.Size(123, 22);
            this.tsmiFileNewSPK.Text = "SPK File";
            this.tsmiFileNewSPK.Click += new System.EventHandler(this.tsmiFileNewSPK_Click);
            // 
            // tsmiFileNewISPK
            // 
            this.tsmiFileNewISPK.Name = "tsmiFileNewISPK";
            this.tsmiFileNewISPK.Size = new System.Drawing.Size(123, 22);
            this.tsmiFileNewISPK.Text = "ISPK File";
            this.tsmiFileNewISPK.Click += new System.EventHandler(this.tsmiFileNewISPK_Click);
            // 
            // tsmiFileNewSSPK
            // 
            this.tsmiFileNewSSPK.Name = "tsmiFileNewSSPK";
            this.tsmiFileNewSSPK.Size = new System.Drawing.Size(123, 22);
            this.tsmiFileNewSSPK.Text = "SSPK File";
            // 
            // tsmiFileNewASPK
            // 
            this.tsmiFileNewASPK.Name = "tsmiFileNewASPK";
            this.tsmiFileNewASPK.Size = new System.Drawing.Size(123, 22);
            this.tsmiFileNewASPK.Text = "ASPK File";
            this.tsmiFileNewASPK.Click += new System.EventHandler(this.tsmiFileNewASPK_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolsGenerateIndex,
            this.tsmiToolsMergePacks});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(48, 20);
            this.tsmiTools.Text = "Tools";
            // 
            // tsmiToolsGenerateIndex
            // 
            this.tsmiToolsGenerateIndex.Name = "tsmiToolsGenerateIndex";
            this.tsmiToolsGenerateIndex.Size = new System.Drawing.Size(152, 22);
            this.tsmiToolsGenerateIndex.Text = "Generate Index";
            this.tsmiToolsGenerateIndex.Click += new System.EventHandler(this.tsmiToolsGenerateIndex_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiHelpAbout.Text = "About";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.tsmiHelpAbout_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "spk";
            this.openFileDialog.Filter = "All Sprite Pack files|*.spk;*.ispk;*.sspk;*.aspk|Sprite Pack Files|*.spk|Index Sp" +
    "rite Pack files|*.ispk|Shadow Sprite Pack files|*.sspk|Alpha Sprite Pack files|*" +
    ".aspk";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsmiToolsMergePacks
            // 
            this.tsmiToolsMergePacks.Name = "tsmiToolsMergePacks";
            this.tsmiToolsMergePacks.Size = new System.Drawing.Size(152, 22);
            this.tsmiToolsMergePacks.Text = "Merge Packs";
            this.tsmiToolsMergePacks.Click += new System.EventHandler(this.tsmiToolsMergePacks_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Sprite Editor 0.3 Beta - Open DarkEden";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem tmsiFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNewSPK;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNewISPK;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNewSSPK;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNewASPK;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolsGenerateIndex;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolsMergePacks;

    }
}

