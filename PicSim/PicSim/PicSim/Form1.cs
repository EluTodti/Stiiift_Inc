﻿using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;



namespace PicSim
{
    public partial class Form1 : Form
    {
        #region Singleton

        private static object m_lock = new object();
        private static Form1 instance;

        public static Form1 getInstance()
        {

            if (instance == null)
            {
                lock (m_lock)
                {
                    if (instance == null)
                    {
                        instance = new Form1();

                    }
                }
            }
            return instance;
        }

        #endregion

        #region Init

        private SerialPorts serial = new SerialPorts("COM1");
        private SerialPorts answer = new SerialPorts("COM2");
        private Resetter resetter = new Resetter();
        private Memory mem = Memory.Instance;
        private Decoder decoder = Decoder.Instance;
        private Interrupter interrupter = Interrupter.Instance;
        private Befehle befehle = Befehle.Instance;
        private bool FileIsLoaded = false;
        private bool StepBackEnablen = false;
        SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\..\..\..\Sounds\Pink_Fluffy_Unicorns_Dancing_On_Rainbows.wav");
        
        #endregion Init

        #region Init SerialPort

        private bool _continue;
        SerialPorts _serialPort = new SerialPorts("COM1");
        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        private string message = "";

        #endregion Init SerialPort

        ToolTip tooltipStepBack = new ToolTip();
        ToolTip tooltipStep = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            //textBoxCode.ScrollBars = ScrollBars.Vertical;
            Tooltips();
            Fill_dgvRam();
            resetter.Reset();
            resetter.ResetBefehlsArray();
            GUIAktualisieren();
            NichtNutzbareButtons();
        }
        //TrisA 7-5 nicht veränderbar
        private void NichtNutzbareButtons()
        {
            btnTrisA5.Enabled = false;
            btnTrisA6.Enabled = false;
            btnTrisA7.Enabled = false;
            //Nur Anfangs nicht klickbar
            btnSerialAusschalten.Enabled = false;
            pictureBox.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            txtDisableUnicornMode.Visible = false;
            txtChangeSong.Visible = false;
        }
        private void Tooltips()
        {
            tooltipStepBack.SetToolTip(btnStepBack,
                "Achtung: StepBack darf nicht zwischen call und return verwendet werden!");
            tooltipStep.SetToolTip(btnStep, "Einen Befehl ausführen");
        }

        #region Ram

        private void Fill_dgvRam()
        {
            dgvRam0.ColumnCount = 10;
            dgvRam1.ColumnCount = 10;
            dgvCode.ColumnCount = 4;
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

        private void RamAktualisieren()
        {
            for (int Spalte = 2; Spalte < 10; Spalte++)
            {
                for (int Reihe = 0; Reihe < 80; Reihe++)
                {
                    mem.ram[Spalte - 2, Reihe] = (int) dgvRam0[Spalte, Reihe].Value;
                }
                int dgvRamReihe = 0;
                for (int Reihe = 128; Reihe < 207; Reihe++)
                {

                    mem.ram[Spalte - 2, Reihe] = (int) dgvRam1[Spalte, dgvRamReihe].Value;
                    dgvRamReihe++;
                }
            }


        }

        #endregion Ram

        #region GUI Aktualisieren

        //GUIAktualisieren===========================================================
        public void GUIAktualisieren()
        {
            AktualisiereDGV();
            AktualisiereRegister();
            AktualisiereQuarzfrequenz();
            AktualisiereStack();
            AktualisierePorts();
            AktualisiereTris();
            if (StepBackEnablen)
            {
                AktualisiereButtons();
            }
            else
            {
                btnStepBack.Enabled = false;
                AktualisiereButtons();
            }
            richTextBox1.Text = message;
        }

        private void AktualisiereDGV()
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
        }

        private void AktualisiereRegister()
        {
            //Register
            lblWReg.Text = mem.WReg.ToString("X");
            lblPC.Text = mem.pc.ToString("X");
            lblLaufzeitzaehler.Text = mem.Laufzeitzaehler.ToString("0.## µs");
        }

