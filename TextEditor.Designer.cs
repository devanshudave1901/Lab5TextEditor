
namespace Lab5TextEditor
{
    partial class formTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.fileEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.fileHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.AcceptsTab = true;
            this.textBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEditor.Location = new System.Drawing.Point(0, 33);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEditor.Size = new System.Drawing.Size(800, 417);
            this.textBoxEditor.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.fileEdit,
            this.fileHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 33);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuNew,
            this.fileMenuOpen,
            this.fileMenuSave,
            this.fileMenuSaveAs,
            this.fileMenuClose,
            this.fileMenuExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 29);
            this.fileMenu.Text = "&File";
            this.fileMenu.ToolTipText = "Option to manage the files.";
            // 
            // fileMenuNew
            // 
            this.fileMenuNew.Name = "fileMenuNew";
            this.fileMenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileMenuNew.Size = new System.Drawing.Size(223, 34);
            this.fileMenuNew.Text = "&New";
            this.fileMenuNew.ToolTipText = "Creates The New File";
            this.fileMenuNew.Click += new System.EventHandler(this.NewFile);
            // 
            // fileMenuOpen
            // 
            this.fileMenuOpen.Name = "fileMenuOpen";
            this.fileMenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileMenuOpen.Size = new System.Drawing.Size(223, 34);
            this.fileMenuOpen.Text = "&Open";
            this.fileMenuOpen.ToolTipText = "Click To Open The Files";
            this.fileMenuOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // fileMenuSave
            // 
            this.fileMenuSave.Name = "fileMenuSave";
            this.fileMenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileMenuSave.Size = new System.Drawing.Size(223, 34);
            this.fileMenuSave.Text = "&Save";
            this.fileMenuSave.ToolTipText = "Click Here to Save the File";
            this.fileMenuSave.Click += new System.EventHandler(this.ClickSave);
            // 
            // fileMenuSaveAs
            // 
            this.fileMenuSaveAs.Name = "fileMenuSaveAs";
            this.fileMenuSaveAs.Size = new System.Drawing.Size(223, 34);
            this.fileMenuSaveAs.Text = "Save &As";
            this.fileMenuSaveAs.ToolTipText = "Click Here for Save As";
            this.fileMenuSaveAs.Click += new System.EventHandler(this.ClickSaveAs);
            // 
            // fileMenuClose
            // 
            this.fileMenuClose.Name = "fileMenuClose";
            this.fileMenuClose.Size = new System.Drawing.Size(223, 34);
            this.fileMenuClose.Text = "&Close";
            this.fileMenuClose.ToolTipText = "Click here toclose the file";
            this.fileMenuClose.Click += new System.EventHandler(this.CloseFile);
            // 
            // fileMenuExit
            // 
            this.fileMenuExit.Name = "fileMenuExit";
            this.fileMenuExit.Size = new System.Drawing.Size(223, 34);
            this.fileMenuExit.Text = "&Exit";
            this.fileMenuExit.ToolTipText = "Click Here to exit the editor";
            this.fileMenuExit.Click += new System.EventHandler(this.ExitFile);
            // 
            // fileEdit
            // 
            this.fileEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileEditCopy,
            this.fileEditCut,
            this.fileEditPaste});
            this.fileEdit.Name = "fileEdit";
            this.fileEdit.Size = new System.Drawing.Size(58, 29);
            this.fileEdit.Text = "&Edit";
            // 
            // fileEditCopy
            // 
            this.fileEditCopy.Name = "fileEditCopy";
            this.fileEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.fileEditCopy.Size = new System.Drawing.Size(218, 34);
            this.fileEditCopy.Text = "&Copy";
            this.fileEditCopy.ToolTipText = "Click Here to copy the File";
            this.fileEditCopy.Click += new System.EventHandler(this.CopyText);
            // 
            // fileEditCut
            // 
            this.fileEditCut.Name = "fileEditCut";
            this.fileEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileEditCut.Size = new System.Drawing.Size(218, 34);
            this.fileEditCut.Text = "&Cut";
            this.fileEditCut.ToolTipText = "Click Here to Cut the text";
            this.fileEditCut.Click += new System.EventHandler(this.CutText);
            // 
            // fileEditPaste
            // 
            this.fileEditPaste.Name = "fileEditPaste";
            this.fileEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.fileEditPaste.Size = new System.Drawing.Size(218, 34);
            this.fileEditPaste.Text = "&Paste";
            this.fileEditPaste.ToolTipText = "Click Here to Paste the text";
            this.fileEditPaste.Click += new System.EventHandler(this.PasteText);
            // 
            // fileHelp
            // 
            this.fileHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.fileHelp.Name = "fileHelp";
            this.fileHelp.Size = new System.Drawing.Size(65, 29);
            this.fileHelp.Text = "&Help";
            // 
            // helpAbout
            // 
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(164, 34);
            this.helpAbout.Text = "&About";
            this.helpAbout.ToolTipText = "Click here to get the information for this Editor";
            this.helpAbout.Click += new System.EventHandler(this.ClickAbout);
            // 
            // formTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "formTextEditor";
            this.Text = "Devanshu\'s Text Editor";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuNew;
        private System.Windows.Forms.ToolStripMenuItem fileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fileMenuClose;
        private System.Windows.Forms.ToolStripMenuItem fileMenuExit;
        private System.Windows.Forms.ToolStripMenuItem fileEdit;
        private System.Windows.Forms.ToolStripMenuItem fileEditCopy;
        private System.Windows.Forms.ToolStripMenuItem fileEditCut;
        private System.Windows.Forms.ToolStripMenuItem fileEditPaste;
        private System.Windows.Forms.ToolStripMenuItem fileHelp;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
    }
}

