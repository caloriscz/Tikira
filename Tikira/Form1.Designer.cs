namespace Tikira
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.gPath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gStatus = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolViewMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelpWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextFileInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPaste = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnChooseFolder);
            this.splitContainer1.Panel2.Controls.Add(this.gPath);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 651);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 599);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(4, 27);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.Text = "Složka";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // gPath
            // 
            this.gPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.gPath.Location = new System.Drawing.Point(85, 28);
            this.gPath.Name = "gPath";
            this.gPath.Size = new System.Drawing.Size(409, 20);
            this.gPath.TabIndex = 1;
            this.gPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gPath_KeyPress);
            this.gPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gPath_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // gStatus
            // 
            this.gStatus.Location = new System.Drawing.Point(0, 629);
            this.gStatus.Name = "gStatus";
            this.gStatus.Size = new System.Drawing.Size(1000, 22);
            this.gStatus.TabIndex = 1;
            this.gStatus.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolEdit,
            this.toolView,
            this.toolTools,
            this.toolHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileOpen,
            this.toolFileExit});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(57, 20);
            this.toolFile.Text = "Soubor";
            // 
            // toolFileOpen
            // 
            this.toolFileOpen.Name = "toolFileOpen";
            this.toolFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolFileOpen.Size = new System.Drawing.Size(193, 22);
            this.toolFileOpen.Text = "Otevřít soubor";
            this.toolFileOpen.Click += new System.EventHandler(this.toolFileOpen_Click);
            // 
            // toolFileExit
            // 
            this.toolFileExit.Name = "toolFileExit";
            this.toolFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolFileExit.Size = new System.Drawing.Size(193, 22);
            this.toolFileExit.Text = "Konec";
            this.toolFileExit.Click += new System.EventHandler(this.toolFileExit_Click);
            // 
            // toolEdit
            // 
            this.toolEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEditCopy,
            this.toolEditSelectAll,
            this.toolEditDelete,
            this.toolEditPaste,
            this.toolEditCut});
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(56, 20);
            this.toolEdit.Text = "Úpravy";
            // 
            // toolEditCopy
            // 
            this.toolEditCopy.Name = "toolEditCopy";
            this.toolEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolEditCopy.Size = new System.Drawing.Size(170, 22);
            this.toolEditCopy.Text = "Kopírovat";
            this.toolEditCopy.Click += new System.EventHandler(this.toolEditCopy_Click);
            // 
            // toolEditSelectAll
            // 
            this.toolEditSelectAll.Name = "toolEditSelectAll";
            this.toolEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolEditSelectAll.Size = new System.Drawing.Size(170, 22);
            this.toolEditSelectAll.Text = "Vybrat vše";
            this.toolEditSelectAll.Click += new System.EventHandler(this.toolEditSelectAll_Click);
            // 
            // toolEditDelete
            // 
            this.toolEditDelete.Name = "toolEditDelete";
            this.toolEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolEditDelete.Size = new System.Drawing.Size(170, 22);
            this.toolEditDelete.Text = "Odstranit";
            this.toolEditDelete.Click += new System.EventHandler(this.toolEditDelete_Click);
            // 
            // toolEditPaste
            // 
            this.toolEditPaste.Name = "toolEditPaste";
            this.toolEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolEditPaste.Size = new System.Drawing.Size(170, 22);
            this.toolEditPaste.Text = "Vožit";
            this.toolEditPaste.Click += new System.EventHandler(this.toolEditPaste_Click);
            // 
            // toolEditCut
            // 
            this.toolEditCut.Name = "toolEditCut";
            this.toolEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolEditCut.Size = new System.Drawing.Size(170, 22);
            this.toolEditCut.Text = "Vyjmout";
            this.toolEditCut.Click += new System.EventHandler(this.toolEditCut_Click);
            // 
            // toolView
            // 
            this.toolView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolViewMenuStrip});
            this.toolView.Name = "toolView";
            this.toolView.Size = new System.Drawing.Size(62, 20);
            this.toolView.Text = "Zobrazit";
            // 
            // toolViewMenuStrip
            // 
            this.toolViewMenuStrip.Checked = true;
            this.toolViewMenuStrip.CheckOnClick = true;
            this.toolViewMenuStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolViewMenuStrip.Name = "toolViewMenuStrip";
            this.toolViewMenuStrip.Size = new System.Drawing.Size(147, 22);
            this.toolViewMenuStrip.Text = "Stavový řádek";
            this.toolViewMenuStrip.CheckedChanged += new System.EventHandler(this.toolViewMenuStrip_CheckedChanged);
            // 
            // toolTools
            // 
            this.toolTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolsSettings});
            this.toolTools.Name = "toolTools";
            this.toolTools.Size = new System.Drawing.Size(63, 20);
            this.toolTools.Text = "Nástroje";
            // 
            // toolToolsSettings
            // 
            this.toolToolsSettings.Name = "toolToolsSettings";
            this.toolToolsSettings.Size = new System.Drawing.Size(126, 22);
            this.toolToolsSettings.Text = "Nastavení";
            this.toolToolsSettings.Click += new System.EventHandler(this.toolToolsSettings_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelpAbout,
            this.toolHelpWebsite});
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(73, 20);
            this.toolHelp.Text = "Nápověda";
            // 
            // toolHelpAbout
            // 
            this.toolHelpAbout.Name = "toolHelpAbout";
            this.toolHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolHelpAbout.Size = new System.Drawing.Size(158, 22);
            this.toolHelpAbout.Text = "O aplikaci";
            this.toolHelpAbout.Click += new System.EventHandler(this.toolHelpAbout_Click);
            // 
            // toolHelpWebsite
            // 
            this.toolHelpWebsite.Name = "toolHelpWebsite";
            this.toolHelpWebsite.Size = new System.Drawing.Size(158, 22);
            this.toolHelpWebsite.Text = "Webová stránka";
            this.toolHelpWebsite.Click += new System.EventHandler(this.toolHelpWebsite_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextFileInfo,
            this.contextExit,
            this.contextCopy,
            this.contextDelete,
            this.contextPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 114);
            // 
            // contextFileInfo
            // 
            this.contextFileInfo.Name = "contextFileInfo";
            this.contextFileInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.contextFileInfo.Size = new System.Drawing.Size(244, 22);
            this.contextFileInfo.Text = "Informace o obrázku";
            this.contextFileInfo.Click += new System.EventHandler(this.contextFileInfo_Click);
            // 
            // contextExit
            // 
            this.contextExit.Name = "contextExit";
            this.contextExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.contextExit.Size = new System.Drawing.Size(244, 22);
            this.contextExit.Text = "Konec";
            this.contextExit.Click += new System.EventHandler(this.contextExit_Click);
            // 
            // contextCopy
            // 
            this.contextCopy.Name = "contextCopy";
            this.contextCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.contextCopy.Size = new System.Drawing.Size(244, 22);
            this.contextCopy.Text = "Kopírovat";
            this.contextCopy.Click += new System.EventHandler(this.toolEditCopy_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.contextDelete.Size = new System.Drawing.Size(244, 22);
            this.contextDelete.Text = "Odstranit";
            this.contextDelete.Click += new System.EventHandler(this.toolEditDelete_Click);
            // 
            // contextPaste
            // 
            this.contextPaste.Name = "contextPaste";
            this.contextPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.contextPaste.Size = new System.Drawing.Size(244, 22);
            this.contextPaste.Text = "Vložit";
            this.contextPaste.Click += new System.EventHandler(this.toolEditPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.gStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tikira";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip gStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripMenuItem toolHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem toolHelpWebsite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox gPath;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem toolFileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolFileExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolTools;
        private System.Windows.Forms.ToolStripMenuItem toolToolsSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextFileInfo;
        private System.Windows.Forms.ToolStripMenuItem contextExit;
        private System.Windows.Forms.ToolStripMenuItem toolView;
        private System.Windows.Forms.ToolStripMenuItem toolViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolEdit;
        private System.Windows.Forms.ToolStripMenuItem toolEditCopy;
        private System.Windows.Forms.ToolStripMenuItem toolEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolEditDelete;
        private System.Windows.Forms.ToolStripMenuItem contextCopy;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.ToolStripMenuItem toolEditPaste;
        private System.Windows.Forms.ToolStripMenuItem contextPaste;
        private System.Windows.Forms.ToolStripMenuItem toolEditCut;
    }
}

