namespace CpuScheduler
{
    partial class CpuSchedulerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpuSchedulerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnCpuScheduler = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDarkModeToggle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeTextBox = new System.Windows.Forms.RichTextBox();
            this.schedulerPanel = new System.Windows.Forms.Panel();
            this.processDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSetProcessCount = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cmbLoadExample = new System.Windows.Forms.ComboBox();
            this.algorithmButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.btnRoundRobin = new System.Windows.Forms.Button();
            this.restartApp = new System.Windows.Forms.Label();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnSJF = new System.Windows.Forms.Button();
            this.btnFCFS = new System.Windows.Forms.Button();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.schedulerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).BeginInit();
            this.algorithmButtonPanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnWelcome);
            this.panel1.Controls.Add(this.btnCpuScheduler);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnDarkModeToggle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.restartApp);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 600);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.SeaGreen;
            this.sidePanel.Location = new System.Drawing.Point(0, 161);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 45);
            this.sidePanel.TabIndex = 4;
            // 
            // 
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 90);
            this.label1.TabIndex = 3;
            this.label1.Text = "© 2025.\r\nFork: Chris Regan\r\nKSU CS 3502 OS Class\r\n(OwlTech Training Tools)\r\n\r\nOriginal: Francis Nweke";
            // 
            // btnCpuScheduler
            // 
            this.btnCpuScheduler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCpuScheduler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCpuScheduler.FlatAppearance.BorderSize = 0;
            this.btnCpuScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpuScheduler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpuScheduler.Image = ((System.Drawing.Image)(resources.GetObject("btnCpuScheduler.Image")));
            this.btnCpuScheduler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCpuScheduler.Location = new System.Drawing.Point(11, 180);
            this.btnCpuScheduler.Name = "btnCpuScheduler";
            this.btnCpuScheduler.Size = new System.Drawing.Size(150, 40);
            this.btnCpuScheduler.TabIndex = 2;
            this.btnCpuScheduler.Text = "    Scheduler";
            this.btnCpuScheduler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCpuScheduler.UseVisualStyleBackColor = true;
            this.btnCpuScheduler.Click += new System.EventHandler(this.CpuSchedulerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnWelcome
            // 
            this.btnWelcome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWelcome.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnWelcome.FlatAppearance.BorderSize = 0;
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcome.Location = new System.Drawing.Point(11, 135);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(150, 40);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "🏠   Welcome";
            this.btnWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWelcome.UseVisualStyleBackColor = false;
            this.btnWelcome.Click += new System.EventHandler(this.WelcomeButton_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(11, 225);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(150, 45);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "    Results";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(11, 270);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(150, 40);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "📚   About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // btnDarkModeToggle
            // 
            this.btnDarkModeToggle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDarkModeToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDarkModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkModeToggle.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDarkModeToggle.FlatAppearance.BorderSize = 0;
            this.btnDarkModeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkModeToggle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkModeToggle.Location = new System.Drawing.Point(11, 350);
            this.btnDarkModeToggle.Name = "btnDarkModeToggle";
            this.btnDarkModeToggle.Size = new System.Drawing.Size(150, 30);
            this.btnDarkModeToggle.TabIndex = 4;
            this.btnDarkModeToggle.Text = "☀️ Light Mode";
            this.btnDarkModeToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDarkModeToggle.UseVisualStyleBackColor = false;
            this.btnDarkModeToggle.Click += new System.EventHandler(this.DarkModeToggle_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.welcomePanel);
            this.contentPanel.Controls.Add(this.schedulerPanel);
            this.contentPanel.Controls.Add(this.resultsPanel);
            this.contentPanel.Controls.Add(this.aboutPanel);
            this.contentPanel.Location = new System.Drawing.Point(171, 1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(728, 600);
            this.contentPanel.TabIndex = 1;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.welcomePanel.Controls.Add(this.welcomeTextBox);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Padding = new System.Windows.Forms.Padding(10);
            this.welcomePanel.Size = new System.Drawing.Size(728, 600);
            this.welcomePanel.TabIndex = 0;
            this.welcomePanel.Visible = true;
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.welcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(15, 15);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.ReadOnly = true;
            this.welcomeTextBox.Size = new System.Drawing.Size(698, 570);
            this.welcomeTextBox.TabIndex = 0;
            this.welcomeTextBox.Text = "";
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.resultsPanel.Controls.Add(this.listView1);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.resultsPanel.Size = new System.Drawing.Size(728, 600);
            this.resultsPanel.TabIndex = 0;
            this.resultsPanel.Visible = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 570);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 
            // schedulerPanel
            // 
            this.schedulerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.schedulerPanel.Controls.Add(this.processDataGrid);
            this.schedulerPanel.Controls.Add(this.btnSetProcessCount);
            this.schedulerPanel.Controls.Add(this.btnGenerateRandom);
            this.schedulerPanel.Controls.Add(this.btnClearAll);
            this.schedulerPanel.Controls.Add(this.btnSaveData);
            this.schedulerPanel.Controls.Add(this.btnLoadData);
            this.schedulerPanel.Controls.Add(this.cmbLoadExample);
            this.schedulerPanel.Controls.Add(this.algorithmButtonPanel);
            this.schedulerPanel.Controls.Add(this.txtProcess);
            this.schedulerPanel.Controls.Add(this.labelProcess);
            this.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerPanel.Location = new System.Drawing.Point(0, 0);
            this.schedulerPanel.Name = "schedulerPanel";
            this.schedulerPanel.Padding = new System.Windows.Forms.Padding(10);
            this.schedulerPanel.Size = new System.Drawing.Size(728, 600);
            this.schedulerPanel.TabIndex = 1;
            this.schedulerPanel.Visible = false;
            // 
            // processDataGrid
            // 
            this.processDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDataGrid.Location = new System.Drawing.Point(20, 95);
            this.processDataGrid.Name = "processDataGrid";
            this.processDataGrid.Size = new System.Drawing.Size(450, 300);
            this.processDataGrid.TabIndex = 20;
            this.processDataGrid.Visible = true;
            // 
            // btnSetProcessCount
            // 
            this.btnSetProcessCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetProcessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProcessCount.Location = new System.Drawing.Point(330, 55);
            this.btnSetProcessCount.Name = "btnSetProcessCount";
            this.btnSetProcessCount.Size = new System.Drawing.Size(140, 30);
            this.btnSetProcessCount.TabIndex = 21;
            this.btnSetProcessCount.Text = "Set Process Count";
            this.btnSetProcessCount.UseVisualStyleBackColor = true;
            this.btnSetProcessCount.Click += new System.EventHandler(this.SetProcessCount_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRandom.Location = new System.Drawing.Point(490, 95);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(120, 30);
            this.btnGenerateRandom.TabIndex = 22;
            this.btnGenerateRandom.Text = "Generate Random";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Visible = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.GenerateRandom_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(490, 135);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(120, 30);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Visible = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // cmbLoadExample
            // 
            this.cmbLoadExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoadExample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoadExample.FormattingEnabled = true;
            this.cmbLoadExample.Items.AddRange(new object[] {
            "Load Example...",
            "Short Processes (1-5)",
            "Mixed Load (1-20)",
            "Heavy Load (10-30)",
            "Priority Demo"});
            this.cmbLoadExample.Location = new System.Drawing.Point(490, 175);
            this.cmbLoadExample.Name = "cmbLoadExample";
            this.cmbLoadExample.Size = new System.Drawing.Size(120, 23);
            this.cmbLoadExample.TabIndex = 24;
            this.cmbLoadExample.Visible = true;
            this.cmbLoadExample.SelectedIndexChanged += new System.EventHandler(this.LoadExample_SelectedIndexChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(490, 210);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(120, 30);
            this.btnSaveData.TabIndex = 25;
            this.btnSaveData.Text = "💾 Save as CSV";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Visible = true;
            this.btnSaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(490, 250);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 30);
            this.btnLoadData.TabIndex = 26;
            this.btnLoadData.Text = "📂 Load CSV";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Visible = true;
            this.btnLoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // algorithmButtonPanel
            // 
            // STUDENTS: This FlowLayoutPanel automatically arranges algorithm buttons
            // To add your own scheduling algorithm:
            // 1. Create a new Button in the designer (similar to btnFCFS, btnSJF, etc.)
            // 2. Set the button Size to (140, 50) and Margin to (10, 5, 10, 5)
            // 3. Add it to this FlowLayoutPanel using: this.algorithmButtonPanel.Controls.Add(yourNewButton);
            // 4. The FlowLayoutPanel will automatically position it and handle wrapping
            this.algorithmButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmButtonPanel.Controls.Add(this.btnFCFS);
            this.algorithmButtonPanel.Controls.Add(this.btnSJF);
            this.algorithmButtonPanel.Controls.Add(this.btnPriority);
            this.algorithmButtonPanel.Controls.Add(this.btnRoundRobin);
            this.algorithmButtonPanel.Controls.Add(this.btnSRTF);
            this.algorithmButtonPanel.Controls.Add(this.btnLottery);
            this.algorithmButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.algorithmButtonPanel.Location = new System.Drawing.Point(20, 450);
            this.algorithmButtonPanel.Name = "algorithmButtonPanel";
            this.algorithmButtonPanel.Size = new System.Drawing.Size(690, 120);
            this.algorithmButtonPanel.TabIndex = 25;
            this.algorithmButtonPanel.WrapContents = true;
            // 
            // btnRoundRobin
            // 
            this.btnRoundRobin.Enabled = true;
            this.btnRoundRobin.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRoundRobin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoundRobin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRoundRobin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoundRobin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundRobin.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnRoundRobin.Name = "btnRoundRobin";
            this.btnRoundRobin.Size = new System.Drawing.Size(140, 50);
            this.btnRoundRobin.TabIndex = 12;
            this.btnRoundRobin.Text = "ROUND ROBIN";
            this.btnRoundRobin.UseVisualStyleBackColor = false;
            this.btnRoundRobin.Click += new System.EventHandler(this.RoundRobinButton_Click);
            // 
            // restartApp
            // 
            this.restartApp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.restartApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartApp.ForeColor = System.Drawing.Color.DarkBlue;
            this.restartApp.Location = new System.Drawing.Point(11, 315);
            this.restartApp.Name = "restartApp";
            this.restartApp.Size = new System.Drawing.Size(150, 30);
            this.restartApp.TabIndex = 11;
            this.restartApp.Text = "🔄 Restart Application";
            this.restartApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartApp.Click += new System.EventHandler(this.RestartApp_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Enabled = true;
            this.btnPriority.BackColor = System.Drawing.Color.Bisque;
            this.btnPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriority.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(140, 50);
            this.btnPriority.TabIndex = 10;
            this.btnPriority.Text = "PRIORITY";
            this.btnPriority.UseVisualStyleBackColor = false;
            this.btnPriority.Click += new System.EventHandler(this.PriorityButton_Click);
            // 
            // btnSJF
            // 
            this.btnSJF.Enabled = true;
            this.btnSJF.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSJF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSJF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnSJF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSJF.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSJF.Name = "btnSJF";
            this.btnSJF.Size = new System.Drawing.Size(140, 50);
            this.btnSJF.TabIndex = 9;
            this.btnSJF.Text = "SJF";
            this.btnSJF.UseVisualStyleBackColor = false;
            this.btnSJF.Click += new System.EventHandler(this.ShortestJobFirstButton_Click);
            // 
            // btnFCFS
            // 
            this.btnFCFS.Enabled = true;
            this.btnFCFS.BackColor = System.Drawing.Color.Beige;
            this.btnFCFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFCFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(140, 50);
            this.btnFCFS.TabIndex = 8;
            this.btnFCFS.Text = "FCFS";
            this.btnFCFS.UseVisualStyleBackColor = false;
            this.btnFCFS.Click += new System.EventHandler(this.FirstComeFirstServeButton_Click);
            //
            // btnSRTF
            //
            this.btnSRTF = new System.Windows.Forms.Button();
            this.btnSRTF.Enabled = true;
            this.btnSRTF.BackColor = System.Drawing.Color.LightCoral;
            this.btnSRTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSRTF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnSRTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRTF.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSRTF.Name = "btnSRTF";
            this.btnSRTF.Size = new System.Drawing.Size(140, 50);
            this.btnSRTF.TabIndex = 13; // Use a new tab index
            this.btnSRTF.Text = "SRTF";
            this.btnSRTF.UseVisualStyleBackColor = false;
            this.btnSRTF.Click += new System.EventHandler(this.SRTFButton_Click);
            //
            // btnLottery
            //
            this.btnLottery = new System.Windows.Forms.Button();
            this.btnLottery.Enabled = true;
            this.btnLottery.BackColor = System.Drawing.Color.Gold;
            this.btnLottery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLottery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLottery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLottery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLottery.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(140, 50);
            this.btnLottery.TabIndex = 14; // Use a new tab index
            this.btnLottery.Text = "LOTTERY";
            this.btnLottery.UseVisualStyleBackColor = false;
            this.btnLottery.Click += new System.EventHandler(this.LotteryButton_Click);
            // 
            // txtProcess
            // 
            this.txtProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcess.Location = new System.Drawing.Point(200, 55);
            this.txtProcess.Text = "3";
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(120, 26);
            this.txtProcess.TabIndex = 7;
            this.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProcess.TextChanged += new System.EventHandler(this.ProcessTextBox_TextChanged);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcess.Location = new System.Drawing.Point(180, 30);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(160, 17);
            this.labelProcess.TabIndex = 6;
            this.labelProcess.Text = "Number of Processes:";
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.aboutPanel.Controls.Add(this.aboutTextBox);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.aboutPanel.Size = new System.Drawing.Size(728, 600);
            this.aboutPanel.TabIndex = 2;
            this.aboutPanel.Visible = false;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(15, 15);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(698, 570);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.Text = "";
            // 
            // timer1
            //
            // 
            // CpuSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CpuSchedulerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CpuSchedulerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).EndInit();
            this.algorithmButtonPanel.ResumeLayout(false);
            this.schedulerPanel.ResumeLayout(false);
            this.schedulerPanel.PerformLayout();
            this.resultsPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnCpuScheduler;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnDarkModeToggle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.RichTextBox welcomeTextBox;
        private System.Windows.Forms.Panel schedulerPanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label restartApp;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnSJF;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.Button btnSRTF;
        private System.Windows.Forms.Button btnLottery;
        public System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnRoundRobin;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.DataGridView processDataGrid;
        private System.Windows.Forms.Button btnSetProcessCount;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox cmbLoadExample;
        private System.Windows.Forms.FlowLayoutPanel algorithmButtonPanel;
        private System.Windows.Forms.Timer timer1;
    }
}