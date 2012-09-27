using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Xml;
using System.Threading;

namespace Tikira
{
    public partial class Form1 : Form
    {
        private BindingList<FileInfo> dataSource = new BindingList<FileInfo>();
        private BindingSource bs = new BindingSource();
        public static string xy = "";
        string oldPath = "";
        int doubleClick = 0;

        public Form1()
        {
            InitializeComponent();

            // Načíst poslední stopu z textového souboru
            string path = Utilities.tagGet("settings.xml", "path");
            string text = @path.Replace("\\\\", "\\");

            string startPath = Directory.GetParent(text).FullName;
            //MessageBox.Show(path);
            gPath.Text = text;
            ReadDir(text);
            fileSystemWatcher1.Path = text;
        }

        private void toolHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tikira 0.3\n © 2011 Petr Karásek", "O aplikaci");
        }

        private void toolHelpWebsite_Click(object sender, EventArgs e)
        {
            string target = "http://caloris.cz";
            System.Diagnostics.Process.Start(target);
        }

        private void toolFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Další třídy

        public class GridRowsObject
        {
            public GridRowsObject(string myFile, string myExt, string mySize, string myDim)
            {
                _myFile = myFile;
                _myExt = myExt;
                _mySize = mySize;
                _myDim = myDim;
            }
            private string _myFile;
            public string myFile
            {
                get { return _myFile; }
                set { _myFile = value; }
            }
            private string _myExt;
            public string MyExt
            {
                get { return _myExt; }
                set { _myExt = value; }
            }
            private string _mySize;
            public string MySize
            {
                get { return _mySize; }
                set { _mySize = value; }
            }
            private string _myDim;
            public string MyDim
            {
                get { return _myDim; }
                set { _myDim = value; }
            }
        }

        // ReadDir: načti adresář s podadresáři a soubory

        private void ReadDir(string path, string filename = "")
        {
            gPath.Text = path;
            bs.Clear();
            // Načíst do pole adresáře
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] dirs = di.GetDirectories();

            // Načíst do pole soubory
            DirectoryInfo fi = new DirectoryInfo(path);
            FileInfo[] files = fi.GetFiles();

            for (int i = 0; i < dirs.Length; i++)
            {
                bs.Add(new GridRowsObject(dirs[i].Name, "", "", ""));
            }

            for (int j = 0; j < files.Length; j++)
            {
                bs.Add(new GridRowsObject(files[j].Name, files[j].Extension, files[j].Length.ToString(), ""));
            }

            this.dataGridView1.DataSource = bs;

            dataGridView1.Columns[0].HeaderText = "Název souboru";
            dataGridView1.Columns[1].HeaderText = "Přípona";
            dataGridView1.Columns[2].HeaderText = "Velikost";
            dataGridView1.Columns[3].HeaderText = "Rozměry";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // Vybrat soubor
            int rowNr = GridCellRowIndex(filename);

            if (rowNr < 0)
            {
                rowNr = 0;
            }

            backgroundWorker1.RunWorkerAsync();

            if (filename != "")
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[rowNr].Selected = true;
                dataGridView1.CurrentCell = this.dataGridView1[0, rowNr];
                //MessageBox.Show(Path.GetFileNameWithoutExtension(files[count])+" -- "+f.Extension);

