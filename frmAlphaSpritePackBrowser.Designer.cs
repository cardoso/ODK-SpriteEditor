namespace Sprite_Editor
{
    partial class frmAlphaSpritePackBrowser
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
            this.tsmiSpriteSendToIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendToWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpriteDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditImportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColorPick = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewBGColorPStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.lbSprites = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpriteMoveUp,
            this.tsmiSpriteMoveDown,
            this.tsmiSpriteSendToIndex,
            this.tsmiSendToWindow,
            this.tsmiSpriteDelete});
            this.cmsMain.Name = "cmsSprite";
            this.cmsMain.Size = new System.Drawing.Size(165, 114);
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
            // tsmiSpriteSendToIndex
            // 
            this.tsmiSpriteSendToIndex.Name = "tsmiSpriteSendToIndex";
            this.tsmiSpriteSendToIndex.Size = new System.Drawing.Size(164, 22);
            this.tsmiSpriteSendToIndex.Text = "Move To Index";
            this.tsmiSpriteSendToIndex.Click += new System.EventHandler(this.tsmiSpriteMoveToIndex_Click);
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
            this.tsmiEdit,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(749, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditSave,
            this.tsmiEditSaveAs,
            this.toolStripSeparator1,
            this.tsmiEditExport,
            this.tsmiEditImport});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiEditSave
            // 
            this.tsmiEditSave.Name = "tsmiEditSave";
            this.tsmiEditSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditSave.Text = "Save";
            this.tsmiEditSave.Click += new System.EventHandler(this.tsmiEditSave_Click);
            // 
            // tsmiEditSaveAs
            // 
            this.tsmiEditSaveAs.Name = "tsmiEditSaveAs";
            this.tsmiEditSaveAs.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditSaveAs.Text = "Save As...";
            this.tsmiEditSaveAs.Click += new System.EventHandler(this.tsmiEditSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiEditExport
            // 
            this.tsmiEditExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditExportAll,
            this.tsmiEditExportSelected});
            this.tsmiEditExport.Name = "tsmiEditExport";
            this.tsmiEditExport.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditExport.Text = "Export";
            // 
            // tsmiEditExportAll
            // 
            this.tsmiEditExportAll.Name = "tsmiEditExportAll";
            this.tsmiEditExportAll.Size = new System.Drawing.Size(118, 22);
            this.tsmiEditExportAll.Text = "All";
            this.tsmiEditExportAll.Click += new System.EventHandler(this.tsmiEditExportAll_Click);
            // 
            // tsmiEditExportSelected
            // 
            this.tsmiEditExportSelected.Name = "tsmiEditExportSelected";
            this.tsmiEditExportSelected.Size = new System.Drawing.Size(118, 22);
            this.tsmiEditExportSelected.Text = "Selected";
            this.tsmiEditExportSelected.Click += new System.EventHandler(this.tsmiEditExportSelected_Click);
            // 
            // tsmiEditImport
            // 
            this.tsmiEditImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditImportImage});
            this.tsmiEditImport.Name = "tsmiEditImport";
            this.tsmiEditImport.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditImport.Text = "Import";
            // 
            // tsmiEditImportImage
            // 
            this.tsmiEditImportImage.Name = "tsmiEditImportImage";
            this.tsmiEditImportImage.Size = new System.Drawing.Size(107, 22);
            this.tsmiEditImportImage.Text = "Image";
            this.tsmiEditImportImage.Click += new System.EventHandler(this.tsmiEditImportImage_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewBGColor});
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
            this.tsmiViewBGColorPick.Size = new System.Drawing.Size(126, 22);
            this.tsmiViewBGColorPick.Text = "Pick color";
            this.tsmiViewBGColorPick.Click += new System.EventHandler(this.tsmiViewBGColorPick_Click);
            // 
            // tsmiViewBGColorPStyle
            // 
            this.tsmiViewBGColorPStyle.CheckOnClick = true;
            this.tsmiViewBGColorPStyle.Image = global::Sprite_Editor.Properties.Resources.pschkbrd;
            this.tsmiViewBGColorPStyle.Name = "tsmiViewBGColorPStyle";
            this.tsmiViewBGColorPStyle.Size = new System.Drawing.Size(126, 22);
            this.tsmiViewBGColorPStyle.Text = "Invisible";
            this.tsmiViewBGColorPStyle.CheckedChanged += new System.EventHandler(this.tsmiViewBGColorPStyle_CheckedChanged);
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
            // frmSpritePackBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.lbSprites);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmSpritePackBrowser";
            this.ShowIcon = false;
            this.Text = "[Sprite Pack Name]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSpritePackBrowser_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditExportAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditExportSelected;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColorPick;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewBGColorPStyle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditImportImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteMoveDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpriteSendToIndex;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.ListBox lbSprites;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendToWindow;
    }
}