        private void AktualisiereQuarzfrequenz()
        {
            //Quarzfrequenz
            lblBottomValueQuarzfrequenz.Text = mem.Quarzfrequenz.ToString();
            txtQuarzfrequenz.Text = mem.Quarzfrequenz.ToString();
        }

        private void AktualisiereStack()
        {
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

        private void AktualisierePorts()
        {
            //PortA                
            btnPortA0.Text = mem.ram[0, Const.PORTA].ToString();
            btnPortA1.Text = mem.ram[1, Const.PORTA].ToString();
            btnPortA2.Text = mem.ram[2, Const.PORTA].ToString();
            btnPortA3.Text = mem.ram[3, Const.PORTA].ToString();
            btnPortA4.Text = mem.ram[4, Const.PORTA].ToString();
            btnPortA5.Text = mem.ram[5, Const.PORTA].ToString();
            btnPortA6.Text = mem.ram[6, Const.PORTA].ToString();
            btnPortA7.Text = mem.ram[7, Const.PORTA].ToString();

            //PortB
            btnPortB0.Text = mem.ram[0, Const.PORTB].ToString();
            btnPortB1.Text = mem.ram[1, Const.PORTB].ToString();
            btnPortB2.Text = mem.ram[2, Const.PORTB].ToString();
            btnPortB3.Text = mem.ram[3, Const.PORTB].ToString();
            btnPortB4.Text = mem.ram[4, Const.PORTB].ToString();
            btnPortB5.Text = mem.ram[5, Const.PORTB].ToString();
            btnPortB6.Text = mem.ram[6, Const.PORTB].ToString();
            btnPortB7.Text = mem.ram[7, Const.PORTB].ToString();
        }

        private void AktualisiereTris()
        {
            //TrisA
            btnTrisA0.Text = mem.ram[0, Const.TRISA + 128].ToString();
            btnTrisA1.Text = mem.ram[1, Const.TRISA + 128].ToString();
            btnTrisA2.Text = mem.ram[2, Const.TRISA + 128].ToString();
            btnTrisA3.Text = mem.ram[3, Const.TRISA + 128].ToString();
            btnTrisA4.Text = mem.ram[4, Const.TRISA + 128].ToString();
            btnTrisA5.Text = mem.ram[5, Const.TRISA + 128].ToString();
            btnTrisA6.Text = mem.ram[6, Const.TRISA + 128].ToString();
            btnTrisA7.Text = mem.ram[7, Const.TRISA + 128].ToString();

            //TrisB
            btnTrisB0.Text = mem.ram[0, Const.TRISB + 128].ToString();
            btnTrisB1.Text = mem.ram[1, Const.TRISB + 128].ToString();
            btnTrisB2.Text = mem.ram[2, Const.TRISB + 128].ToString();
            btnTrisB3.Text = mem.ram[3, Const.TRISB + 128].ToString();
            btnTrisB4.Text = mem.ram[4, Const.TRISB + 128].ToString();
            btnTrisB5.Text = mem.ram[5, Const.TRISB + 128].ToString();
            btnTrisB6.Text = mem.ram[6, Const.TRISB + 128].ToString();
            btnTrisB7.Text = mem.ram[7, Const.TRISB + 128].ToString();
        }

        private void AktualisiereButtons()
        {
            if (mem.StepBackEnabled)
            {
                //btnStepBack.Enabled = true;
                checkStepBack.Checked = true;
                checkStepBack.BackColor = Color.Lime;
                checkStepBack.Text = "StepBack enabled";
            }
            else
            {
                //btnStepBack.Enabled = false;
                checkStepBack.Checked = false;
                checkStepBack.BackColor = Color.Crimson;
                checkStepBack.Text = "StepBack disabled";
            }
        }

        //=========================================================================================

        #endregion GUI Aktualisieren

        #region DataGridView click

        //dgvRam click-------
        private void dgvRam0_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                    dgvRam0.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewTextBoxCell RegB1 = (DataGridViewTextBoxCell)
                    dgvRam1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                RegisterSynchronisieren(e, cell, RegB1);
            }
            catch (ArgumentOutOfRangeException)
            {
                //Verhindert Absturz wenn RowHeader geklickt wird
            }
        }

        private void dgvRam1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dgvRam1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewTextBoxCell RegB0 = (DataGridViewTextBoxCell)
                dgvRam0.Rows[e.RowIndex].Cells[e.ColumnIndex];
            RegisterSynchronisieren(e, cell, RegB0);
        }

        private void RegisterSynchronisieren(DataGridViewCellEventArgs e, DataGridViewTextBoxCell cell,
            DataGridViewTextBoxCell Reg)
        {
            if (e.ColumnIndex > 1) //Except String Cells
            {
                if ((int) cell.Value == 0)
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

        //-------------------
        private void dgvCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nur CheckBoxes
            if (dgvCode.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)
                    dgvCode.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string CellValue = "";
                if (cell.Value.Equals(false))
                {
                    cell.TrueValue = true;
                    DataGridViewCheckBoxCell pcCell = (DataGridViewCheckBoxCell) dgvCode.CurrentCell;
                    CellValue = (string) dgvCode[1, pcCell.RowIndex].Value;
                    try
                    {
                        mem.BreakPointArray[mem.BPArrayIndex] = Convert.ToInt32(CellValue, 16);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zeile ohne Code ausgewählt");
                        return;
                    }
                    cell.Value = cell.TrueValue;
                    mem.BPArrayIndex++;
                    System.Array.Sort(mem.BreakPointArray);
                }
                else
                {
                    cell.FalseValue = false;
                    cell.Value = cell.FalseValue;
                    mem.BreakPointArray[0] = 1000000;
                    System.Array.Sort(mem.BreakPointArray);
                }
            }
        }
        

        //======================================================

        #endregion DataGridView click

        #region BackgroundWorker1

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (mem.pc < mem.BefehlsArray.Length) //evtl while Schleife eleganter?
            {
                if (backgroundWorker1.CancellationPending == true) //ist True, wenn Pause Button gedrückt wurde
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(mem.pc);
                    return;
                }
                CheckForSleep();
                interrupter.CheckInterrupt(); //TODO evtl Thread benötigt (externe Interrupts - um sleep zu beenden)

                decoder.Decode(mem.BefehlsArray[mem.pc]);
                CheckBreakpoints();

                backgroundWorker1
                    .ReportProgress(mem
                        .pc); //ruft backgroundWorker1_ProgressChanged Funktion auf, also GUIaktualisieren             

                System.Threading.Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            GUIAktualisieren();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender,
            System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            toolStatus.Text = "Status: stopped";
        }

        #endregion BackgroundWorker1

        #region BackgroundWorker2

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (backgroundWorker2.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                interrupter.CheckRA4();
                interrupter.CheckRB0();
                interrupter.ChechRB47();

                if (mem.watchdog > 18000)
                {
                    mem.ram[4, Const.STATUS] = 0;
                    backgroundWorker2.ReportProgress(1);
                }
                System.Threading.Thread.Sleep(10);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            resetter.Reset();
        }

        #endregion BackgroundWorker2

        public void CheckForSleep()
        {

            //PD Bit checken
            if (mem.ram[3, Const.STATUS] == 0)
            {
                mem.watchdog = 0;
                //TODO den PIC schlafen lassen, bis powerup oder clrwdt
                //TODO Backgroundworker anhalten
                while (true)
                {
                    if (backgroundWorker1.CancellationPending == true)
                    {
                        return;
                    }
                    //Wenn clrwdt --> PD = 1
                    //Wenn Interupt an RB0, RB4-7 -> aufwachen
                    //Interrupter setzt PD im RAM auf 1
                    interrupter.CheckInterrupt();
                    if (mem.ram[3, Const.STATUS] == 1)
                    {
                        return;
                    }
                    if (mem.ram[4, Const.STATUS] == 0) //WatchdogOverflow
                        return;

                    befehle.InkrementWDT();
                    mem.IncLaufzeitzaehler();
                    backgroundWorker1.ReportProgress(mem.pc);
                    System.Threading.Thread.Sleep(20);
                }
            }
        }

        public void CheckBreakpoints()
        {
            System.Array.Sort(mem.BreakPointArray);
            if (mem.pc == mem.BreakPointArray[0])
            {
                for (int i = 0; i < mem.BreakPointArray.Length - 1; i++)
                {
                    mem.BreakPointArray[i] = mem.BreakPointArray[i + 1];
                }
                backgroundWorker1.CancelAsync(); //sagt Thread, er soll sich beenden
                /* Versuch die Farbe zu ändern wenn Breakpoint angekommen
                foreach (DataGridViewRow row in dgvCode.Rows)
                 {
                     if((bool)row.Cells[0].Value && Convert.ToInt32((string)row.Cells[1].Value,16) == mem.pc)
                     {
                         row.DefaultCellStyle.BackColor = Color.Yellow;
                     }
                 }*/
            }

        }

        //==============================

        #region GuiClick         

        //Gui click
        private void toolPlay_Click(object sender, EventArgs e)
        {
            if (!FileIsLoaded)
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
                if (!backgroundWorker2.IsBusy)
                {
                    toolStatus.Text = "Status: running...";
                    backgroundWorker2.RunWorkerAsync(); //startet backgroundWorker1_DoWork Funktion
                }
            }
            EnableButtonsCasePlay(true);
        }

        private void toolPause_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync(); //sagt Thread, er soll sich beenden
            }

            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync(); //sagt Thread, er soll sich beenden
            }
            EnableButtonsCasePlay(false);
        }

        private void EnableButtonsCasePlay(bool play)
        {
            btnStepBack.Enabled = !play;
            toolPlay.Enabled = !play;
            toolPause.Enabled = play;
            btnReset.Enabled = !play;
            toolStop.Enabled = !play;
            btnStep.Enabled = !play;
            toolFile.Enabled = !play;
            checkStepBack.Enabled = !play;
            btnStepBack.Enabled = !play;
            StepBackEnablen = !play;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetter.Reset();
            GUIAktualisieren();
        }

        private void toolStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync(); //sagt Thread, er soll sich beenden
            }
            resetter.Reset();
            GUIAktualisieren();
        }

        private void lblQuarzfrequenz_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtQuarzfrequenz.Text) < 2147483647)
                {
                    mem.Quarzfrequenz = double.Parse(txtQuarzfrequenz.Text);
                    mem.LaufzeitIntervall = (double) 4.0 / (mem.Quarzfrequenz / (double) 1000000.0);
                    GUIAktualisieren();
                }
                else
                {
                    MessageBox.Show("Quarzwert zu groß");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nur int erlaubt!");
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (!FileIsLoaded)
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                CheckForSleep();
                interrupter.CheckInterrupt(); //TODO evtl Thread benötigt (externe Interrupts - um sleep zu beenden)

                decoder.Decode(mem.BefehlsArray[mem.pc]);
                GUIAktualisieren();
            }
            btnStepBack.Enabled = true;
        }

        private void toolHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            try
            {
                System.Diagnostics.Process.Start(@"..\..\..\..\Help\Help.pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
            }
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {

        }

        private void txtUnicorn_Click(object sender, EventArgs e)
        {           
            this.BackColor = System.Drawing.Color.HotPink;
            pictureBox.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            txtUnicorn.Visible = false;
            txtDisableUnicornMode.Visible = true;
            txtChangeSong.Visible = true;
            try
            {
                simpleSound.PlayLooping();
            }
            catch (Exception)
            {
                MessageBox.Show("Datei nicht gefunden");
            }

        }
        private void txtDisableUnicornMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
            pictureBox.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            txtUnicorn.Visible = true;
            txtDisableUnicornMode.Visible = false;
            txtChangeSong.Visible = false;
            simpleSound.Stop();
            simpleSound = simpleSound = new SoundPlayer(@"..\..\..\..\..\..\Sounds\Pink_Fluffy_Unicorns_Dancing_On_Rainbows.wav");
        }

        private void txtChangeSong_Click(object sender, EventArgs e)
        {
            try
            {
                simpleSound = new SoundPlayer(@"..\..\..\..\..\..\Sounds\Look_at_my_horse.wav");
                simpleSound.PlayLooping();
            }
            catch (Exception)
            {
                MessageBox.Show("Datei nicht gefunden");
            }

        }
        //Datei einlesen-----
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dgvCode.Rows.Clear();
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                Loader.LadeDatei(sr);
                /*Nur zum testen
                for (int y = 0; y < mem.BefehlsArray.Length; y++)
                {
                    textBoxCode.Text = textBoxCode.Text + mem.BefehlsArray[y];
                }*/
            }
        }

        public void LadeInDGVCode(DataGridViewRow row, string ProgrammZeile, string Code, string HexCode)
        {

            if (HexCode.Trim() == "")
            {
                int i = dgvCode.Rows.Add(new object[] {false, ProgrammZeile, HexCode, Code});
                dgvCode.Rows[i].ReadOnly = true;
            }
            else
            {
                dgvCode.Rows.Add(new object[] {false, ProgrammZeile, HexCode, Code});
            }
            FileIsLoaded = true;
        }

        //-------------------
        //StepBack-----------
        //StepBack nicht zwischen Calls anwenden!
        private void btnStepBack_Click(object sender, EventArgs e)
        {

            if (!FileIsLoaded)
            {
                MessageBox.Show("Kein Code gefunden!");
            }
            else
            {
                //Ringarray
                if (mem.BackCount == 0)
                {
                    mem.BackCount = 99;
                }
                else
                {
                    mem.BackCount--;
                }
                if ((mem.pc > 0) && (mem.CountOfStepsSafed > 0))
                {
                    DoBack();
                    ;
                }
                else
                {
                    if (mem.pc == 0)
                    {
                        MessageBox.Show("Programmstart erreicht");
                    }
                    if (mem.CountOfStepsSafed <= 0)
                    {
                        MessageBox.Show("Error: Back nicht mehr möglich, maximal 100 x StepBack erreicht");
                    }
                }
                GUIAktualisieren();
            }

        }

        private void DoBack()
        {
            mem.CountOfStepsSafed--;
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
            mem.Laufzeitzaehler = (double) mem.BackArray[2, 256, mem.BackCount];
            mem.Quarzfrequenz = (double) mem.BackArray[3, 256, mem.BackCount];
            mem.TimerValOld = mem.BackArray[4, 256, mem.BackCount];
            mem.TimerValNew = mem.BackArray[5, 256, mem.BackCount];
            mem.TimerInhibit = mem.BackArray[6, 256, mem.BackCount];
            mem.watchdog = (double) mem.BackArray[7, 256, mem.BackCount];
            mem.prescaler = mem.BackArray[0, 258, mem.BackCount];
            if (mem.BackArray[1, 258, mem.BackCount] == 1)
            {
                mem.PrescalerTIMER0 = true;
            }
            else
            {
                mem.PrescalerTIMER0 = false;
            }
            mem.Ra4old = mem.BackArray[2, 258, mem.BackCount];
            mem.Ra4new = mem.BackArray[3, 258, mem.BackCount];
            //Stack
            for (int StackPos = 0; StackPos < 8; StackPos++)
            {
                mem.StackArray[StackPos] = mem.BackArray[StackPos, 257, mem.BackCount];
                mem.Stack.Push(mem.StackArray[StackPos]);
            }
        }

        //-------------------

        #region Latchfunktion der IO-Register

        private void btnPortA0_Click(object sender, EventArgs e)
        {
            if (btnPortA0.Text == "0")
            {
                mem.ram[0, Const.PORTA] = 1;
            }
            else
            {
                mem.ram[0, Const.PORTA] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortA1_Click(object sender, EventArgs e)
        {
            if (btnPortA1.Text == "0")
            {
                mem.ram[1, Const.PORTA] = 1;
            }
            else
            {
                mem.ram[1, Const.PORTA] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortA2_Click(object sender, EventArgs e)
        {
            if (btnPortA2.Text == "0")
            {
                mem.ram[2, Const.PORTA] = 1;
            }
            else
            {
                mem.ram[2, Const.PORTA] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortA3_Click(object sender, EventArgs e)
        {
            if (btnPortA3.Text == "0")
            {
                mem.ram[3, Const.PORTA] = 1;
            }
            else
            {
                mem.ram[3, Const.PORTA] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortA4_Click(object sender, EventArgs e)
        {
            if (btnPortA4.Text == "0")
            {
                mem.ram[4, Const.PORTA] = 1;
            }
            else
            {
                mem.ram[4, Const.PORTA] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortA5_Click(object sender, EventArgs e)
        {
            //0
        }

        private void btnPortA6_Click(object sender, EventArgs e)
        {
            //0
        }

        private void btnPortA7_Click(object sender, EventArgs e)
        {
            //0
        }

        private void btnPortB0_Click(object sender, EventArgs e)
        {
            if (btnPortB0.Text == "0")
            {
                mem.ram[0, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[0, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB1_Click(object sender, EventArgs e)
        {
            if (btnPortB1.Text == "0")
            {
                mem.ram[1, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[1, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB2_Click(object sender, EventArgs e)
        {
            if (btnPortB2.Text == "0")
            {
                mem.ram[2, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[2, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB3_Click(object sender, EventArgs e)
        {
            if (btnPortB3.Text == "0")
            {
                mem.ram[3, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[3, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB4_Click(object sender, EventArgs e)
        {
            if (btnPortB4.Text == "0")
            {
                mem.ram[4, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[4, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB5_Click(object sender, EventArgs e)
        {
            if (btnPortB5.Text == "0")
            {
                mem.ram[5, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[5, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB6_Click(object sender, EventArgs e)
        {
            if (btnPortB6.Text == "0")
            {
                mem.ram[6, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[6, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        private void btnPortB7_Click(object sender, EventArgs e)
        {
            if (btnPortB7.Text == "0")
            {
                mem.ram[7, Const.PORTB] = 1;
            }
            else
            {
                mem.ram[7, Const.PORTB] = 0;
            }
            GUIAktualisieren();
        }

        //Tris
        private void btnTrisA0_Click(object sender, EventArgs e)
        {
            if (btnTrisA0.Text == "0")
            {
                mem.ram[0, Const.TRISA + 128] = 1;
            }
            else
            {
                mem.ram[0, Const.TRISA + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisA1_Click(object sender, EventArgs e)
        {
            if (btnTrisA1.Text == "0")
            {
                mem.ram[1, Const.TRISA + 128] = 1;
            }
            else
            {
                mem.ram[1, Const.TRISA + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisA2_Click(object sender, EventArgs e)
        {
            if (btnTrisA2.Text == "0")
            {
                mem.ram[2, Const.TRISA + 128] = 1;
            }
            else
            {
                mem.ram[2, Const.TRISA + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisA3_Click(object sender, EventArgs e)
        {
            if (btnTrisA3.Text == "0")
            {
                mem.ram[3, Const.TRISA + 128] = 1;
            }
            else
            {
                mem.ram[3, Const.TRISA + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisA4_Click(object sender, EventArgs e)
        {
            if (btnTrisA4.Text == "0")
            {
                mem.ram[4, Const.TRISA + 128] = 1;
            }
            else
            {
                mem.ram[4, Const.TRISA + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisA5_Click(object sender, EventArgs e)
        {
            // 0
        }

        private void btnTrisA6_Click(object sender, EventArgs e)
        {
            // 0
        }

        private void btnTrisA7_Click(object sender, EventArgs e)
        {
            // 0
        }

        private void btnTrisB0_Click(object sender, EventArgs e)
        {
            if (btnTrisB0.Text == "0")
            {
                mem.ram[0, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[0, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB1_Click(object sender, EventArgs e)
        {
            if (btnTrisB1.Text == "0")
            {
                mem.ram[1, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[1, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB2_Click(object sender, EventArgs e)
        {
            if (btnTrisB2.Text == "0")
            {
                mem.ram[2, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[2, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB3_Click(object sender, EventArgs e)
        {
            if (btnTrisB3.Text == "0")
            {
                mem.ram[3, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[3, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB4_Click(object sender, EventArgs e)
        {
            if (btnTrisB4.Text == "0")
            {
                mem.ram[4, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[4, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB5_Click(object sender, EventArgs e)
        {
            if (btnTrisB5.Text == "0")
            {
                mem.ram[5, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[5, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB6_Click(object sender, EventArgs e)
        {
            if (btnTrisB6.Text == "0")
            {
                mem.ram[6, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[6, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        private void btnTrisB7_Click(object sender, EventArgs e)
        {
            if (btnTrisB7.Text == "0")
            {
                mem.ram[7, Const.TRISB + 128] = 1;
            }
            else
            {
                mem.ram[7, Const.TRISB + 128] = 0;
            }
            GUIAktualisieren();
        }

        #endregion Latchfunktion der IO-Register

        private void checkStepBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (mem.StepBackEnabled)
            {
                mem.StepBackEnabled = false;
            }
            else
            {
                mem.StepBackEnabled = true;
            }
            GUIAktualisieren();
        }

        #endregion GuiClick

        //==========================================================

        #region SerialPort

        private void btnSerialEinschalten_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Kein COM Port verfügbar");
            }
            _continue = true;
            if (!backgroundWorkerSerialPort.IsBusy)
            {
                btnSerialEinschalten.Enabled = false;
                btnSerialEinschalten.Enabled = true;
                backgroundWorkerSerialPort.RunWorkerAsync(); //startet backgroundWorker1_DoWork Funktion
            }
            btnSerialAusschalten.Enabled = true;
            btnSerialEinschalten.Enabled = false;
        }

        private void btnSerialAusschalten_Click(object sender, EventArgs e)
        {
            btnSerialAusschalten.Enabled = false;
            btnSerialEinschalten.Enabled = true;
            try
            {
                _serialPort.Close();
            }
            catch (Exception)
            {
            }

            if (backgroundWorkerSerialPort.IsBusy)
            {
                backgroundWorkerSerialPort.CancelAsync(); //sagt Thread, er soll sich beenden
            }

        }

        private void backgroundWorkerSerialPort_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            string messagetosend = "";
            if (backgroundWorkerSerialPort.CancellationPending == true) //ist True, wenn Pause Button gedrückt wurde
            {
                e.Cancel = true;
                backgroundWorkerSerialPort.ReportProgress(mem.pc);
                return;
            }
            //senden
            messagetosend = _serialPort.PCsenden(); //return + sendet
            //empfangen
            try
            {
                message = _serialPort.PCempfangen();
                MessageBox.Show("Empfangen: " + message);
            }
            catch (TimeoutException)
            {
                //MessageBox.Show("Kein Empfang");
            }

            backgroundWorkerSerialPort
                .ReportProgress(mem.pc); //ruft backgroundWorkerSerialPort_ProgressChanged Funktion auf          
            System.Threading.Thread.Sleep(20);
        }

        private void backgroundWorkerSerialPort_ProgressChanged(object sender,
            System.ComponentModel.ProgressChangedEventArgs e)
        {
            GUIAktualisieren();
        }

        private void backgroundWorkerSerialPort_RunWorkerCompleted(object sender,
            System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }


        #endregion SerialPort

        private void txtQuarzfrequenz_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.Parse(txtQuarzfrequenz.Text) < 2147483647)
                    {
                        mem.Quarzfrequenz = double.Parse(txtQuarzfrequenz.Text);
                        mem.LaufzeitIntervall = (double) 4.0 / (mem.Quarzfrequenz / (double) 1000000.0);
                        GUIAktualisieren();
                    }
                    else
                    {
                        MessageBox.Show("Quarzwert zu groß");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nur int erlaubt!");
                }
            }


        }
    }
}
 