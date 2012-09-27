using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tikira
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Bitmap bClone = null;

        //
        private void toolFileSave_Click(object sender, EventArgs e)
        {
            string xx = @Form1.xy;

            bClone.Save(xx, ImageFormat.Jpeg);
            bClone.Dispose();
        }

        private void toolFileSaveAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bClone.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }
        
        private void toolFileExit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Close();
            form.Close();
            Application.Exit();
        }

        private void toolAdjustmentsInversion_Click(object sender, EventArgs e)
        {
            string xx = @Form1.xy;

            if (bClone == null)
            {
                Bitmap b = (Bitmap)Image.FromFile(xx);
                bClone = new Bitmap(b);
            }

            Bitmap temp = (Bitmap)bClone;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            bClone = (Bitmap)bmap.Clone();
            pictureEditor.Image = bClone;
        }

        private void toolAdjustmentsSepia_Click(object sender, EventArgs e)
        {
            string xx = @Form1.xy;

            if (bClone == null)
            {
                Bitmap b = (Bitmap)Image.FromFile(xx);
                bClone = new Bitmap(b);
            }

            Bitmap temp = (Bitmap)bClone;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            bClone = (Bitmap)bmap.Clone();
            pictureEditor.Image = bClone;
        }

        private void toolToolsRotate90R_Click(object sender, EventArgs e)
        {
            string xx = @Form1.xy;

            if (bClone == null)
            {
                Bitmap b = (Bitmap)Image.FromFile(xx);
                bClone = new Bitmap(b);
            }

            Bitmap temp = (Bitmap)bClone;
            Bitmap bmap = (Bitmap)temp.Clone();

            bmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

            bClone = (Bitmap)bmap.Clone();
            pictureEditor.Image = bClone;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pictureEditor.Width = this.Width - 10;
            pictureEditor.Height = this.Height - 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Stream s = File.Open(Form1.xy, FileMode.Open);
            Image temp = Image.FromStream(s);
            s.Close();

            pictureEditor.Image = temp;
            pictureEditor.SizeMode = PictureBoxSizeMode.Zoom;

            gStatusE.Items.Clear();
            gStatusE.Items.Add(Form1.xy);
        }

    }

}
