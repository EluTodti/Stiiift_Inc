using System;
using System.Windows.Forms;



namespace PicSim
{
    public partial class Form1 : Form
    {
        //W-Register in Befehle

        //
        Befehle befehle = new Befehle();

        Resetter resetter = new Resetter();

        //Memory
        Memory mem = Memory.Instance;

        //Array für Befehle
        int[] BefehlsArray = new int[666];

        //2dim. Array für den RAM
        public int[,] ram = new int[8,256];

        //Variable für Bank
        public int bank = 128;

        //Variable für Quarzfrequenz
        public long quarz = 0;

        //private DataGridViewRowCollection rows;

        public Form1()
        {
            InitializeComponent();
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            Fill_dgvRam();
            InitBefehlsArray();            
            InitRAM();
            GUIAktualisieren();
            
        }

        //Initialisieren des Befehls Arrays
        public void InitBefehlsArray()
        {
            for (int i = 0; i < BefehlsArray.Length; i++)
            {
                BefehlsArray[i] = 0;
            }
        }
        //----------------------------------
        public void InitRAM()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ram[j, i] = 0;
                }
            }
            ram[4, Const.STATUS] = 1;
            ram[5, Const.STATUS] = 1;

            ram[4, Const.STATUS + bank] = 1;
            ram[5, Const.STATUS + bank] = 1;

            ram[0, Const.OPTION_REG + bank] = 1;
            ram[1, Const.OPTION_REG + bank] = 1;
            ram[2, Const.OPTION_REG + bank] = 1;
            ram[3, Const.OPTION_REG + bank] = 1;
            ram[4, Const.OPTION_REG + bank] = 1;
            ram[5, Const.OPTION_REG + bank] = 1;
            ram[6, Const.OPTION_REG + bank] = 1;
            ram[7, Const.OPTION_REG + bank] = 1;

            ram[0, Const.TRISA + bank] = 1;
            ram[1, Const.TRISA + bank] = 1;
            ram[2, Const.TRISA + bank] = 1;
            ram[3, Const.TRISA + bank] = 1;
            ram[4, Const.TRISA + bank] = 1;

            ram[0, Const.TRISB + bank] = 1;
            ram[1, Const.TRISB + bank] = 1;
            ram[2, Const.TRISB + bank] = 1;
            ram[3, Const.TRISB + bank] = 1;
            ram[4, Const.TRISB + bank] = 1;
            ram[5, Const.TRISB + bank] = 1;
            ram[6, Const.TRISB + bank] = 1;
            ram[7, Const.TRISB + bank] = 1;



        }
        //-----------------------------------

        //-----------------------------------
        public void RegisterInitialisieren()
        {
            befehle.WReg = 0;
        }

        //-----------------------------------
        public void Fill_dgvRam()
        {
            dgvRam0.ColumnCount = 10;

            var rowCount = ram.GetLength(0);
            var rowLength = ram.GetLength(1);

            //for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            //{

            //    var row = new DataGridViewRow();
            //    for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
            //    {
            //        row.Cells.Add(new DataGridViewTextBoxCell()
            //        {
            //            Value = ram[rowIndex, columnIndex]
            //        });
            //    }

            //    dgvRam0.Rows.Add(row);
            //}

            for (int i = 0; i < 80; i++)
            {
                var row = new DataGridViewRow();
                
                dgvRam0.Rows.Add(row);
             }
           for (int i = 0;i<80; i++)
            {
                for(int k = 2; k<10; k++ )
                {
                    dgvRam0[k, i].Value = 0;
                }
            }
            for (int k = 0; k < 80; k++)
            {
                dgvRam0[0, k].Value = k.ToString("X2");
            }

            //Addressnamen eingetragen
            //Namen
            dgvRam0[1, 0].Value = "INDF";
            dgvRam0[1, 1].Value = "TMR0";
            dgvRam0[1, 2].Value = "PCL";
            dgvRam0[1, 3].Value = "STATUS";
            dgvRam0[1, 4].Value = "FSR";
            dgvRam0[1, 5].Value = "PORTA";
            dgvRam0[1, 6].Value = "PORTB";
            dgvRam0[1, 7].Value = "";
            dgvRam0[1, 8].Value = "EEDATA";
            dgvRam0[1, 9].Value = "EEADR";
            dgvRam0[1, 10].Value = "PCLATH";
            dgvRam0[1, 11].Value = "INTCON";


            //dgvRam1

            dgvRam1.ColumnCount = 10;

            for (int i = 0; i < 80; i++)
            {
                var row = new DataGridViewRow();

                dgvRam1.Rows.Add(row);
            }
            for (int i = 0; i < 80; i++)
            {
                for (int k = 2; k < 10; k++)
                {
                    dgvRam1[k, i].Value = 0;
                }
            }


            int hexincrement = 0x80;
            for (int k = 0; k < 80; k++)
            {
                dgvRam1[0, k].Value = hexincrement.ToString("X2");
                hexincrement++;
            }

            int bank1 = 128;
            dgvRam1[1, 0].Value = "INDF";
            dgvRam1[1, 1].Value = "OPTION_REG";
            dgvRam1[1, 2].Value = "PCL";
            dgvRam1[1, 3].Value = "STATUS";
            dgvRam1[1, 4].Value = "FSR";
            dgvRam1[1, 5].Value = "TRISA";
            dgvRam1[1, 6].Value = "TRISB";
            dgvRam1[1, 7].Value = "";
            dgvRam1[1, 8].Value = "EECON1";
            dgvRam1[1, 9].Value = "EECON2";
            dgvRam1[1, 10].Value = "PCLATH";
            dgvRam1[1, 11].Value = "INTCON";
           
        }
        //-----------------------------------

        public void RegisterAktualisieren()
        {
            lblWReg.Text = befehle.WReg.ToString();
        }

        public void GUIAktualisieren()
        {
            for (int Spalte = 2; Spalte < 10; Spalte++)
            {
                int ramreihe = 0x80;

                for (int Reihe = 0; Reihe < 80; Reihe++)
                {
                    dgvRam0[Spalte, Reihe].Value = ram[Spalte-2, Reihe];

                    
                    dgvRam1[Spalte, Reihe].Value = ram[Spalte - 2, ramreihe];
                    ramreihe++;
                }
            }
            lblWReg.Text  = befehle.WReg.ToString();
        }

        public void RamAktualisieren()
        {
            for (int Spalte = 2; Spalte < 8; Spalte++)
            {
                for (int Reihe = 0; Reihe < 80; Reihe++)
                {
                    ram[Spalte, Reihe] =  (int)dgvRam0[Spalte, Reihe].Value;
                }
                int dgvRamReihe = 0;
                for (int Reihe = 128; Reihe < 207; Reihe++)
                {
                   
                    ram[Spalte, Reihe] = (int)dgvRam1[Spalte, dgvRamReihe].Value;
                    dgvRamReihe++;
                }
            }
        }
        /*      public void SetupDataGridView()
              {
                  rows = this.dgvRam0.Rows;

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
                        char[] chars = { chartxt[i], chartxt[i + 1], chartxt[i + 2], chartxt[i + 3] };
                        string hexString = new string(chars);
                        //
                        
                        int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                        //Befehle werden in Array gespeichert                        
                        BefehlsArray[arrIndex] = num;
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
                for (int y = 0;y < BefehlsArray.Length; y++) 
                {
                    textBoxCode.Text = textBoxCode.Text + BefehlsArray[y];

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


        //Synchonisieren der Register===================================================================================
        private void RegisterSynchronisieren(DataGridViewCellEventArgs e, DataGridViewTextBoxCell cell , DataGridViewTextBoxCell Reg)
        {
            if (e.ColumnIndex > 1) //Except String Cells
            {
                if ((int)cell.Value == 0)
                {
                    cell.Value = 1;
                    //Code für Statusregistersynchronität
                    if (e.RowIndex == Const.INDF || e.RowIndex == Const.PCL || e.RowIndex == Const.STATUS 
                        || e.RowIndex == Const.FSR || e.RowIndex == Const.PCLATH || e.RowIndex == Const.INTCON)
                    {
                        Reg.Value = 1;
                    }
                    //------------------------------------
                }
                else
                {
                    cell.Value = 0;
                    if (e.RowIndex == Const.INDF || e.RowIndex == Const.PCL || e.RowIndex == Const.STATUS
                        || e.RowIndex == Const.FSR || e.RowIndex == Const.PCLATH || e.RowIndex == Const.INTCON)
                    {
                        Reg.Value = 0;
                    }
                }

            }
            RamAktualisieren();
        }
        private void dgvRam0_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dgvRam0.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewTextBoxCell RegB1 = (DataGridViewTextBoxCell)
                dgvRam1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            RegisterSynchronisieren(e, cell, RegB1);
            
        }
        private void dgvRam1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dgvRam1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewTextBoxCell RegB0 = (DataGridViewTextBoxCell)
                dgvRam0.Rows[e.RowIndex].Cells[e.ColumnIndex];
            RegisterSynchronisieren(e, cell, RegB0);
        }
        //===================================================================================

        private void toolPlay_Click(object sender, EventArgs e)
        {
            GUIAktualisieren();
            int i = 0;
            if (textBoxCode.Text== "")
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                for (mem.pc = 0; mem.pc < BefehlsArray.Length; mem.pc++)
                {
                    Decode(BefehlsArray[mem.pc]);
                    GUIAktualisieren();
                    RegisterAktualisieren();
                    //MessageBox.Show(BefehlsArray[6].ToString());
                }
            }
        }


        private void Decode(int binCode)
        {
            //BYTE-ORIENTED FILE REGISTER OPERATIONS
            if ((binCode & 0x3F00) == 0x0700)
            {
                //ADDWF

                return;
            }
            if ((binCode & 0x3F00) == 0x0500)
            {
                //ANDWF
                return;
            }
            if ((binCode & 0x3F80) == 0x0180)
            {
                //CLRF
                return;
            }
            if ((binCode & 0x3F80) == 0x0100)
            {
                //CLRW
                return;
            }
            if ((binCode & 0x3F00) == 0x0900)
            {
                //COMF
                return;
            }
            if ((binCode & 0x3F00) == 0x0300)
            {
                //DECF
                return;
            }
            if ((binCode & 0x3F00) == 0x0B00)
            {
                //DECFSZ
                return;
            }
            if ((binCode & 0x3F00) == 0x0A00)
            {
                //INCF
                return;
            }
            if ((binCode & 0x3F00) == 0x0F00)
            {
                //INCFSZ
                return;
            }
            if ((binCode & 0x3F00) == 0x0400)
            {
                //IORWF
                return;
            }
            if ((binCode & 0x3F00) == 0x0800)
            {
                //MOVF
                return;
            }
            if ((binCode & 0x3F80) == 0x0080)
            {
                //MOVWF
                return;
            }
            if ((binCode & 0x3F00) == 0x0300)
            {
                //DECF
                return;
            }
            if (binCode == 0x0 || binCode == 0x20 || binCode == 0x40 || binCode == 0x60)
            {
                //NOP
                return;
            }
            if ((binCode & 0x3F00) == 0x0D00)
            {
                //RLF
                return;
            }
            if ((binCode & 0x3F00) == 0x0C00)
            {
                //RRF
                return;
            }
            if ((binCode & 0x3F00) == 0x0200)
            {
                //SUBWF
                return;
            }
            if ((binCode & 0x3F00) == 0x0E00)
            {
                //SWAPF
                return;
            }
            if ((binCode & 0x3F00) == 0x0600)
            {
                //XORWF
                return;
            }

            //BIT-ORIENTED FILE REGISTER OPERATIONS
            if ((binCode & 0x3C00) == 0x1000)
            {
                //BCF
                return;
            }
            if ((binCode & 0x3C00) == 0x1400)
            {
                //BSF
                return;
            }

            if ((binCode & 0x3C00) == 0x1800)
            {
                //BTFSC
                return;
            }
            if ((binCode & 0x3C00) == 0x1C00)
            {
                //BTFSS
                return;
            }

            //LITERAL AND CONTROL OPERATIONS
            if ((binCode & 0x3E00) == 0x3E00)
            {
                //ADDLW   
                befehle.addlw(binCode);             
                return;
            }
            if ((binCode & 0x3F00) == 0x3900)
            {
                //ANDLW    
                befehle.andlw(binCode);          
                return;
            }
            if ((binCode & 0x3800) == 0x2000)
            {
                //CALL            
                return;
            }
            if (binCode == 0x64)
            {
                //CLRWDT                
                return;
            }
            if ((binCode & 0x3800) == 0x2800)
            {
                //GOTO        
                befehle.goto_(binCode);
                
                return;
            }
            if ((binCode & 0x3F00) == 0x3800)
            {
                //IORLW   
                befehle.iorlw(binCode);  
                return;
            }
            if ((binCode & 0x3C00) == 0x3000)
            {
                //MOVLW   
                befehle.movlw(binCode);
                return;
            }
            if (binCode == 0x9)
            {
                //RETFIE                
                return;
            }
            if ((binCode & 0x3C00) == 0x3400)
            {
                //RETLW   
                return;
            }
            if (binCode == 0x8)
            {
                //RETURN                
                return;
            }
            if (binCode == 0x63)
            {
                //SLEEP
                return;
            }
            if ((binCode & 0x3E00) == 0x3C00)
            {
                //SUBLW     
                befehle.sublw(binCode);      
                return;
            }
            if ((binCode & 0x3F00) == 0x3A00)
            {
                //XORLW       
                befehle.xorlw(binCode);    
                return;
            }
            MessageBox.Show("Befehl nicht gefunden:" + binCode);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitRAM();
            RegisterInitialisieren();          
            GUIAktualisieren();
            RegisterAktualisieren();
        }


    }
}
 