using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace PicSim
{
    public partial class Form1 : Form
    {

        private Resetter resetter = new Resetter();
        private Memory mem = Memory.Instance;
        private Decoder decoder = Decoder.Instance;
        private Befehle befehle = Befehle.Instance;
        private int Quarzfrequenz = 2500;
        private Interrupter interrupter = Interrupter.Instance;
        //Tooltip
        ToolTip tooltipStepBack = new ToolTip();
        ToolTip tooltipStep = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            Tooltips();
            Fill_dgvRam();
            resetter.Reset();
            resetter.ResetBefehlsArray();
            GUIAktualisieren();
        }

        private void Tooltips()
        {
            tooltipStepBack.SetToolTip(btnStepBack, "Achtung: StepBack darf nicht zwischen call und return verwendet werden!");
            tooltipStep.SetToolTip(btnStep,"Einen Befehl ausführen");

        }

        private void Fill_dgvRam()
        {
            dgvRam0.ColumnCount = 10;
            dgvRam1.ColumnCount = 10;
            var rowCount = mem.ram.GetLength(0);
            var rowLength = mem.ram.GetLength(1);
            int hexincrement = 0x80;

            //Reihen hinzufügen
            for (int i = 0; i < 80; i++)
            {
                var row = new DataGridViewRow();

                dgvRam0.Rows.Add(row);
            }

            for (int i = 0; i < 80; i++)
            {
                var row = new DataGridViewRow();

                dgvRam1.Rows.Add(row);
            }

            //Nullen schreiben
            for (int i = 0; i < 80; i++)
            {
                for (int k = 2; k < 10; k++)
                {
                    dgvRam0[k, i].Value = 0;
                }
            }

            for (int i = 0; i < 80; i++)
            {
                for (int k = 2; k < 10; k++)
                {
                    dgvRam1[k, i].Value = 0;
                }
            }

            //Adressen schreiben
            for (int k = 0; k < 80; k++)
            {
                dgvRam0[0, k].Value = k.ToString("X2");
            }

            for (int k = 0; k < 80; k++)
            {
                dgvRam1[0, k].Value = hexincrement.ToString("X2");
                hexincrement++;
            }

            //Addressnamen eingetragen
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

        private void GUIAktualisieren()
        {
            //dgv
            for (int Spalte = 2; Spalte < 10; Spalte++)
            {
                int ramreihe = 0x80;

                for (int Reihe = 0; Reihe < 80; Reihe++)
                {
                    dgvRam0[Spalte, Reihe].Value = mem.ram[Spalte - 2, Reihe];

                    dgvRam1[Spalte, Reihe].Value = mem.ram[Spalte - 2, ramreihe];
                    ramreihe++;
                }
            }

            //Register
            lblWReg.Text = mem.WReg.ToString();
            lblPC.Text = mem.pc.ToString();

            //Quarzfrequenz
            lblBottomValueQuarzfrequenz.Text = Quarzfrequenz.ToString();
            //Stack
            lblStackContent0.Text = mem.StackArray[0].ToString();
            lblStackContent1.Text = mem.StackArray[1].ToString();
            lblStackContent2.Text = mem.StackArray[2].ToString();
            lblStackContent3.Text = mem.StackArray[3].ToString();
            lblStackContent4.Text = mem.StackArray[4].ToString();
            lblStackContent5.Text = mem.StackArray[5].ToString();
            lblStackContent6.Text = mem.StackArray[6].ToString();
            lblStackContent7.Text = mem.StackArray[7].ToString();

        }

        private void RamAktualisieren()
        {
            for (int Spalte = 2; Spalte < 10; Spalte++)
            {
                for (int Reihe = 0; Reihe < 80; Reihe++)
                {
                    mem.ram[Spalte - 2, Reihe] = (int)dgvRam0[Spalte, Reihe].Value;
                }
                int dgvRamReihe = 0;
                for (int Reihe = 128; Reihe < 207; Reihe++)
                {

                    mem.ram[Spalte - 2, Reihe] = (int)dgvRam1[Spalte, dgvRamReihe].Value;
                    dgvRamReihe++;
                }
            }
  
            
        }

        //Datei einlesen
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
                for (int i = 0; i < chartxt.Length; i++)
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

                        int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
                        //Befehle werden in Array gespeichert                        
                        mem.BefehlsArray[arrIndex] = num;
                        arrIndex += 1;

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
                for (int y = 0; y < mem.BefehlsArray.Length; y++)
                {
                    textBoxCode.Text = textBoxCode.Text + mem.BefehlsArray[y];
                }
            }
        }

        private void toolHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("D:/Stiiift_Inc/PicSim/Help/Help.pdf");
            }
            catch (Exception FileNotFoundException)
            {
                MessageBox.Show("File not found:" + FileNotFoundException);
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

        private void RegisterSynchronisieren(DataGridViewCellEventArgs e, DataGridViewTextBoxCell cell, DataGridViewTextBoxCell Reg)
        {
            if (e.ColumnIndex > 1) //Except String Cells
            {
                if ((int)cell.Value == 0)
                {
                    cell.Value = 1;

                    if (e.RowIndex == Const.INDF || e.RowIndex == Const.PCL || e.RowIndex == Const.STATUS
                        || e.RowIndex == Const.FSR || e.RowIndex == Const.PCLATH || e.RowIndex == Const.INTCON)
                    {
                        Reg.Value = 1;
                    }
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

        private void toolPlay_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                if (!backgroundWorker1.IsBusy)
                {
                    toolStatus.Text = "Status: running...";
                    backgroundWorker1.RunWorkerAsync(); //startet backgroundWorker1_DoWork Funktion
                }            
            }
        }

        private void toolPause_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();    //sagt Thread, er soll sich beenden
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetter.Reset();
            mem.pc = 0;
            GUIAktualisieren();
        }

        private void lblQuarzfrequenz_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtQuarzfrequenz.Text) < 2147483648)
                {
                    Quarzfrequenz = int.Parse(txtQuarzfrequenz.Text);
                    GUIAktualisieren();
                }
                else
                {
                    MessageBox.Show("Quarzwert zu groß");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nur int erlaubt!");
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
<<<<<<< HEAD
                mem.TimerValOld = befehle.getFileVal(0x01);
                mem.Ra4ValOld = mem.ram[4, Const.PORTA];
               
=======
                CheckForSleep();
                interrupter.CheckInterrupt(); //TODO evtl Thread benötigt (externe Interrupts - um sleep zu beenden)
                mem.SafeBack();
>>>>>>> refs/remotes/origin/master
                decoder.Decode(mem.BefehlsArray[mem.pc]);
                mem.pc++;

                befehle.CheckTimer();
                mem.Ra4ValNew = mem.ram[4, Const.PORTA];
              



                GUIAktualisieren();
                //RamAktualisieren();
            }
        }
        //StepBack nicht zwischen Calls anwenden!
        private void btnStepBack_Click(object sender, EventArgs e)
        {
            
            if (textBoxCode.Text == "")
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                mem.BackCount--;
                if ((mem.pc > 0) && (mem.BackCount > 0))
                {
                    //mem.BackArray = (int[,])mem.BackStack.Pop();
                    for (int adresse = 0; adresse < mem.length; adresse++)
                    {
                        for (int bits = 0; bits < 8; bits++)
                        {
                            mem.ram[bits, adresse] = mem.BackArray[bits, adresse, mem.BackCount];
                        }
                    }
                    mem.pc = mem.BackArray[0, 256, mem.BackCount];
                    mem.WReg = mem.BackArray[1, 256, mem.BackCount];
                    //Stack

                    for (int StackPos = 0; StackPos < 8; StackPos++)
                    {

                        mem.StackArray[StackPos] = mem.BackArray[StackPos, 257, mem.BackCount];
                        mem.Stack.Push(mem.StackArray[StackPos]);

                    }

                }
                else
                {
                    if (mem.pc == 0)
                    {
                        MessageBox.Show("Programmstart erreicht");
                    }
                    if (mem.BackCount >= 100)
                    {
                        MessageBox.Show("Error: Back nicht mehr möglich");
                    }
                }
                GUIAktualisieren();
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (mem.pc < mem.BefehlsArray.Length) //evtl while Schleife eleganter?
            {

                if (backgroundWorker1.CancellationPending == true)  //ist True, wenn Pause Button gedrückt wurde
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(mem.pc);
                    return;
                }
                CheckForSleep();
                interrupter.CheckInterrupt(); //TODO evtl Thread benötigt (externe Interrupts - um sleep zu beenden)
                decoder.Decode(mem.BefehlsArray[mem.pc]);
                mem.pc++;

                backgroundWorker1.ReportProgress(mem.pc); //ruft backgroundWorker1_ProgressChanged Funktion auf, also GUIaktualisieren
                
                System.Threading.Thread.Sleep(Quarzfrequenz); //Quarzfrequenz??
            }        
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            GUIAktualisieren();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            toolStatus.Text = "Status: stopped";
        }


        public void CheckForSleep()
        {
            //PD Bit checken
            if (mem.ram[3, Const.STATUS] == 0)
            {
                //TODO den PIC schlafen lassen, bis powerup oder clrwdt
                //TODO Backgroundworker anhalten
                while (true)
                {
                    //Wenn clrwdt --> PD = 1
                    //Wenn Interupt an RB0, RB4-7 -> aufwachen
                    //Interrupter setzt PD im RAM auf 1
                    if (mem.ram[3, Const.STATUS] == 1)
                    {
                        return;
                    }
                    //TODO evtl sleep einbauen?
                }
            }
        }


    }
}
 