                showImagePreview(filename);
            }
        }

        // načtení náhledů do levého okna
        private void showImagePreview(string sRowID, string sRowExt = "")
        {
            string filename = gPath.Text + "\\" + sRowID;

            try
            {
                if (Directory.Exists(filename.Replace(".", "")))
                {

                }
                else if (File.Exists(filename))
                {
                    Stream s = File.Open(filename, FileMode.Open);
                    Image temp = Image.FromStream(s);
                    s.Close();

                    pictureBox1.Image = temp;
                }
                else
                {
                    pictureBox1.Image = null;
                }

            }
            catch /*(Exception e)*/
            {
                //MessageBox.Show(e.Message);
                pictureBox1.Image = null;
            }
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.SetBounds(0, 0, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
        }

        int GridCellRowIndex(string rowContent)
        {
            int rowIndex = -1;
            //string xm = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower() == rowContent.ToLower())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            //MessageBox.Show(xm);

            return rowIndex;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(30);

            CheckForIllegalCrossThreadCalls = false;

            string imgDims = "";

            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                if ((string)dataGridView1.Rows[x].Cells[3].Value == string.Empty)
                {
                    // Zjistit zda je daný soubor obrázek

                    try
                    {
                        Stream s = File.Open(gPath.Text + "\\" + dataGridView1.Rows[x].Cells[0].Value, FileMode.Open);
                        Image temp = Image.FromStream(s);
                        s.Close();

                        imgDims = temp.Width + "x" + temp.Height;
                        temp.Dispose();
                        dataGridView1.Rows[x].Cells[3].Value = imgDims;
                    }
                    catch /*(Exception e)*/
                    {
                        imgDims = "nonimage";
                        dataGridView1.Rows[x].Cells[3].Value = imgDims;
                    }
                }
            }
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string imgDims = "";
            //MessageBox.Show(gPath.Text + "\\" + e.Name);
            try
            {
                Stream s = File.Open(gPath.Text + "\\" + e.Name, FileMode.Open);
                Image temp = Image.FromStream(s);
                
                string Lng = s.Length.ToString();
                string Ext = Path.GetExtension(e.Name);
                
                s.Close();

                imgDims = temp.Width.ToString() + "x" + temp.Height.ToString();
                temp.Dispose();

                bs.Add(new GridRowsObject(e.Name, Ext, Lng, imgDims));

                dataGridView1.DataSource = bs;
                dataGridView1.Refresh();
            }
            catch (Exception l)
            {
                imgDims = "error";
                bs.Add(new GridRowsObject(e.Name, "2", "4", imgDims));

                MessageBox.Show(gPath.Text + "\\" + e.Name+"\n"+l.Message);
            }

            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            if (GridCellRowIndex(e.Name) != -1)
            {
                //MessageBox.Show("yes: "+e.FullPath);
                dataGridView1.Rows.Remove(dataGridView1.Rows[GridCellRowIndex(e.Name)]);
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.Dispose();
            

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                gPath.Text = folderDlg.SelectedPath;

                Environment.SpecialFolder root = folderDlg.RootFolder;

                //MessageBox.Show("a: "+ Path.GetFileName(folderDlg.SelectedPath));
                if (backgroundWorker1.IsBusy == false)
                {
                    ReadDir(folderDlg.SelectedPath);
                }
                else
                {
                    MessageBox.Show("Busy right now");
                }

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            showImagePreview(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showImagePreview(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void toolFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string extension = Path.GetExtension(filename);

                Stream s = File.Open(filename, FileMode.Open);
                Image temp = Image.FromStream(s);
                s.Close();

                pictureBox1.Image = temp;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string directoryName = Directory.GetParent(filename).FullName;
                gPath.Text = directoryName.Replace("\\\\", "\\");
                ReadDir(directoryName, Path.GetFileName(filename));
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 form = new Form2();

            //showImagePreview(e.RowIndex);

            xy = gPath.Text + "\\" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (Directory.Exists(xy))
            {

                if (xy.Substring(xy.Length - 1, 1) == ".")
                {
                    xy = xy.Substring(0, xy.Length - 1);
                }

                ReadDir(xy);
                gPath.Text = xy;
                doubleClick = 1;
            }
            else
            {
                this.Hide();
                form.Show();
            }
        }

        private void toolToolsSettings_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    //MessageBox.Show(this, "Left Button Click");
                    break;
                case MouseButtons.Right:
                    //MessageBox.Show(this, Cursor.Position.X.ToString());

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Selected = false;
                    }


                    DataGridView.HitTestInfo sRowID = dataGridView1.HitTest(e.X, e.Y);


                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, e.RowIndex];

                    xy = gPath.Text + "\\" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    contextMenuStrip1.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                    showImagePreview(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                    //MessageBox.Show(sRowID);
                    //pictureBox1.Image = Image.FromFile(sRowID);
                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            } 
        }

        private void contextFileInfo_Click(object sender, EventArgs e)
        {
            int cc = dataGridView1.CurrentCell.RowIndex;

            xy = gPath.Text + "\\" + dataGridView1.Rows[cc].Cells[0].Value.ToString();

            ImageFileInfo form = new ImageFileInfo();
            form.ShowDialog();
        }

        private void contextExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolViewMenuStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (toolViewMenuStrip.Checked == true)
            {
                gStatus.Show();
                this.Size = new System.Drawing.Size(this.Width - 1, this.Height); // not lucky solution but solution
                pictureBox1.SetBounds(0, 0, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                dataGridView1.Height = splitContainer1.Panel2.Height;
            }
            else
            {
                gStatus.Hide();
                this.Size = new System.Drawing.Size(this.Width - 1, this.Height);
                pictureBox1.SetBounds(0, 0, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                dataGridView1.Height = splitContainer1.Panel2.Height;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            pictureBox1.SetBounds(0, 0, splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            gPath.Width = splitContainer1.Panel2.Width - 75;
            dataGridView1.Width = splitContainer1.Panel2.Width - 8;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (doubleClick == 1)
            {

                if (Directory.Exists(gPath.Text + "\\" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {

                }
                else
                {
                    oldPath = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                }

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (doubleClick == 1)
            {
                string newPath;
                string renamedValue = oldPath;

                if (renamedValue == "")
                {
                    newPath = oldPath;
                }
                else
                {
                    newPath = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                }

                if (Directory.Exists(gPath.Text + "\\" + newPath))
                {

                }
                else
                {
                    //oldPath = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    System.IO.File.Move(@gPath.Text + "\\" + oldPath.Replace("\\\\", "\\"), @gPath.Text + "\\" + newPath.Replace("\\\\", "\\"));
                }
            
                doubleClick = 0;
            }
        }

        private void toolEditSelectAll_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uložení cesty
            string startup = Utilities.tagGet("settings.xml", "startup");

            if (startup == "1")
            {
                XmlDocument myXmlDocument = new XmlDocument();
                myXmlDocument.Load("settings.xml");
                XmlNode node;
                node = myXmlDocument.DocumentElement;

                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "path")
                    {
                        node1.InnerText = gPath.Text;
                    }
                }

                myXmlDocument.Save("settings.xml");
            }

            Application.Exit();
        }

        private void toolEditCopy_Click(object sender, EventArgs e)
        {
            object copytoclip = dataGridView1.GetClipboardContent();
            //object copytoclip = dataGridView1.cop;
            string testc = copytoclip.ToString();
            //Opravit ---!!!
            string[] pieces = testc.Split('\t');

            string s = "Selected: \n";

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int[] sr;
            sr = new Int32[selectedRowCount];

            for (int i = 0; i < selectedRowCount; i++)
            {
                sr[i] = dataGridView1.SelectedRows[i].Index;
                s += sr[i] + "\n";
            }


            //MessageBox.Show(s.ToString() + " \n");

            StringCollection paths = new StringCollection();

            for (int p = 0; p < selectedRowCount; p++)
            {
                paths.Add(gPath.Text + "\\" + dataGridView1.Rows[sr[p]].Cells[0].Value.ToString());
            }

            Clipboard.SetFileDropList(paths);
        }

        private void toolEditDelete_Click(object sender, EventArgs e)
        {
            object copytoclip = dataGridView1.GetClipboardContent();
            //object copytoclip = dataGridView1.cop;
            string testc = copytoclip.ToString();
            string[] pieces = testc.Split('\t');
            int sss = dataGridView1.CurrentCell.RowIndex;

            StringCollection paths = new StringCollection();
            //MessageBox.Show(dataGridView1.Rows[sss].Cells[0].Value.ToString());

            //string s = "Selected: \n";

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int[] sr;
            sr = new Int32[selectedRowCount];
            Array.Sort(sr);

            FileAttributes attr = new FileAttributes();

            for (int i = 0; i < selectedRowCount; i++)
            {
                sr[i] = dataGridView1.SelectedRows[i].Index;

                attr = File.GetAttributes(@gPath.Text + "\\" + dataGridView1.Rows[sr[i]].Cells[0].Value.ToString());

                if (attr.ToString() == "Directory")
                {
                    MessageBox.Show("a");
                    System.IO.Directory.Delete(gPath.Text + "\\" + dataGridView1.Rows[sr[i]].Cells[0].Value.ToString(), true);
                }
                else
                {
                    MessageBox.Show("b");
                    System.IO.File.Delete(gPath.Text + "\\" + dataGridView1.Rows[sr[i]].Cells[0].Value.ToString());
                }
            }

            //MessageBox.Show(attr.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            splitContainer1.Width = (this.Width);
            splitContainer1.Height = this.Height;
            splitContainer1.SplitterDistance = (Form1.ActiveForm.Width / 2);
            dataGridView1.Width = (Form1.ActiveForm.Width / 2) - 28;
            dataGridView1.Height = (Form1.ActiveForm.Height);
            string lHeight = Convert.ToString(this.Height);
            string lWidth = Convert.ToString(this.Width);
            pictureBox1.Width = (this.Width / 2);
            pictureBox1.Height = this.Height;
            gPath.Width = (this.Width / 2) - 95;
            //MessageBox.Show("x:" + lHeight + "x:" + lWidth);
        }

        private void gPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //MessageBox.Show("a");
                //ReadDir(gPath.Text);
            }
            else 
            {

                //MessageBox.Show("a ono nic");
            }
        }

        private void toolEditPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsFileDropList())
            {
                foreach (string path in Clipboard.GetFileDropList())
                {
                    if (File.Exists(gPath.Text + "\\" + Path.GetFileName(path)))
                    {
                        switch (MessageBox.Show("Soubor již existuje", "Upozornění", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                File.Copy(@path, gPath.Text + "\\" + Path.GetFileName(path), true);
                                break;

                            case DialogResult.No:
                                // "No" processing
                                break;
                        }
                    }
                    else if (Directory.Exists(gPath.Text + "\\" + Path.GetFileName(path)))
                    {
                    
                    }
                    else {
                        if (Directory.Exists(path))
                        {
                            MessageBox.Show("Yes from Clipboard: " + Path.GetFileName(path));
                            Utilities.copyDirectory(@path, @gPath.Text + "\\" + Path.GetFileName(path));
                        }
                        else
                        {
                            File.Copy(@path, gPath.Text + "\\" + Path.GetFileName(path));
                        }
                    }
                }
            }
            
        }

        private void toolEditCut_Click(object sender, EventArgs e)
        {
            object copytoclip = dataGridView1.GetClipboardContent();

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int[] sr;
            sr = new Int32[selectedRowCount];

            for (int i = 0; i < selectedRowCount; i++)
            {
                sr[i] = dataGridView1.SelectedRows[i].Index;
            }

            StringCollection paths = new StringCollection();

            for (int p = 0; p < selectedRowCount; p++)
            {
                paths.Add(gPath.Text + "\\" + dataGridView1.Rows[sr[p]].Cells[0].Value.ToString());
            }

            byte[] moveEffect = new byte[] { 2, 0, 0, 0 };
            MemoryStream dropEffect = new MemoryStream();
            dropEffect.Write(moveEffect, 0, moveEffect.Length);

            DataObject data = new DataObject();
            data.SetFileDropList(paths);
            data.SetData("Preferred DropEffect", dropEffect);

            Clipboard.Clear();
            Clipboard.SetDataObject(data, true);

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                try
                {
                    string pathUp = Directory.GetParent(gPath.Text).ToString();
                    ReadDir(pathUp.Replace("\\", ""));
                    gPath.Text = pathUp;
                }
                catch { 
                    /* nothing here */
                }

            }
        }

        private void gPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReadDir(gPath.Text);
                dataGridView1.Focus();
            }
        }
    
    }
}
