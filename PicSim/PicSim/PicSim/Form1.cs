using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
               textBoxCode.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        //On-Click toolHelp
        private void toolHelp_Click(object sender, EventArgs e)
        {
            //Dateipfad
            System.Diagnostics.Process.Start("D:/Stiiift_Inc/PicSim/Help/Help.pdf");
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Stiiift_Inc/PicSim/About/About.pdf");
        }


        private void txtUnicorn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=a-xWhG4UU_Y");
        }
    }
}