namespace Sprite_Editor
{
    partial class frmIndexSpritePackBrowser
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
            this.components = new System.ComponentModel.Container();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSpriteMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpriteMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpriteMoveToIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendToWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpriteDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileImportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColorPick = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColorPStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lbSprites = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSpriteColorKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSpriteColorKeyApply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpriteColorKeyRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpriteColorKey,
            this.toolStripSeparator2,
            this.tsmiSpriteMoveUp,
            this.tsmiSpriteMoveDown,
            this.tsmiSpriteMoveToIndex,
            this.toolStripSeparator3,
            this.tsmiSendToWindow,
            this.toolStripSeparator4,
            this.tsmiSpriteDelete});
            this.cmsMain.Name = "cmsSprite";
            this.cmsMain.Size = new System.Drawing.Size(165, 176);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiSpriteMoveUp
            // 
            this.tsmiSpriteMoveUp.Name = "tsmiSpriteMoveUp";
            this.tsmiSpriteMoveUp.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteMoveUp.Text = "Move Up";
            this.tsmiSpriteMoveUp.Click += new System.EventHandler(this.tsmiSpriteMoveUp_Click);
            // 
            // tsmiSpriteMoveDown
            // 
            this.tsmiSpriteMoveDown.Name = "tsmiSpriteMoveDown";
            this.tsmiSpriteMoveDown.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteMoveDown.Text = "Move Down";
            this.tsmiSpriteMoveDown.Click += new System.EventHandler(this.tsmiSpriteMoveDown_Click);
            // 
            // tsmiSpriteMoveToIndex
            // 
            this.tsmiSpriteMoveToIndex.Name = "tsmiSpriteMoveToIndex";
            this.tsmiSpriteMoveToIndex.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteMoveToIndex.Text = "Move To Index";
            this.tsmiSpriteMoveToIndex.Click += new System.EventHandler(this.tsmiSpriteMoveToIndex_Click);
            // 
            // tsmiSendToWindow
            // 
            this.tsmiSendToWindow.Name = "tsmiSendToWindow";
            this.tsmiSendToWindow.Size = new System.Drawing.Size(164, 22);
            this.tsmiSendToWindow.Text = "Send To Window";
            // 
            // tsmiSpriteDelete
            // 
            this.tsmiSpriteDelete.Name = "tsmiSpriteDelete";
            this.tsmiSpriteDelete.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteDelete.Text = "Delete";
            this.tsmiSpriteDelete.Click += new System.EventHandler(this.tsmiSpriteDelete_Click);
            // 
            // msMain
            // 
            this.msMain.AllowMerge = false;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(749, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileSave,
            this.tsmiFileSaveAs,
            this.toolStripSeparator1,
            this.tsmiFileExport,
            this.tsmiFileImport});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            this.tsmiFile.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiFileSave
            // 
            this.tsmiFileSave.Name = "tsmiFileSave";
            this.tsmiFileSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileSave.Text = "Save";
            this.tsmiFileSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsmiFileSaveAs
            // 
            this.tsmiFileSaveAs.Name = "tsmiFileSaveAs";
            this.tsmiFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileSaveAs.Text = "Save As...";
            this.tsmiFileSaveAs.Click += new System.EventHandler(this.tsmiFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiFileExport
            // 
            this.tsmiFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileExportAll,
            this.tsmiFileExportSelected});
            this.tsmiFileExport.Name = "tsmiFileExport";
            this.tsmiFileExport.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileExport.Text = "Export";
            // 
            // tsmiFileExportAll
            // 
            this.tsmiFileExportAll.Name = "tsmiFileExportAll";
            this.tsmiFileExportAll.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileExportAll.Text = "All";
            this.tsmiFileExportAll.Click += new System.EventHandler(this.tsmiFileExportAll_Click);
            // 
            // tsmiFileExportSelected
            // 
            this.tsmiFileExportSelected.Name = "tsmiFileExportSelected";
            this.tsmiFileExportSelected.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileExportSelected.Text = "Selected";
            this.tsmiFileExportSelected.Click += new System.EventHandler(this.tsmiFileExportSelected_Click);
            // 
            // tsmiFileImport
            // 
            this.tsmiFileImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileImportImage});
            this.tsmiFileImport.Name = "tsmiFileImport";
            this.tsmiFileImport.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileImport.Text = "Import";
            // 
            // tsmiFileImportImage
            // 
            this.tsmiFileImportImage.Name = "tsmiFileImportImage";
            this.tsmiFileImportImage.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileImportImage.Text = "Image";
            this.tsmiFileImportImage.Click += new System.EventHandler(this.tsmiFileImportImage_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewBGColor,
            this.tsmiViewItemColor});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiViewBGColor
            // 
            this.tsmiViewBGColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewBGColorPick,
            this.tsmiViewBGColorPStyle});
            this.tsmiViewBGColor.Name = "tsmiViewBGColor";
            this.tsmiViewBGColor.Size = new System.Drawing.Size(168, 22);
            this.tsmiViewBGColor.Text = "Background color";
            // 
            // tsmiViewBGColorPick
            // 
            this.tsmiViewBGColorPick.Name = "tsmiViewBGColorPick";
            this.tsmiViewBGColorPick.Size = new System.Drawing.Size(152, 22);
            this.tsmiViewBGColorPick.Text = "Pick color";
            this.tsmiViewBGColorPick.Click += new System.EventHandler(this.tsmiViewBGColorPick_Click);
            // 
            // tsmiViewBGColorPStyle
            // 
            this.tsmiViewBGColorPStyle.CheckOnClick = true;
            this.tsmiViewBGColorPStyle.Image = global::Sprite_Editor.Properties.Resources.pschkbrd;
            this.tsmiViewBGColorPStyle.Name = "tsmiViewBGColorPStyle";
            this.tsmiViewBGColorPStyle.Size = new System.Drawing.Size(152, 22);
            this.tsmiViewBGColorPStyle.Text = "Invisible";
            this.tsmiViewBGColorPStyle.CheckedChanged += new System.EventHandler(this.tsmiViewBGColorPStyle_CheckedChanged);
            // 
            // tsmiViewItemColor
            // 
            this.tsmiViewItemColor.Name = "tsmiViewItemColor";
            this.tsmiViewItemColor.Size = new System.Drawing.Size(168, 22);
            this.tsmiViewItemColor.Text = "Item color";
            this.tsmiViewItemColor.Click += new System.EventHandler(this.tsmiViewItemColor_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 424);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(749, 22);
            this.ssMain.TabIndex = 3;
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lbSprites
            // 
            this.lbSprites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSprites.ContextMenuStrip = this.cmsMain;
            this.lbSprites.FormattingEnabled = true;
            this.lbSprites.Location = new System.Drawing.Point(0, 27);
            this.lbSprites.Name = "lbSprites";
            this.lbSprites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSprites.Size = new System.Drawing.Size(166, 394);
            this.lbSprites.TabIndex = 4;
            this.lbSprites.SelectedIndexChanged += new System.EventHandler(this.lbSprites_SelectedIndexChanged);
            // 
            // pbSprite
            // 
            this.pbSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSprite.BackColor = System.Drawing.Color.White;
            this.pbSprite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSprite.Location = new System.Drawing.Point(172, 27);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(577, 394);
            this.pbSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSprite.TabIndex = 0;
            this.pbSprite.TabStop = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiSpriteColorKey
            // 
            this.tsmiSpriteColorKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpriteColorKeyApply,
            this.tsmiSpriteColorKeyRemove});
            this.tsmiSpriteColorKey.Name = "tsmiSpriteColorKey";
            this.tsmiSpriteColorKey.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteColorKey.Text = "Color Key";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiSpriteColorKeyApply
            // 
            this.tsmiSpriteColorKeyApply.Name = "tsmiSpriteColorKeyApply";
            this.tsmiSpriteColorKeyApply.Size = new System.Drawing.Size(152, 22);
            this.tsmiSpriteColorKeyApply.Text = "Apply";
            this.tsmiSpriteColorKeyApply.Click += new System.EventHandler(this.tsmiSpriteColorKeyApply_Click);
            // 
            // tsmiSpriteColorKeyRemove
            // 
            this.tsmiSpriteColorKeyRemove.Name = "tsmiSpriteColorKeyRemove";
            this.tsmiSpriteColorKeyRemove.Size = new System.Drawing.Size(152, 22);
            this.tsmiSpriteColorKeyRemove.Text = "Remove";
            this.tsmiSpriteColorKeyRemove.Click += new System.EventHandler(this.tsmiSpriteColorKeyRemove_Click);
            // 
            // frmIndexSpritePackBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.lbSprites);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmIndexSpritePackBrowser";
            this.ShowIcon = false;
            this.Text = "[Index Sprite Pack Name]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIndexSpritePackBrowser_FormClosed);
            this.cmsMain.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExportAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExportSelected;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColorPick;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColorPStyle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileImportImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteMoveDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteMoveToIndex;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.ListBox lbSprites;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendToWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewItemColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteColorKey;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteColorKeyApply;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteColorKeyRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}