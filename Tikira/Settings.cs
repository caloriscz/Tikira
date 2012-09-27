using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Tikira
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            string path = Utilities.tagGet("settings.xml", "path");
            pathStart.Text = @path.Replace("\\\\", "\\");
            comboBox1.SelectedIndex = 0;
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKSettings_Click(object sender, EventArgs e)
        {
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load("settings.xml");
            XmlNode node;
            node = myXmlDocument.DocumentElement;

            foreach (XmlNode node1 in node.ChildNodes)
            {
                string pathValue = "1";

                if (node1.Name == "startup")
                {

                    if (comboBox1.SelectedItem.ToString() == "Poslední adresář před zavřením programu")
                    {
                        pathValue = "1";
                    }
                    else
                    {
                        pathValue = "2";
                    }

                    // Increase all the book prices by 20%
                    String newprice = node1.InnerText;
                    node1.InnerText = pathValue;
                }
                else if (node1.Name == "path")
                {
                    if (pathValue == "2")
                    {
                        node1.InnerText = pathStart.Text;
                    }
                }
            }

            myXmlDocument.Save("settings.xml");

            this.Close();
        }
    }
}
