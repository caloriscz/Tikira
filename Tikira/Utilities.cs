using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;
using System.IO;

namespace Tikira
{
    /// <summary>
    /// Summary description for Utilities.
    /// </summary>
    public sealed class Utilities
    {
        private Utilities()
        {
        }

        public static string tagGet(string path, string tag)
        {
            // Load the document.
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Retrieve all prices.
            XmlNodeList nodeList = doc.GetElementsByTagName(tag);

            string look = "";

            foreach (XmlNode node in nodeList)
            {
                look += node.ChildNodes[0].Value;
            }

            return look;
        }

        public static void copyDirectory(string Src, string Dst)
        {
            String[] Files;

            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories

                if (Directory.Exists(Element))
                {
                    copyDirectory(Element, Dst + Path.GetFileName(Element));
                    // Files in directory
                }
                else
                {
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
                }
            }
        }

    }


}