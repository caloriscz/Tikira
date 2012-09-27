namespace Tikira
{
    partial class Form2
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
            this.gStatusE = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdjustments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdjustmentsSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdjustmentsInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolsRotate90R = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureEditor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // gStatusE
            // 
            this.gStatusE.Location = new System.Drawing.Point(0, 540);
            this.gStatusE.Name = "gStatusE";
            this.gStatusE.Size = new System.Drawing.Size(934, 22);
            this.gStatusE.TabIndex = 0;
            this.gStatusE.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolAdjustments,
            this.toolTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileSave,
            this.toolFileSaveAs,
            this.toolFileExit});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(57, 20);
            this.toolFile.Text = "Soubor";
            // 
            // toolFileSave
            // 
            this.toolFileSave.Name = "toolFileSave";
            this.toolFileSave.Size = new System.Drawing.Size(152, 22);
            this.toolFileSave.Text = "Uložit";
            this.toolFileSave.Click += new System.EventHandler(this.toolFileSave_Click);
            // 
            // toolFileSaveAs
            // 
            this.toolFileSaveAs.Name = "toolFileSaveAs";
            this.toolFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.toolFileSaveAs.Text = "Uložit jako...";
            this.toolFileSaveAs.Click += new System.EventHandler(this.toolFileSaveAs_Click);
            // 
            // toolFileExit
            // 
            this.toolFileExit.Name = "toolFileExit";
            this.toolFileExit.Size = new System.Drawing.Size(152, 22);
            this.toolFileExit.Text = "Konec";
            this.toolFileExit.Click += new System.EventHandler(this.toolFileExit_Click);
            // 
            // toolAdjustments
            // 
            this.toolAdjustments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdjustmentsSepia,
            this.toolAdjustmentsInversion});
            this.toolAdjustments.Name = "toolAdjustments";
            this.toolAdjustments.Size = new System.Drawing.Size(56, 20);
            this.toolAdjustments.Text = "Úpravy";
            // 
            // toolTools
            // 
            this.toolTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolsRotate90R});
            this.toolTools.Name = "toolTools";
            this.toolTools.Size = new System.Drawing.Size(63, 20);
            this.toolTools.Text = "Nástroje";
            // 
            // toolAdjustmentsSepia
            // 
            this.toolAdjustmentsSepia.Name = "toolAdjustmentsSepia";
            this.toolAdjustmentsSepia.Size = new System.Drawing.Size(152, 22);
            this.toolAdjustmentsSepia.Text = "Sepia";
            this.toolAdjustmentsSepia.Click += new System.EventHandler(this.toolAdjustmentsSepia_Click);
            // 
            // toolAdjustmentsInversion
            // 
            this.toolAdjustmentsInversion.Name = "toolAdjustmentsInversion";
            this.toolAdjustmentsInversion.Size = new System.Drawing.Size(152, 22);
            this.toolAdjustmentsInversion.Text = "Inverze";
            this.toolAdjustmentsInversion.Click += new System.EventHandler(this.toolAdjustmentsInversion_Click);
            // 
            // toolToolsRotate90R
            // 
            this.toolToolsRotate90R.Name = "toolToolsRotate90R";
            this.toolToolsRotate90R.Size = new System.Drawing.Size(183, 22);
            this.toolToolsRotate90R.Text = "Otočit o 90s doprava";
            this.toolToolsRotate90R.Click += new System.EventHandler(this.toolToolsRotate90R_Click);
            // 
            // pictureEditor
            // 
            this.pictureEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEditor.Location = new System.Drawing.Point(0, 24);
            this.pictureEditor.Name = "pictureEditor";
            this.pictureEditor.Size = new System.Drawing.Size(934, 516);
            this.pictureEditor.TabIndex = 2;
            this.pictureEditor.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.pictureEditor);
            this.Controls.Add(this.gStatusE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Tikira";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip gStatusE;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem toolFileSave;
        private System.Windows.Forms.ToolStripMenuItem toolFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolFileExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolAdjustments;
        private System.Windows.Forms.ToolStripMenuItem toolAdjustmentsSepia;
        private System.Windows.Forms.ToolStripMenuItem toolAdjustmentsInversion;
        private System.Windows.Forms.ToolStripMenuItem toolTools;
        private System.Windows.Forms.ToolStripMenuItem toolToolsRotate90R;
        private System.Windows.Forms.PictureBox pictureEditor;
    }
}