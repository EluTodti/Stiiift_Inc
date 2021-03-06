﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace PicSim
{


    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtQuarzfrequenz = new System.Windows.Forms.ToolStripTextBox();
            this.lblQuarzfrequenz = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUnicorn = new System.Windows.Forms.ToolStripLabel();
            this.toolPlay = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.toolStatus = new System.Windows.Forms.ToolStripLabel();
            this.txtDisableUnicornMode = new System.Windows.Forms.ToolStripLabel();
            this.txtChangeSong = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBottomValueQuarzfrequenz = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBottomQuarzfrequenz = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBottomC = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvRam0 = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRam1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWReg = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.btnStep = new System.Windows.Forms.Button();
            this.tableLayoutStack = new System.Windows.Forms.TableLayoutPanel();
            this.lblStackContent0 = new System.Windows.Forms.Label();
            this.lblStackAddr0 = new System.Windows.Forms.Label();
            this.lblStackContent1 = new System.Windows.Forms.Label();
            this.lblStackContent2 = new System.Windows.Forms.Label();
            this.lblStackContent3 = new System.Windows.Forms.Label();
            this.lblStackContent4 = new System.Windows.Forms.Label();
            this.lblStackContent5 = new System.Windows.Forms.Label();
            this.lblStackContent6 = new System.Windows.Forms.Label();
            this.lblStackContent7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStackAddr = new System.Windows.Forms.Label();
            this.lblStackAddr1 = new System.Windows.Forms.Label();
            this.lblStackAddr2 = new System.Windows.Forms.Label();
            this.lblStackAddr3 = new System.Windows.Forms.Label();
            this.lblStackAddr4 = new System.Windows.Forms.Label();
            this.lblStackAddr5 = new System.Windows.Forms.Label();
            this.lblStackAddr6 = new System.Windows.Forms.Label();
            this.lblStackAddr7 = new System.Windows.Forms.Label();
            this.tableLayoutSpezialregister = new System.Windows.Forms.TableLayoutPanel();
            this.lblPCTxt = new System.Windows.Forms.Label();
            this.lblWRegTxt = new System.Windows.Forms.Label();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLaufzeitzaehler = new System.Windows.Forms.Label();
            this.txtLaufzeitzaehler = new System.Windows.Forms.Label();
            this.dgvCode = new System.Windows.Forms.DataGridView();
            this.BreakPoint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HexCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPortA7 = new System.Windows.Forms.Button();
            this.btnPortB7 = new System.Windows.Forms.Button();
            this.btnPortB6 = new System.Windows.Forms.Button();
            this.btnPortA6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPortB5 = new System.Windows.Forms.Button();
            this.btnPortA5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPortB4 = new System.Windows.Forms.Button();
            this.btnPortA4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPortB3 = new System.Windows.Forms.Button();
            this.btnPortA3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPortB2 = new System.Windows.Forms.Button();
            this.btnPortA2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPortB1 = new System.Windows.Forms.Button();
            this.btnPortA1 = new System.Windows.Forms.Button();
            this.btnPortB0 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPortB = new System.Windows.Forms.Label();
            this.lblPortA = new System.Windows.Forms.Label();
            this.btnPortA0 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrisA7 = new System.Windows.Forms.Button();
            this.btnTrisB7 = new System.Windows.Forms.Button();
            this.btnTrisB6 = new System.Windows.Forms.Button();
            this.btnTrisA6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrisB5 = new System.Windows.Forms.Button();
            this.btnTrisA5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTrisB4 = new System.Windows.Forms.Button();
            this.btnTrisA4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTrisB3 = new System.Windows.Forms.Button();
            this.btnTrisA3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTrisB2 = new System.Windows.Forms.Button();
            this.btnTrisA2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTrisB1 = new System.Windows.Forms.Button();
            this.btnTrisA1 = new System.Windows.Forms.Button();
            this.btnTrisB0 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTrisB = new System.Windows.Forms.Label();
            this.lblTrisA = new System.Windows.Forms.Label();
            this.btnTrisA0 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.checkStepBack = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSerialEinschalten = new System.Windows.Forms.Button();
            this.btnSerialAusschalten = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorkerSerialPort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Herz = new System.Windows.Forms.ToolStripLabel();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam0)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam1)).BeginInit();
            this.tableLayoutStack.SuspendLayout();
            this.tableLayoutSpezialregister.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtQuarzfrequenz,
            this.Herz,
            this.lblQuarzfrequenz,
            this.toolStripSeparator2,
            this.txtUnicorn,
            this.toolPlay,
            this.toolPause,
            this.toolStop,
            this.toolStatus,
            this.txtDisableUnicornMode,
            this.txtChangeSong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1914, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtQuarzfrequenz
            // 
            this.txtQuarzfrequenz.AcceptsReturn = true;
            this.txtQuarzfrequenz.Name = "txtQuarzfrequenz";
            this.txtQuarzfrequenz.Size = new System.Drawing.Size(100, 27);
            this.txtQuarzfrequenz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuarzfrequenz_KeyDown);
            // 
            // lblQuarzfrequenz
            // 
            this.lblQuarzfrequenz.Name = "lblQuarzfrequenz";
            this.lblQuarzfrequenz.Size = new System.Drawing.Size(106, 24);
            this.lblQuarzfrequenz.Text = "Quarzfrequenz";
            this.lblQuarzfrequenz.Click += new System.EventHandler(this.lblQuarzfrequenz_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtUnicorn
            // 
            this.txtUnicorn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUnicorn.Name = "txtUnicorn";
            this.txtUnicorn.Size = new System.Drawing.Size(105, 24);
            this.txtUnicorn.Text = "Unicorn magic";
            this.txtUnicorn.Click += new System.EventHandler(this.txtUnicorn_Click);
            // 
            // toolPlay
            // 
            this.toolPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPlay.Image = global::PicSim.Properties.Resources.Play;
            this.toolPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPlay.Name = "toolPlay";
            this.toolPlay.Size = new System.Drawing.Size(24, 24);
            this.toolPlay.Text = "Play";
            this.toolPlay.Click += new System.EventHandler(this.toolPlay_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPause.Image = global::PicSim.Properties.Resources.Pause;
            this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPause.Name = "toolPause";
            this.toolPause.Size = new System.Drawing.Size(24, 24);
            this.toolPause.Text = "Pause";
            this.toolPause.Click += new System.EventHandler(this.toolPause_Click);
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Image = global::PicSim.Properties.Resources.Stop;
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(24, 24);
            this.toolStop.Text = "Stop";
            this.toolStop.Click += new System.EventHandler(this.toolStop_Click);
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.toolStatus.Size = new System.Drawing.Size(171, 24);
            this.toolStatus.Text = "Status: stopped";
            // 
            // txtDisableUnicornMode
            // 
            this.txtDisableUnicornMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtDisableUnicornMode.Name = "txtDisableUnicornMode";
            this.txtDisableUnicornMode.Size = new System.Drawing.Size(159, 24);
            this.txtDisableUnicornMode.Text = "Disable Unicorn-Mode";
            this.txtDisableUnicornMode.Click += new System.EventHandler(this.txtDisableUnicornMode_Click);
            // 
            // txtChangeSong
            // 
            this.txtChangeSong.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtChangeSong.Name = "txtChangeSong";
            this.txtChangeSong.Size = new System.Drawing.Size(93, 24);
            this.txtChangeSong.Text = "ChangeSong";
            this.txtChangeSong.Click += new System.EventHandler(this.txtChangeSong_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1914, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(44, 24);
            this.toolFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolHelp.BackColor = System.Drawing.SystemColors.Control;
            this.toolHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(53, 24);
            this.toolHelp.Text = "Help";
            this.toolHelp.Click += new System.EventHandler(this.toolHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBottomValueQuarzfrequenz,
            this.lblBottomQuarzfrequenz,
            this.lblBottomC});
            this.statusStrip1.Location = new System.Drawing.Point(0, 984);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1914, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBottomValueQuarzfrequenz
            // 
            this.lblBottomValueQuarzfrequenz.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBottomValueQuarzfrequenz.Name = "lblBottomValueQuarzfrequenz";
            this.lblBottomValueQuarzfrequenz.Size = new System.Drawing.Size(92, 24);
            this.lblBottomValueQuarzfrequenz.Text = "Value Quarz";
            // 
            // lblBottomQuarzfrequenz
            // 
            this.lblBottomQuarzfrequenz.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBottomQuarzfrequenz.Name = "lblBottomQuarzfrequenz";
            this.lblBottomQuarzfrequenz.Size = new System.Drawing.Size(110, 24);
            this.lblBottomQuarzfrequenz.Text = "Quarzfrequenz";
            // 
            // lblBottomC
            // 
            this.lblBottomC.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBottomC.Name = "lblBottomC";
            this.lblBottomC.Size = new System.Drawing.Size(206, 24);
            this.lblBottomC.Text = "© by Stiiift inc. - PaulG ChrisT";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvRam0
            // 
            this.dgvRam0.AllowUserToAddRows = false;
            this.dgvRam0.AllowUserToDeleteRows = false;
            this.dgvRam0.AllowUserToResizeColumns = false;
            this.dgvRam0.AllowUserToResizeRows = false;
            this.dgvRam0.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRam0.ColumnHeadersHeight = 50;
            this.dgvRam0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRam0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.StatusName,
            this.Bit0,
            this.Bit1,
            this.Bit2,
            this.Bit3,
            this.Bit4,
            this.Bit5,
            this.Bit6,
            this.Bit7});
            this.dgvRam0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRam0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRam0.Location = new System.Drawing.Point(3, 2);
            this.dgvRam0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRam0.MultiSelect = false;
            this.dgvRam0.Name = "dgvRam0";
            this.dgvRam0.ReadOnly = true;
            this.dgvRam0.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRam0.RowTemplate.DefaultCellStyle.Format = "N0";
            this.dgvRam0.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvRam0.RowTemplate.Height = 50;
            this.dgvRam0.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRam0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRam0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRam0.Size = new System.Drawing.Size(609, 460);
            this.dgvRam0.TabIndex = 9;
            this.dgvRam0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRam0_CellClick);
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Address.DefaultCellStyle = dataGridViewCellStyle1;
            this.Address.Frozen = true;
            this.Address.HeaderText = "ADDR";
            this.Address.MinimumWidth = 80;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.ToolTipText = "Memory Address";
            this.Address.Width = 80;
            // 
            // StatusName
            // 
            this.StatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatusName.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatusName.Frozen = true;
            this.StatusName.HeaderText = "Name";
            this.StatusName.MinimumWidth = 80;
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            this.StatusName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatusName.ToolTipText = "Status Name";
            this.StatusName.Width = 80;
            // 
            // Bit0
            // 
            this.Bit0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit0.DefaultCellStyle = dataGridViewCellStyle3;
            this.Bit0.HeaderText = "Bit0";
            this.Bit0.MinimumWidth = 30;
            this.Bit0.Name = "Bit0";
            this.Bit0.ReadOnly = true;
            this.Bit0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit0.ToolTipText = "MsB Bit0";
            this.Bit0.Width = 30;
            // 
            // Bit1
            // 
            this.Bit1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Bit1.HeaderText = "Bit1";
            this.Bit1.MinimumWidth = 30;
            this.Bit1.Name = "Bit1";
            this.Bit1.ReadOnly = true;
            this.Bit1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit1.ToolTipText = "MsB Bit1";
            this.Bit1.Width = 30;
            // 
            // Bit2
            // 
            this.Bit2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Bit2.HeaderText = "Bit2";
            this.Bit2.MinimumWidth = 30;
            this.Bit2.Name = "Bit2";
            this.Bit2.ReadOnly = true;
            this.Bit2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit2.ToolTipText = "MsB Bit2";
            this.Bit2.Width = 30;
            // 
            // Bit3
            // 
            this.Bit3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Bit3.HeaderText = "Bit3";
            this.Bit3.MinimumWidth = 30;
            this.Bit3.Name = "Bit3";
            this.Bit3.ReadOnly = true;
            this.Bit3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit3.ToolTipText = "MsB Bit3";
            this.Bit3.Width = 30;
            // 
            // Bit4
            // 
            this.Bit4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Bit4.HeaderText = "Bit4";
            this.Bit4.MinimumWidth = 30;
            this.Bit4.Name = "Bit4";
            this.Bit4.ReadOnly = true;
            this.Bit4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit4.ToolTipText = "MsB Bit4";
            this.Bit4.Width = 30;
            // 
            // Bit5
            // 
            this.Bit5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit5.DefaultCellStyle = dataGridViewCellStyle8;
            this.Bit5.HeaderText = "Bit5";
            this.Bit5.MinimumWidth = 30;
            this.Bit5.Name = "Bit5";
            this.Bit5.ReadOnly = true;
            this.Bit5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit5.ToolTipText = "MsB Bit5";
            this.Bit5.Width = 30;
            // 
            // Bit6
            // 
            this.Bit6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Bit6.HeaderText = "Bit6";
            this.Bit6.MinimumWidth = 30;
            this.Bit6.Name = "Bit6";
            this.Bit6.ReadOnly = true;
            this.Bit6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit6.ToolTipText = "MsB Bit6";
            this.Bit6.Width = 30;
            // 
            // Bit7
            // 
            this.Bit7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Bit7.DefaultCellStyle = dataGridViewCellStyle10;
            this.Bit7.HeaderText = "Bit7";
            this.Bit7.MinimumWidth = 30;
            this.Bit7.Name = "Bit7";
            this.Bit7.ReadOnly = true;
            this.Bit7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bit7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bit7.ToolTipText = "MsB Bit7";
            this.Bit7.Width = 30;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(621, 63);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 59);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel2.Controls.Add(this.dgvRam0, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvRam1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(615, 929);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dgvRam1
            // 
            this.dgvRam1.AllowUserToAddRows = false;
            this.dgvRam1.AllowUserToDeleteRows = false;
            this.dgvRam1.AllowUserToResizeColumns = false;
            this.dgvRam1.AllowUserToResizeRows = false;
            this.dgvRam1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRam1.ColumnHeadersHeight = 20;
            this.dgvRam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRam1.ColumnHeadersVisible = false;
            this.dgvRam1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvRam1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRam1.Location = new System.Drawing.Point(3, 466);
            this.dgvRam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRam1.MultiSelect = false;
            this.dgvRam1.Name = "dgvRam1";
            this.dgvRam1.ReadOnly = true;
            this.dgvRam1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRam1.RowTemplate.DefaultCellStyle.Format = "N0";
            this.dgvRam1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvRam1.RowTemplate.Height = 50;
            this.dgvRam1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRam1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRam1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRam1.Size = new System.Drawing.Size(609, 461);
            this.dgvRam1.TabIndex = 10;
            this.dgvRam1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRam1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ADDR";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Memory Address";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Status Name";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn3.HeaderText = "Bit0";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.ToolTipText = "MsB Bit0";
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn4.HeaderText = "Bit1";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.ToolTipText = "MsB Bit1";
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn5.HeaderText = "Bit2";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.ToolTipText = "MsB Bit2";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn6.HeaderText = "Bit3";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.ToolTipText = "MsB Bit3";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn7.HeaderText = "Bit4";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.ToolTipText = "MsB Bit4";
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn8.HeaderText = "Bit5";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.ToolTipText = "MsB Bit5";
            this.dataGridViewTextBoxColumn8.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn9.HeaderText = "Bit6";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.ToolTipText = "MsB Bit6";
            this.dataGridViewTextBoxColumn9.Width = 30;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn10.HeaderText = "Bit7";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.ToolTipText = "MsB Bit7";
            this.dataGridViewTextBoxColumn10.Width = 30;
            // 
            // lblWReg
            // 
            this.lblWReg.AutoSize = true;
            this.lblWReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWReg.Location = new System.Drawing.Point(73, 0);
            this.lblWReg.Name = "lblWReg";
            this.lblWReg.Size = new System.Drawing.Size(65, 25);
            this.lblWReg.TabIndex = 12;
            this.lblWReg.Text = "WREG";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPC.Location = new System.Drawing.Point(73, 25);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(65, 25);
            this.lblPC.TabIndex = 13;
            this.lblPC.Text = "PC";
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(749, 63);
            this.btnStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(125, 59);
            this.btnStep.TabIndex = 15;
            this.btnStep.Text = "STEP";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // tableLayoutStack
            // 
            this.tableLayoutStack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutStack.ColumnCount = 2;
            this.tableLayoutStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.25581F));
            this.tableLayoutStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.74419F));
            this.tableLayoutStack.Controls.Add(this.lblStackContent0, 1, 8);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr0, 0, 8);
            this.tableLayoutStack.Controls.Add(this.lblStackContent1, 1, 7);
            this.tableLayoutStack.Controls.Add(this.lblStackContent2, 1, 6);
            this.tableLayoutStack.Controls.Add(this.lblStackContent3, 1, 5);
            this.tableLayoutStack.Controls.Add(this.lblStackContent4, 1, 4);
            this.tableLayoutStack.Controls.Add(this.lblStackContent5, 1, 3);
            this.tableLayoutStack.Controls.Add(this.lblStackContent6, 1, 2);
            this.tableLayoutStack.Controls.Add(this.lblStackContent7, 1, 1);
            this.tableLayoutStack.Controls.Add(this.label4, 1, 0);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr, 0, 0);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr1, 0, 7);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr2, 0, 6);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr3, 0, 5);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr4, 0, 4);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr5, 0, 3);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr6, 0, 2);
            this.tableLayoutStack.Controls.Add(this.lblStackAddr7, 0, 1);
            this.tableLayoutStack.Location = new System.Drawing.Point(625, 805);
            this.tableLayoutStack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutStack.Name = "tableLayoutStack";
            this.tableLayoutStack.RowCount = 9;
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStack.Size = new System.Drawing.Size(328, 178);
            this.tableLayoutStack.TabIndex = 16;
            // 
            // lblStackContent0
            // 
            this.lblStackContent0.AutoSize = true;
            this.lblStackContent0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent0.Location = new System.Drawing.Point(144, 160);
            this.lblStackContent0.Name = "lblStackContent0";
            this.lblStackContent0.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent0.TabIndex = 17;
            // 
            // lblStackAddr0
            // 
            this.lblStackAddr0.AutoSize = true;
            this.lblStackAddr0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr0.Location = new System.Drawing.Point(3, 160);
            this.lblStackAddr0.Name = "lblStackAddr0";
            this.lblStackAddr0.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr0.TabIndex = 42;
            this.lblStackAddr0.Text = "0";
            // 
            // lblStackContent1
            // 
            this.lblStackContent1.AutoSize = true;
            this.lblStackContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent1.Location = new System.Drawing.Point(144, 140);
            this.lblStackContent1.Name = "lblStackContent1";
            this.lblStackContent1.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent1.TabIndex = 41;
            // 
            // lblStackContent2
            // 
            this.lblStackContent2.AutoSize = true;
            this.lblStackContent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent2.Location = new System.Drawing.Point(144, 120);
            this.lblStackContent2.Name = "lblStackContent2";
            this.lblStackContent2.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent2.TabIndex = 40;
            // 
            // lblStackContent3
            // 
            this.lblStackContent3.AutoSize = true;
            this.lblStackContent3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent3.Location = new System.Drawing.Point(144, 100);
            this.lblStackContent3.Name = "lblStackContent3";
            this.lblStackContent3.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent3.TabIndex = 39;
            // 
            // lblStackContent4
            // 
            this.lblStackContent4.AutoSize = true;
            this.lblStackContent4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent4.Location = new System.Drawing.Point(144, 80);
            this.lblStackContent4.Name = "lblStackContent4";
            this.lblStackContent4.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent4.TabIndex = 38;
            // 
            // lblStackContent5
            // 
            this.lblStackContent5.AutoSize = true;
            this.lblStackContent5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent5.Location = new System.Drawing.Point(144, 60);
            this.lblStackContent5.Name = "lblStackContent5";
            this.lblStackContent5.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent5.TabIndex = 37;
            // 
            // lblStackContent6
            // 
            this.lblStackContent6.AutoSize = true;
            this.lblStackContent6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent6.Location = new System.Drawing.Point(144, 40);
            this.lblStackContent6.Name = "lblStackContent6";
            this.lblStackContent6.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent6.TabIndex = 36;
            // 
            // lblStackContent7
            // 
            this.lblStackContent7.AutoSize = true;
            this.lblStackContent7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackContent7.Location = new System.Drawing.Point(144, 20);
            this.lblStackContent7.Name = "lblStackContent7";
            this.lblStackContent7.Size = new System.Drawing.Size(181, 20);
            this.lblStackContent7.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(144, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Inhalt";
            // 
            // lblStackAddr
            // 
            this.lblStackAddr.AutoSize = true;
            this.lblStackAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr.Location = new System.Drawing.Point(3, 0);
            this.lblStackAddr.Name = "lblStackAddr";
            this.lblStackAddr.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr.TabIndex = 33;
            this.lblStackAddr.Text = "Stack ADDR";
            // 
            // lblStackAddr1
            // 
            this.lblStackAddr1.AutoSize = true;
            this.lblStackAddr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr1.Location = new System.Drawing.Point(3, 140);
            this.lblStackAddr1.Name = "lblStackAddr1";
            this.lblStackAddr1.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr1.TabIndex = 32;
            this.lblStackAddr1.Text = "1";
            // 
            // lblStackAddr2
            // 
            this.lblStackAddr2.AutoSize = true;
            this.lblStackAddr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr2.Location = new System.Drawing.Point(3, 120);
            this.lblStackAddr2.Name = "lblStackAddr2";
            this.lblStackAddr2.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr2.TabIndex = 25;
            this.lblStackAddr2.Text = "2";
            // 
            // lblStackAddr3
            // 
            this.lblStackAddr3.AutoSize = true;
            this.lblStackAddr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr3.Location = new System.Drawing.Point(3, 100);
            this.lblStackAddr3.Name = "lblStackAddr3";
            this.lblStackAddr3.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr3.TabIndex = 23;
            this.lblStackAddr3.Text = "3";
            // 
            // lblStackAddr4
            // 
            this.lblStackAddr4.AutoSize = true;
            this.lblStackAddr4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr4.Location = new System.Drawing.Point(3, 80);
            this.lblStackAddr4.Name = "lblStackAddr4";
            this.lblStackAddr4.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr4.TabIndex = 21;
            this.lblStackAddr4.Text = "4";
            // 
            // lblStackAddr5
            // 
            this.lblStackAddr5.AutoSize = true;
            this.lblStackAddr5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr5.Location = new System.Drawing.Point(3, 60);
            this.lblStackAddr5.Name = "lblStackAddr5";
            this.lblStackAddr5.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr5.TabIndex = 19;
            this.lblStackAddr5.Text = "5";
            // 
            // lblStackAddr6
            // 
            this.lblStackAddr6.AutoSize = true;
            this.lblStackAddr6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr6.Location = new System.Drawing.Point(3, 40);
            this.lblStackAddr6.Name = "lblStackAddr6";
            this.lblStackAddr6.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr6.TabIndex = 17;
            this.lblStackAddr6.Text = "6";
            // 
            // lblStackAddr7
            // 
            this.lblStackAddr7.AutoSize = true;
            this.lblStackAddr7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStackAddr7.Location = new System.Drawing.Point(3, 20);
            this.lblStackAddr7.Name = "lblStackAddr7";
            this.lblStackAddr7.Size = new System.Drawing.Size(135, 20);
            this.lblStackAddr7.TabIndex = 15;
            this.lblStackAddr7.Text = "7";
            // 
            // tableLayoutSpezialregister
            // 
            this.tableLayoutSpezialregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutSpezialregister.ColumnCount = 2;
            this.tableLayoutSpezialregister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSpezialregister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSpezialregister.Controls.Add(this.lblPCTxt, 0, 1);
            this.tableLayoutSpezialregister.Controls.Add(this.lblWRegTxt, 0, 0);
            this.tableLayoutSpezialregister.Controls.Add(this.lblWReg, 1, 0);
            this.tableLayoutSpezialregister.Controls.Add(this.lblPC, 1, 1);
            this.tableLayoutSpezialregister.Location = new System.Drawing.Point(625, 749);
            this.tableLayoutSpezialregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutSpezialregister.Name = "tableLayoutSpezialregister";
            this.tableLayoutSpezialregister.RowCount = 2;
            this.tableLayoutSpezialregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSpezialregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSpezialregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutSpezialregister.Size = new System.Drawing.Size(141, 50);
            this.tableLayoutSpezialregister.TabIndex = 17;
            // 
            // lblPCTxt
            // 
            this.lblPCTxt.AutoSize = true;
            this.lblPCTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPCTxt.Location = new System.Drawing.Point(3, 25);
            this.lblPCTxt.Name = "lblPCTxt";
            this.lblPCTxt.Size = new System.Drawing.Size(64, 25);
            this.lblPCTxt.TabIndex = 15;
            this.lblPCTxt.Text = "PC";
            // 
            // lblWRegTxt
            // 
            this.lblWRegTxt.AutoSize = true;
            this.lblWRegTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWRegTxt.Location = new System.Drawing.Point(3, 0);
            this.lblWRegTxt.Name = "lblWRegTxt";
            this.lblWRegTxt.Size = new System.Drawing.Size(64, 25);
            this.lblWRegTxt.TabIndex = 14;
            this.lblWRegTxt.Text = "W-Reg";
            // 
            // btnStepBack
            // 
            this.btnStepBack.Location = new System.Drawing.Point(749, 153);
            this.btnStepBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(125, 59);
            this.btnStepBack.TabIndex = 18;
            this.btnStepBack.Text = "STEP BACK";
            this.btnStepBack.UseVisualStyleBackColor = true;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblLaufzeitzaehler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLaufzeitzaehler, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(769, 749);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 50);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lblLaufzeitzaehler
            // 
            this.lblLaufzeitzaehler.AutoSize = true;
            this.lblLaufzeitzaehler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLaufzeitzaehler.Location = new System.Drawing.Point(3, 25);
            this.lblLaufzeitzaehler.Name = "lblLaufzeitzaehler";
            this.lblLaufzeitzaehler.Size = new System.Drawing.Size(178, 25);
            this.lblLaufzeitzaehler.TabIndex = 15;
            // 
            // txtLaufzeitzaehler
            // 
            this.txtLaufzeitzaehler.AutoSize = true;
            this.txtLaufzeitzaehler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLaufzeitzaehler.Location = new System.Drawing.Point(3, 0);
            this.txtLaufzeitzaehler.Name = "txtLaufzeitzaehler";
            this.txtLaufzeitzaehler.Size = new System.Drawing.Size(178, 25);
            this.txtLaufzeitzaehler.TabIndex = 14;
            this.txtLaufzeitzaehler.Text = "Laufzeitzähler";
            // 
            // dgvCode
            // 
            this.dgvCode.AllowUserToAddRows = false;
            this.dgvCode.AllowUserToDeleteRows = false;
            this.dgvCode.AllowUserToResizeColumns = false;
            this.dgvCode.AllowUserToResizeRows = false;
            this.dgvCode.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCode.ColumnHeadersHeight = 40;
            this.dgvCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BreakPoint,
            this.PC,
            this.HexCode,
            this.LineCode});
            this.dgvCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCode.Location = new System.Drawing.Point(1150, 55);
            this.dgvCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCode.MultiSelect = false;
            this.dgvCode.Name = "dgvCode";
            this.dgvCode.ReadOnly = true;
            this.dgvCode.RowHeadersVisible = false;
            this.dgvCode.RowHeadersWidth = 20;
            this.dgvCode.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCode.RowTemplate.DefaultCellStyle.Format = "N0";
            this.dgvCode.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvCode.RowTemplate.Height = 20;
            this.dgvCode.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCode.Size = new System.Drawing.Size(764, 929);
            this.dgvCode.TabIndex = 20;
            this.dgvCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCode_CellClick);
            // 
            // BreakPoint
            // 
            this.BreakPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BreakPoint.Frozen = true;
            this.BreakPoint.HeaderText = "BP";
            this.BreakPoint.MinimumWidth = 30;
            this.BreakPoint.Name = "BreakPoint";
            this.BreakPoint.ReadOnly = true;
            this.BreakPoint.ToolTipText = "Check to set BreakPoint";
            this.BreakPoint.Width = 30;
            // 
            // PC
            // 
            this.PC.HeaderText = "PC";
            this.PC.MinimumWidth = 30;
            this.PC.Name = "PC";
            this.PC.ReadOnly = true;
            this.PC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PC.ToolTipText = "Program Counter";
            this.PC.Width = 50;
            // 
            // HexCode
            // 
            this.HexCode.HeaderText = "Hex";
            this.HexCode.MinimumWidth = 30;
            this.HexCode.Name = "HexCode";
            this.HexCode.ReadOnly = true;
            this.HexCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HexCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HexCode.ToolTipText = "HexCode";
            this.HexCode.Width = 50;
            // 
            // LineCode
            // 
            this.LineCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LineCode.HeaderText = "Code";
            this.LineCode.MinimumWidth = 400;
            this.LineCode.Name = "LineCode";
            this.LineCode.ReadOnly = true;
            this.LineCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LineCode.ToolTipText = "Executable code";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA7, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB7, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB6, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA6, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB5, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA5, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB4, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA4, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB3, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA3, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB1, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnPortB0, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPortB, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPortA, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPortA0, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(621, 437);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 307);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 35);
            this.label12.TabIndex = 28;
            this.label12.Text = "7";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortA7
            // 
            this.btnPortA7.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA7.Location = new System.Drawing.Point(41, 275);
            this.btnPortA7.Name = "btnPortA7";
            this.btnPortA7.Size = new System.Drawing.Size(56, 29);
            this.btnPortA7.TabIndex = 27;
            this.btnPortA7.UseVisualStyleBackColor = false;
            this.btnPortA7.Click += new System.EventHandler(this.btnPortA7_Click);
            // 
            // btnPortB7
            // 
            this.btnPortB7.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB7.Location = new System.Drawing.Point(103, 275);
            this.btnPortB7.Name = "btnPortB7";
            this.btnPortB7.Size = new System.Drawing.Size(57, 29);
            this.btnPortB7.TabIndex = 26;
            this.btnPortB7.UseVisualStyleBackColor = false;
            this.btnPortB7.Click += new System.EventHandler(this.btnPortB7_Click);
            // 
            // btnPortB6
            // 
            this.btnPortB6.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB6.Location = new System.Drawing.Point(103, 241);
            this.btnPortB6.Name = "btnPortB6";
            this.btnPortB6.Size = new System.Drawing.Size(57, 28);
            this.btnPortB6.TabIndex = 25;
            this.btnPortB6.UseVisualStyleBackColor = false;
            this.btnPortB6.Click += new System.EventHandler(this.btnPortB6_Click);
            // 
            // btnPortA6
            // 
            this.btnPortA6.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA6.Location = new System.Drawing.Point(41, 241);
            this.btnPortA6.Name = "btnPortA6";
            this.btnPortA6.Size = new System.Drawing.Size(56, 28);
            this.btnPortA6.TabIndex = 24;
            this.btnPortA6.UseVisualStyleBackColor = false;
            this.btnPortA6.Click += new System.EventHandler(this.btnPortA6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 34);
            this.label11.TabIndex = 23;
            this.label11.Text = "6";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortB5
            // 
            this.btnPortB5.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB5.Location = new System.Drawing.Point(103, 207);
            this.btnPortB5.Name = "btnPortB5";
            this.btnPortB5.Size = new System.Drawing.Size(57, 28);
            this.btnPortB5.TabIndex = 22;
            this.btnPortB5.UseVisualStyleBackColor = false;
            this.btnPortB5.Click += new System.EventHandler(this.btnPortB5_Click);
            // 
            // btnPortA5
            // 
            this.btnPortA5.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA5.Location = new System.Drawing.Point(41, 207);
            this.btnPortA5.Name = "btnPortA5";
            this.btnPortA5.Size = new System.Drawing.Size(56, 28);
            this.btnPortA5.TabIndex = 21;
            this.btnPortA5.UseVisualStyleBackColor = false;
            this.btnPortA5.Click += new System.EventHandler(this.btnPortA5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "5";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortB4
            // 
            this.btnPortB4.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB4.Location = new System.Drawing.Point(103, 173);
            this.btnPortB4.Name = "btnPortB4";
            this.btnPortB4.Size = new System.Drawing.Size(57, 28);
            this.btnPortB4.TabIndex = 19;
            this.btnPortB4.UseVisualStyleBackColor = false;
            this.btnPortB4.Click += new System.EventHandler(this.btnPortB4_Click);
            // 
            // btnPortA4
            // 
            this.btnPortA4.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA4.Location = new System.Drawing.Point(41, 173);
            this.btnPortA4.Name = "btnPortA4";
            this.btnPortA4.Size = new System.Drawing.Size(56, 28);
            this.btnPortA4.TabIndex = 18;
            this.btnPortA4.UseVisualStyleBackColor = false;
            this.btnPortA4.Click += new System.EventHandler(this.btnPortA4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 34);
            this.label9.TabIndex = 17;
            this.label9.Text = "4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortB3
            // 
            this.btnPortB3.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB3.Location = new System.Drawing.Point(103, 139);
            this.btnPortB3.Name = "btnPortB3";
            this.btnPortB3.Size = new System.Drawing.Size(57, 28);
            this.btnPortB3.TabIndex = 16;
            this.btnPortB3.UseVisualStyleBackColor = false;
            this.btnPortB3.Click += new System.EventHandler(this.btnPortB3_Click);
            // 
            // btnPortA3
            // 
            this.btnPortA3.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA3.Location = new System.Drawing.Point(41, 139);
            this.btnPortA3.Name = "btnPortA3";
            this.btnPortA3.Size = new System.Drawing.Size(56, 28);
            this.btnPortA3.TabIndex = 15;
            this.btnPortA3.UseVisualStyleBackColor = false;
            this.btnPortA3.Click += new System.EventHandler(this.btnPortA3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortB2
            // 
            this.btnPortB2.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB2.Location = new System.Drawing.Point(103, 105);
            this.btnPortB2.Name = "btnPortB2";
            this.btnPortB2.Size = new System.Drawing.Size(57, 28);
            this.btnPortB2.TabIndex = 13;
            this.btnPortB2.UseVisualStyleBackColor = false;
            this.btnPortB2.Click += new System.EventHandler(this.btnPortB2_Click);
            // 
            // btnPortA2
            // 
            this.btnPortA2.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA2.Location = new System.Drawing.Point(41, 105);
            this.btnPortA2.Name = "btnPortA2";
            this.btnPortA2.Size = new System.Drawing.Size(56, 28);
            this.btnPortA2.TabIndex = 12;
            this.btnPortA2.UseVisualStyleBackColor = false;
            this.btnPortA2.Click += new System.EventHandler(this.btnPortA2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortB1
            // 
            this.btnPortB1.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB1.Location = new System.Drawing.Point(103, 71);
            this.btnPortB1.Name = "btnPortB1";
            this.btnPortB1.Size = new System.Drawing.Size(57, 28);
            this.btnPortB1.TabIndex = 10;
            this.btnPortB1.UseVisualStyleBackColor = false;
            this.btnPortB1.Click += new System.EventHandler(this.btnPortB1_Click);
            // 
            // btnPortA1
            // 
            this.btnPortA1.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA1.Location = new System.Drawing.Point(41, 71);
            this.btnPortA1.Name = "btnPortA1";
            this.btnPortA1.Size = new System.Drawing.Size(56, 28);
            this.btnPortA1.TabIndex = 9;
            this.btnPortA1.UseVisualStyleBackColor = false;
            this.btnPortA1.Click += new System.EventHandler(this.btnPortA1_Click);
            // 
            // btnPortB0
            // 
            this.btnPortB0.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortB0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortB0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortB0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortB0.Location = new System.Drawing.Point(103, 37);
            this.btnPortB0.Name = "btnPortB0";
            this.btnPortB0.Size = new System.Drawing.Size(57, 28);
            this.btnPortB0.TabIndex = 8;
            this.btnPortB0.UseVisualStyleBackColor = false;
            this.btnPortB0.Click += new System.EventHandler(this.btnPortB0_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortB
            // 
            this.lblPortB.AutoSize = true;
            this.lblPortB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPortB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPortB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortB.Location = new System.Drawing.Point(103, 0);
            this.lblPortB.Name = "lblPortB";
            this.lblPortB.Size = new System.Drawing.Size(57, 34);
            this.lblPortB.TabIndex = 1;
            this.lblPortB.Text = "PortB";
            this.lblPortB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortA
            // 
            this.lblPortA.AutoSize = true;
            this.lblPortA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPortA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPortA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortA.Location = new System.Drawing.Point(41, 0);
            this.lblPortA.Name = "lblPortA";
            this.lblPortA.Size = new System.Drawing.Size(56, 34);
            this.lblPortA.TabIndex = 0;
            this.lblPortA.Text = "PortA";
            this.lblPortA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortA0
            // 
            this.btnPortA0.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortA0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortA0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPortA0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortA0.Location = new System.Drawing.Point(41, 37);
            this.btnPortA0.Name = "btnPortA0";
            this.btnPortA0.Size = new System.Drawing.Size(56, 28);
            this.btnPortA0.TabIndex = 2;
            this.btnPortA0.UseVisualStyleBackColor = false;
            this.btnPortA0.Click += new System.EventHandler(this.btnPortA0_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA7, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB7, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB6, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA6, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB5, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA5, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB4, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA4, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB3, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA3, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB2, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB1, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisB0, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTrisB, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTrisA, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnTrisA0, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(790, 437);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(163, 307);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "7";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisA7
            // 
            this.btnTrisA7.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA7.Location = new System.Drawing.Point(41, 275);
            this.btnTrisA7.Name = "btnTrisA7";
            this.btnTrisA7.Size = new System.Drawing.Size(56, 29);
            this.btnTrisA7.TabIndex = 27;
            this.btnTrisA7.UseVisualStyleBackColor = false;
            this.btnTrisA7.Click += new System.EventHandler(this.btnTrisA7_Click);
            // 
            // btnTrisB7
            // 
            this.btnTrisB7.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB7.Location = new System.Drawing.Point(103, 275);
            this.btnTrisB7.Name = "btnTrisB7";
            this.btnTrisB7.Size = new System.Drawing.Size(57, 29);
            this.btnTrisB7.TabIndex = 26;
            this.btnTrisB7.UseVisualStyleBackColor = false;
            this.btnTrisB7.Click += new System.EventHandler(this.btnTrisB7_Click);
            // 
            // btnTrisB6
            // 
            this.btnTrisB6.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB6.Location = new System.Drawing.Point(103, 241);
            this.btnTrisB6.Name = "btnTrisB6";
            this.btnTrisB6.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB6.TabIndex = 25;
            this.btnTrisB6.UseVisualStyleBackColor = false;
            this.btnTrisB6.Click += new System.EventHandler(this.btnTrisB6_Click);
            // 
            // btnTrisA6
            // 
            this.btnTrisA6.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA6.Location = new System.Drawing.Point(41, 241);
            this.btnTrisA6.Name = "btnTrisA6";
            this.btnTrisA6.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA6.TabIndex = 24;
            this.btnTrisA6.UseVisualStyleBackColor = false;
            this.btnTrisA6.Click += new System.EventHandler(this.btnTrisA6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "6";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisB5
            // 
            this.btnTrisB5.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB5.Location = new System.Drawing.Point(103, 207);
            this.btnTrisB5.Name = "btnTrisB5";
            this.btnTrisB5.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB5.TabIndex = 22;
            this.btnTrisB5.UseVisualStyleBackColor = false;
            this.btnTrisB5.Click += new System.EventHandler(this.btnTrisB5_Click);
            // 
            // btnTrisA5
            // 
            this.btnTrisA5.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA5.Location = new System.Drawing.Point(41, 207);
            this.btnTrisA5.Name = "btnTrisA5";
            this.btnTrisA5.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA5.TabIndex = 21;
            this.btnTrisA5.UseVisualStyleBackColor = false;
            this.btnTrisA5.Click += new System.EventHandler(this.btnTrisA5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 34);
            this.label13.TabIndex = 20;
            this.label13.Text = "5";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisB4
            // 
            this.btnTrisB4.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB4.Location = new System.Drawing.Point(103, 173);
            this.btnTrisB4.Name = "btnTrisB4";
            this.btnTrisB4.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB4.TabIndex = 19;
            this.btnTrisB4.UseVisualStyleBackColor = false;
            this.btnTrisB4.Click += new System.EventHandler(this.btnTrisB4_Click);
            // 
            // btnTrisA4
            // 
            this.btnTrisA4.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA4.Location = new System.Drawing.Point(41, 173);
            this.btnTrisA4.Name = "btnTrisA4";
            this.btnTrisA4.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA4.TabIndex = 18;
            this.btnTrisA4.UseVisualStyleBackColor = false;
            this.btnTrisA4.Click += new System.EventHandler(this.btnTrisA4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 34);
            this.label14.TabIndex = 17;
            this.label14.Text = "4";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisB3
            // 
            this.btnTrisB3.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB3.Location = new System.Drawing.Point(103, 139);
            this.btnTrisB3.Name = "btnTrisB3";
            this.btnTrisB3.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB3.TabIndex = 16;
            this.btnTrisB3.UseVisualStyleBackColor = false;
            this.btnTrisB3.Click += new System.EventHandler(this.btnTrisB3_Click);
            // 
            // btnTrisA3
            // 
            this.btnTrisA3.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA3.Location = new System.Drawing.Point(41, 139);
            this.btnTrisA3.Name = "btnTrisA3";
            this.btnTrisA3.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA3.TabIndex = 15;
            this.btnTrisA3.UseVisualStyleBackColor = false;
            this.btnTrisA3.Click += new System.EventHandler(this.btnTrisA3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 34);
            this.label15.TabIndex = 14;
            this.label15.Text = "3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisB2
            // 
            this.btnTrisB2.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB2.Location = new System.Drawing.Point(103, 105);
            this.btnTrisB2.Name = "btnTrisB2";
            this.btnTrisB2.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB2.TabIndex = 13;
            this.btnTrisB2.UseVisualStyleBackColor = false;
            this.btnTrisB2.Click += new System.EventHandler(this.btnTrisB2_Click);
            // 
            // btnTrisA2
            // 
            this.btnTrisA2.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA2.Location = new System.Drawing.Point(41, 105);
            this.btnTrisA2.Name = "btnTrisA2";
            this.btnTrisA2.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA2.TabIndex = 12;
            this.btnTrisA2.UseVisualStyleBackColor = false;
            this.btnTrisA2.Click += new System.EventHandler(this.btnTrisA2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 34);
            this.label16.TabIndex = 11;
            this.label16.Text = "2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisB1
            // 
            this.btnTrisB1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB1.Location = new System.Drawing.Point(103, 71);
            this.btnTrisB1.Name = "btnTrisB1";
            this.btnTrisB1.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB1.TabIndex = 10;
            this.btnTrisB1.UseVisualStyleBackColor = false;
            this.btnTrisB1.Click += new System.EventHandler(this.btnTrisB1_Click);
            // 
            // btnTrisA1
            // 
            this.btnTrisA1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA1.Location = new System.Drawing.Point(41, 71);
            this.btnTrisA1.Name = "btnTrisA1";
            this.btnTrisA1.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA1.TabIndex = 9;
            this.btnTrisA1.UseVisualStyleBackColor = false;
            this.btnTrisA1.Click += new System.EventHandler(this.btnTrisA1_Click);
            // 
            // btnTrisB0
            // 
            this.btnTrisB0.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisB0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisB0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisB0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisB0.Location = new System.Drawing.Point(103, 37);
            this.btnTrisB0.Name = "btnTrisB0";
            this.btnTrisB0.Size = new System.Drawing.Size(57, 28);
            this.btnTrisB0.TabIndex = 8;
            this.btnTrisB0.UseVisualStyleBackColor = false;
            this.btnTrisB0.Click += new System.EventHandler(this.btnTrisB0_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 34);
            this.label17.TabIndex = 7;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 34);
            this.label18.TabIndex = 5;
            this.label18.Text = "Bit";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrisB
            // 
            this.lblTrisB.AutoSize = true;
            this.lblTrisB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrisB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrisB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrisB.Location = new System.Drawing.Point(103, 0);
            this.lblTrisB.Name = "lblTrisB";
            this.lblTrisB.Size = new System.Drawing.Size(57, 34);
            this.lblTrisB.TabIndex = 1;
            this.lblTrisB.Text = "TrisB";
            this.lblTrisB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrisA
            // 
            this.lblTrisA.AutoSize = true;
            this.lblTrisA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrisA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrisA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrisA.Location = new System.Drawing.Point(41, 0);
            this.lblTrisA.Name = "lblTrisA";
            this.lblTrisA.Size = new System.Drawing.Size(56, 34);
            this.lblTrisA.TabIndex = 0;
            this.lblTrisA.Text = "TrisA";
            this.lblTrisA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrisA0
            // 
            this.btnTrisA0.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrisA0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrisA0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrisA0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrisA0.Location = new System.Drawing.Point(41, 37);
            this.btnTrisA0.Name = "btnTrisA0";
            this.btnTrisA0.Size = new System.Drawing.Size(56, 28);
            this.btnTrisA0.TabIndex = 2;
            this.btnTrisA0.UseVisualStyleBackColor = false;
            this.btnTrisA0.Click += new System.EventHandler(this.btnTrisA0_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(3, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 34);
            this.label21.TabIndex = 6;
            this.label21.Text = "0";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkStepBack
            // 
            this.checkStepBack.AutoSize = true;
            this.checkStepBack.BackColor = System.Drawing.Color.LimeGreen;
            this.checkStepBack.Checked = true;
            this.checkStepBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStepBack.Location = new System.Drawing.Point(742, 127);
            this.checkStepBack.Name = "checkStepBack";
            this.checkStepBack.Size = new System.Drawing.Size(145, 21);
            this.checkStepBack.TabIndex = 24;
            this.checkStepBack.Text = "StepBack enabled";
            this.checkStepBack.UseVisualStyleBackColor = false;
            this.checkStepBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkStepBack_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(956, 549);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(149, 432);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // btnSerialEinschalten
            // 
            this.btnSerialEinschalten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSerialEinschalten.Location = new System.Drawing.Point(959, 437);
            this.btnSerialEinschalten.Name = "btnSerialEinschalten";
            this.btnSerialEinschalten.Size = new System.Drawing.Size(146, 50);
            this.btnSerialEinschalten.TabIndex = 26;
            this.btnSerialEinschalten.Text = "Serial einschalten";
            this.btnSerialEinschalten.UseVisualStyleBackColor = true;
            this.btnSerialEinschalten.Click += new System.EventHandler(this.btnSerialEinschalten_Click);
            // 
            // btnSerialAusschalten
            // 
            this.btnSerialAusschalten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSerialAusschalten.Location = new System.Drawing.Point(959, 493);
            this.btnSerialAusschalten.Name = "btnSerialAusschalten";
            this.btnSerialAusschalten.Size = new System.Drawing.Size(146, 50);
            this.btnSerialAusschalten.TabIndex = 27;
            this.btnSerialAusschalten.Text = "Serial Ausschalten";
            this.btnSerialAusschalten.UseVisualStyleBackColor = true;
            this.btnSerialAusschalten.Click += new System.EventHandler(this.btnSerialAusschalten_Click);
            // 
            // backgroundWorkerSerialPort
            // 
            this.backgroundWorkerSerialPort.WorkerReportsProgress = true;
            this.backgroundWorkerSerialPort.WorkerSupportsCancellation = true;
            this.backgroundWorkerSerialPort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSerialPort_DoWork);
            this.backgroundWorkerSerialPort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSerialPort_ProgressChanged);
            this.backgroundWorkerSerialPort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSerialPort_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(893, 59);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 352);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(618, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(618, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // Herz
            // 
            this.Herz.Name = "Herz";
            this.Herz.Size = new System.Drawing.Size(27, 24);
            this.Herz.Text = "Hz";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PicSim.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1914, 1013);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSerialAusschalten);
            this.Controls.Add(this.btnSerialEinschalten);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkStepBack);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.tableLayoutSpezialregister);
            this.Controls.Add(this.tableLayoutStack);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PicSim - Stiiift Inc.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam0)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam1)).EndInit();
            this.tableLayoutStack.ResumeLayout(false);
            this.tableLayoutStack.PerformLayout();
            this.tableLayoutSpezialregister.ResumeLayout(false);
            this.tableLayoutSpezialregister.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblQuarzfrequenz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripLabel txtUnicorn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBottomQuarzfrequenz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolPlay;
        private System.Windows.Forms.ToolStripButton toolPause;
        private BindingSource form1BindingSource;
        private ToolStripStatusLabel lblBottomC;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn Bit0;
        private DataGridViewTextBoxColumn Bit1;
        private DataGridViewTextBoxColumn Bit2;
        private DataGridViewTextBoxColumn Bit3;
        private DataGridViewTextBoxColumn Bit4;
        private DataGridViewTextBoxColumn Bit5;
        private DataGridViewTextBoxColumn Bit6;
        private DataGridViewTextBoxColumn Bit7;
        private Button btnReset;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnStep;
        private TableLayoutPanel tableLayoutStack;
        private Label lblStackAddr0;
        private Label label4;
        private Label lblStackAddr;
        private Label lblStackAddr1;
        private Label lblStackAddr2;
        private Label lblStackAddr3;
        private Label lblStackAddr4;
        private Label lblStackAddr5;
        private Label lblStackAddr6;
        private Label lblStackAddr7;
        private TableLayoutPanel tableLayoutSpezialregister;
        private Label lblWRegTxt;
        private Button btnStepBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripButton toolStop;
        private TableLayoutPanel tableLayoutPanel1;
        private Label txtLaufzeitzaehler;
        private DataGridViewCheckBoxColumn BreakPoint;
        private DataGridViewTextBoxColumn PC;
        private DataGridViewTextBoxColumn HexCode;
        private DataGridViewTextBoxColumn LineCode;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblPortA;
        private Label lblPortB;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        public DataGridView dgvRam0;
        public DataGridView dgvRam1;
        public DataGridView dgvCode;
        public Label lblPC;
        public Label lblStackContent1;
        public Label lblStackContent2;
        public Label lblStackContent3;
        public Label lblStackContent4;
        public Label lblStackContent5;
        public Label lblStackContent6;
        public Label lblStackContent7;
        public Label lblStackContent0;
        public Label lblLaufzeitzaehler;
        public Label lblWReg;
        private Label lblPCTxt;
        public ToolStripTextBox txtQuarzfrequenz;
        public ToolStripStatusLabel lblBottomValueQuarzfrequenz;
        public ToolStripLabel toolStatus;
        public Button btnPortA0;
        public Button btnPortA7;
        public Button btnPortB7;
        public Button btnPortB6;
        public Button btnPortA6;
        public Button btnPortB5;
        public Button btnPortA5;
        public Button btnPortB4;
        public Button btnPortA4;
        public Button btnPortB3;
        public Button btnPortA3;
        public Button btnPortB2;
        public Button btnPortA2;
        public Button btnPortB1;
        public Button btnPortA1;
        public Button btnPortB0;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        public Button btnTrisA7;
        public Button btnTrisB7;
        public Button btnTrisB6;
        public Button btnTrisA6;
        private Label label2;
        public Button btnTrisB5;
        public Button btnTrisA5;
        private Label label13;
        public Button btnTrisB4;
        public Button btnTrisA4;
        private Label label14;
        public Button btnTrisB3;
        public Button btnTrisA3;
        private Label label15;
        public Button btnTrisB2;
        public Button btnTrisA2;
        private Label label16;
        public Button btnTrisB1;
        public Button btnTrisA1;
        public Button btnTrisB0;
        private Label label17;
        private Label label18;
        private Label lblTrisB;
        private Label lblTrisA;
        public Button btnTrisA0;
        private Label label21;
        private CheckBox checkStepBack;
        private RichTextBox richTextBox1;
        private Button btnSerialEinschalten;
        private Button btnSerialAusschalten;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSerialPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox pictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripLabel txtDisableUnicornMode;
        private ToolStripLabel txtChangeSong;
        private ToolStripLabel Herz;
    }
}

