using System;
using System.IO;
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
        //Befehlsqueue
        Queue<int> BefehlsQueue = new Queue<int>();

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
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //Datei wir in TextBoxCode ausgegeben
                textBoxCode.Text = sr.ReadToEnd();
                //Datei wir in String Variable gespeichert
                String stringtxt = textBoxCode.Text;
                //String wird in char Array geschrieben

                
                char[] chartxt = new char[stringtxt.Length];

                chartxt = stringtxt.ToCharArray(0, stringtxt.Length);
                

                for (int i=0; i < chartxt.Length; i++)
                {
                    if (chartxt[i] == 32)
                    {
                        //Index bis zum Ende der Zeile
                        for (int a = i; a < chartxt.Length; a++)
                        {
                            if (chartxt[a] == '\n')
                            {
                                i++;
                                break;
                            }
                            i++;
                        }

                    }
                    else
                    {
                        i += 4; //Zeilennummer im Index i überspringen
                        char[] chars = {chartxt[i], chartxt[i + 1], chartxt[i + 2], chartxt[i + 3] };
                        string hexString = new string(chars);
                        int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                        /*Zum testen
                         * 
                           MessageBox.Show(num.ToString());
                         
                         */

                        

                        BefehlsQueue.Enqueue(num);


                        //Index bis zum Ende der Zeile
                        for (int a = i; a < chartxt.Length; a++)
                        {
                            if (chartxt[a] == '\n')
                            {
                                i++;
                                break;
                            }
                        
                            i++;
                        }
                    }
                }
                //Nur zum testen
                foreach (int s in BefehlsQueue)
                {
                    textBoxCode.Text = textBoxCode.Text + (s.ToString()+'\n');
                }
                
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