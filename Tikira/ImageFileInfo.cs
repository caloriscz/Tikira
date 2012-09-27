using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tikira
{
    public partial class ImageFileInfo : Form
    {
        public ImageFileInfo()
        {
            InitializeComponent();
            labelNamev.Text = Path.GetFileName(Form1.xy);
            labelPathv.Text = Path.GetDirectoryName(Form1.xy);

            FileInfo f = new FileInfo(Form1.xy);

            labelSizev.Text = f.Length.ToString();

            labelLastAccessTimev.Text = f.LastAccessTime.ToString();
            labelLastWriteTimev.Text = f.LastWriteTime.ToString();
            labelCreationTimev.Text = f.CreationTime.ToString();

            Image img = Image.FromFile(Form1.xy);
            Image thumbnail;

            int thumbnailWidth = 200, thumbnailHeight = 200;

            thumbnail = img.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero);

            pictureThumb.Image = thumbnail;

            labelSeparator1.AutoSize = false;
            labelSeparator1.Height = 2;
            labelSeparator1.BorderStyle = BorderStyle.Fixed3D;
            labelSeparator2.AutoSize = false;
            labelSeparator2.Height = 2;
            labelSeparator2.BorderStyle = BorderStyle.Fixed3D;


            labelWidthv.Text = img.Width.ToString();
            labelHeightv.Text = img.Height.ToString();
        }
    }
}
