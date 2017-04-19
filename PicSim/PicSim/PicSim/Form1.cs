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
        //Array für Befehle
        String[] BefehlsArray = new String[666];

        //2dim. Array für den RAM
        public int[,] ram = new int[256,10];

        //Variable für Bank
        public int bank = 0;

        //Variable für Quarzfrequenz
        public long quarz = 0;


        //private DataGridViewRowCollection rows;

        public Form1()
        {
            InitializeComponent();
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            Fill_dgvRam();
            InitBefehlsArray();
 
        }

        //Initialisieren des Befehls Arrays
        public void InitBefehlsArray()
        {
            for (int i = 0; i < BefehlsArray.Length; i++)
            {
                BefehlsArray[i] = "0";
            }
        }

        public void Fill_dgvRam()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ram[i, j] = 0;
                }
            }



            dgvRam.ColumnCount = 10;


            var rowCount = ram.GetLength(0);
            var rowLength = ram.GetLength(1);

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {

                var row = new DataGridViewRow();
                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = ram[rowIndex, columnIndex]
                    });
                }

                dgvRam.Rows.Add(row);
            }

            //Addressnamen eingetragen
            for (int k = 0; k < 256; k++)
            {
                dgvRam[0, k].Value = k.ToString("X2");
            }

            //Namen
            dgvRam[1, 0].Value = "INDF";
            dgvRam[1, 1].Value = "TMR0";
            dgvRam[1, 2].Value = "PCL";
            dgvRam[1, 3].Value = "STATUS";
            dgvRam[1, 4].Value = "FSR";
            dgvRam[1, 5].Value = "PORTA";
            dgvRam[1, 6].Value = "PORTB";
            dgvRam[1, 7].Value = "";
            dgvRam[1, 8].Value = "EEDATA";
            dgvRam[1, 9].Value = "EEADR";
            dgvRam[1, 10].Value = "PCLATH";
            dgvRam[1, 11].Value = "INTCON";

            int bank1 = 128;
            dgvRam[1, 0 + bank1].Value = "INDF";
            dgvRam[1, 1 + bank1].Value = "OPTION_REG";
            dgvRam[1, 2 + bank1].Value = "PCL";
            dgvRam[1, 3 + bank1].Value = "STATUS";
            dgvRam[1, 4 + bank1].Value = "FSR";
            dgvRam[1, 5 + bank1].Value = "TRISA";
            dgvRam[1, 6 + bank1].Value = "TRISB";
            dgvRam[1, 7 + bank1].Value = "";
            dgvRam[1, 8 + bank1].Value = "EECON1";
            dgvRam[1, 9 + bank1].Value = "EECON2";
            dgvRam[1, 10 + bank1].Value = "PCLATH";
            dgvRam[1, 11 + bank1].Value = "INTCON";

        }

        /*      public void SetupDataGridView()
              {
                  rows = this.dgvRam.Rows;

                  string[] rowTMR0 = { "01h", "TMR0", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowPCL = { "02h", "PCL", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowSTATUS = { "03h", "STATUS", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowFSR = { "04h", "FSR", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowPORTA = { "05h", "PORTA", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowPORTB = { "06h", "PORTB", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowEEDATA = { "08h", "EEDATA", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowEEADR = { "09h", "EEADR", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowPCLATH = { "0Ah", "PCLATH", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };
                  string[] rowINTCON = { "0Bh", "INTCON", "0", "0", "0", "0", "0", "0", "0", "0", "0x00", "0" };

                  // Fügt die einzelnen Zeilen dem DataGridView hinzu
                  rows.Add(rowTMR0);
                  rows.Add(rowPCL);
                  rows.Add(rowSTATUS);
                  rows.Add(rowFSR);
                  rows.Add(rowPORTA);
                  rows.Add(rowPORTB);
                  rows.Add(rowEEDATA);
                  rows.Add(rowEEADR);
                  rows.Add(rowPCLATH);
                  rows.Add(rowINTCON);

                  string[] row0C = { "0Ch", "0x00", "0" };
                  string[] row0D = { "0Dh", "0x00", "0" };
                  string[] row0E = { "0Eh", "0x00", "0" };
                  string[] row0F = { "0Fh", "0x00", "0" };
                  string[] row10 = { "10h", "0x00", "0" };
                  string[] row11 = { "11h", "0x00", "0" };
                  string[] row12 = { "12h", "0x00", "0" };
                  string[] row13 = { "13h", "0x00", "0" };
                  string[] row14 = { "14h", "0x00", "0" };
                  string[] row15 = { "15h", "0x00", "0" };
                  string[] row16 = { "16h", "0x00", "0" };
                  string[] row17 = { "17h", "0x00", "0" };
                  string[] row18 = { "18h", "0x00", "0" };
                  string[] row19 = { "19h", "0x00", "0" };
                  string[] row1A = { "1Ah", "0x00", "0" };
                  string[] row1B = { "1Bh", "0x00", "0" };
                  string[] row1C = { "1Ch", "0x00", "0" };
                  string[] row1D = { "1Dh", "0x00", "0" };
                  string[] row1E = { "1Eh", "0x00", "0" };
                  string[] row1F = { "1Fh", "0x00", "0" };
                  string[] row20 = { "20h", "0x00", "0" };
                  string[] row21 = { "21h", "0x00", "0" };
                  string[] row22 = { "22h", "0x00", "0" };
                  string[] row23 = { "23h", "0x00", "0" };
                  string[] row24 = { "24h", "0x00", "0" };
                  string[] row25 = { "25h", "0x00", "0" };
                  string[] row26 = { "26h", "0x00", "0" };
                  string[] row27 = { "27h", "0x00", "0" };
                  string[] row28 = { "28h", "0x00", "0" };
                  string[] row29 = { "29h", "0x00", "0" };
                  string[] row2A = { "2Ah", "0x00", "0" };
                  string[] row2B = { "2Bh", "0x00", "0" };
                  string[] row2C = { "2Ch", "0x00", "0" };
                  string[] row2D = { "2Dh", "0x00", "0" };
                  string[] row2E = { "2Eh", "0x00", "0" };
                  string[] row2F = { "2Fh", "0x00", "0" };


                  rows.Add(row0C);
                  rows.Add(row0D);
                  rows.Add(row0E);
                  rows.Add(row0F);
                  rows.Add(row10);
                  rows.Add(row11);
                  rows.Add(row12);
                  rows.Add(row13);
                  rows.Add(row14);
                  rows.Add(row15);
                  rows.Add(row16);
                  rows.Add(row17);
                  rows.Add(row18);
                  rows.Add(row19);
                  rows.Add(row1A);
                  rows.Add(row1B);
                  rows.Add(row1C);
                  rows.Add(row1D);
                  rows.Add(row1E);
                  rows.Add(row1F);
                  rows.Add(row20);
                  rows.Add(row21);
                  rows.Add(row22);
                  rows.Add(row23);
                  rows.Add(row24);
                  rows.Add(row25);
                  rows.Add(row26);
                  rows.Add(row27);
                  rows.Add(row28);
                  rows.Add(row29);
                  rows.Add(row2A);
                  rows.Add(row2B);
                  rows.Add(row2C);
                  rows.Add(row2D);
                  rows.Add(row2E);
                  rows.Add(row2F);

              }
      */


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

                int arrIndex = 0;
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
                        //
                        string binaryval = Convert.ToString(Convert.ToInt32(hexString, 16), 2);
                        //int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                        //Befehle werden in Array gespeichert                        
                        BefehlsArray[arrIndex] = binaryval;
                        arrIndex+=1;
                        
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
                for (int y=0;y<BefehlsArray.Length;y++) 
                {
                    textBoxCode.Text = textBoxCode.Text + BefehlsArray[0];
                }
            }
        }

        //On-Click toolHelp
        private void toolHelp_Click(object sender, EventArgs e)
        {
            //Dateipfad
            try {
                System.Diagnostics.Process.Start("D:/Stiiift_Inc/PicSim/Help/Help.pdf");
            }
            catch (Exception FileNotFoundException)
            {
                MessageBox.Show("File not found");
            }
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            //Dateipfad
            try
            {
                System.Diagnostics.Process.Start("D:/Stiiift_Inc/PicSim/About/About.pdf");
            }
            catch (Exception FileNotFoundException)
            {
                MessageBox.Show("File not found");
            }
        }

        private void txtUnicorn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=a-xWhG4UU_Y");
        }

        //!!!System.InvalidCastException!!!
        private void dgvRam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dgvRam.Rows[e.RowIndex].Cells[e.ColumnIndex];
            try
            {
                if (e.ColumnIndex > 1) //Except String Cells
                {
                    if ((int)cell.Value == 0)
                    {
                        cell.Value = 1;
                    }
                    else
                    {
                        cell.Value = 0;
                    }
                }
            }
            catch (System.InvalidCastException) //für erste beide Reihen [0,n][1,n] kann der Wert so nicht geändert werden
            {
                MessageBox.Show("Zelle nicht veränderbar");
            }
        }

        private void toolPlay_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBoxCode.Text== "")
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                for (i = 0; i < BefehlsArray.Length; i++)
                {
                    Decode(BefehlsArray[i]);
                }
            }
        }
        private void Decode(String BinCode)
        {
            //hier müssen Befehle implementiert werden
        }
    }
}
 