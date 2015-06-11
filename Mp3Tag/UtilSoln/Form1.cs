using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilSoln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Downloads";
            string[] filePaths = Directory.GetFiles(folderPath);
            foreach (string filePath in filePaths)
            {
                TagLib.File f = TagLib.File.Create(filePath);
                f.Tag.Copyright = "Git";
                f.Tag.Performers = new string[] { "Git" };
                //f.Tag.Album = "New Album Title";
                f.Save();
            }

            //string path = @"C:\Downloads\03.mp3";
            //TagLib.File f = TagLib.File.Create(path);
            //f.Tag.Performers = new string[] { "Git " };
            ////f.Tag.FirstArtist = "Git";
            ////f.Tag.Album = "New Album Title";
            //f.Save();

            MessageBox.Show("Done");
        }
    }
}
