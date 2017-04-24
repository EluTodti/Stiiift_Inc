using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.lblQuarzfrequenz = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.quarzfrequenzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUnicorn = new System.Windows.Forms.ToolStripLabel();
            this.toolPlay = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBottomValueQuarzfrequenz = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBottomQuarzfrequenz = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBottomC = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvRam = new System.Windows.Forms.DataGridView();
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
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 181);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.lblQuarzfrequenz,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.txtUnicorn,
            this.toolPlay,
            this.toolPause,
            this.toolStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2625, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 42);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(209, 45);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(172, 45);
            // 
            // lblQuarzfrequenz
            // 
            this.lblQuarzfrequenz.Name = "lblQuarzfrequenz";
            this.lblQuarzfrequenz.Size = new System.Drawing.Size(190, 42);
            this.lblQuarzfrequenz.Text = "Quarzfrequenz";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quarzfrequenzToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(50, 42);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // quarzfrequenzToolStripMenuItem
            // 
            this.quarzfrequenzToolStripMenuItem.Name = "quarzfrequenzToolStripMenuItem";
            this.quarzfrequenzToolStripMenuItem.Size = new System.Drawing.Size(215, 42);
            this.quarzfrequenzToolStripMenuItem.Text = "100000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // txtUnicorn
            // 
            this.txtUnicorn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUnicorn.Name = "txtUnicorn";
            this.txtUnicorn.Size = new System.Drawing.Size(189, 42);
            this.txtUnicorn.Text = "Unicorn magic";
            this.txtUnicorn.Click += new System.EventHandler(this.txtUnicorn_Click);
            // 
            // toolPlay
            // 
            this.toolPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPlay.Image = global::PicSim.Properties.Resources.Play;
            this.toolPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPlay.Name = "toolPlay";
            this.toolPlay.Size = new System.Drawing.Size(24, 42);
            this.toolPlay.Text = "Play";
            this.toolPlay.Click += new System.EventHandler(this.toolPlay_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPause.Image = global::PicSim.Properties.Resources.Pause;
            this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPause.Name = "toolPause";
            this.toolPause.Size = new System.Drawing.Size(24, 42);
            this.toolPause.Text = "Pause";
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Image = global::PicSim.Properties.Resources.Stop;
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(24, 42);
            this.toolStop.Text = "Stop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2625, 49);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(70, 41);
            this.toolFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 42);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolHelp.BackColor = System.Drawing.SystemColors.Control;
            this.toolHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(85, 41);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 1000);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 24, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2625, 46);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBottomValueQuarzfrequenz
            // 
            this.lblBottomValueQuarzfrequenz.Name = "lblBottomValueQuarzfrequenz";
            this.lblBottomValueQuarzfrequenz.Size = new System.Drawing.Size(159, 41);
            this.lblBottomValueQuarzfrequenz.Text = "Value Quarz";
            // 
            // lblBottomQuarzfrequenz
            // 
            this.lblBottomQuarzfrequenz.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBottomQuarzfrequenz.Name = "lblBottomQuarzfrequenz";
            this.lblBottomQuarzfrequenz.Size = new System.Drawing.Size(180, 41);
            this.lblBottomQuarzfrequenz.Text = "Qurzfrequenz";
            // 
            // lblBottomC
            // 
            this.lblBottomC.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBottomC.Name = "lblBottomC";
            this.lblBottomC.Size = new System.Drawing.Size(369, 41);
            this.lblBottomC.Text = "© by Stiiift inc. - PaulG ChrisT";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxCode.Location = new System.Drawing.Point(1559, 94);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCode.Size = new System.Drawing.Size(1066, 906);
            this.textBoxCode.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvRam
            // 
            this.dgvRam.AllowUserToAddRows = false;
            this.dgvRam.AllowUserToDeleteRows = false;
            this.dgvRam.AllowUserToResizeColumns = false;
            this.dgvRam.AllowUserToResizeRows = false;
            this.dgvRam.ColumnHeadersHeight = 50;
            this.dgvRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvRam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRam.Location = new System.Drawing.Point(0, 114);
            this.dgvRam.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRam.MultiSelect = false;
            this.dgvRam.Name = "dgvRam";
            this.dgvRam.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRam.RowTemplate.DefaultCellStyle.Format = "N0";
            this.dgvRam.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvRam.RowTemplate.Height = 50;
            this.dgvRam.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRam.Size = new System.Drawing.Size(1076, 906);
            this.dgvRam.TabIndex = 9;
            this.dgvRam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRam_CellClick);
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
            this.btnReset.Location = new System.Drawing.Point(1213, 352);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 107);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PicSim.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2625, 1046);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvRam);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "PicSim - Stiiift Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel lblQuarzfrequenz;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem quarzfrequenzToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripLabel txtUnicorn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBottomValueQuarzfrequenz;
        private System.Windows.Forms.ToolStripStatusLabel lblBottomQuarzfrequenz;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStop;
        private System.Windows.Forms.ToolStripButton toolPlay;
        private System.Windows.Forms.ToolStripButton toolPause;
        private DataGridView dgvRam;
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
    }
}

