namespace TreasureHunter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StartingFolder = new System.Windows.Forms.Button();
            this.SearchFile = new System.Windows.Forms.Button();
            this.Visualize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BFS = new System.Windows.Forms.RadioButton();
            this.DFS = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placeholder = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.curTime = new System.Windows.Forms.Label();
            this.curNodes = new System.Windows.Forms.Label();
            this.curSteps = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(769, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TREASURE HUNT";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(500, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input";
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-27, 108);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 705);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // StartingFolder
            // 
            this.StartingFolder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartingFolder.FlatAppearance.BorderSize = 3;
            this.StartingFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartingFolder.Location = new System.Drawing.Point(76, 351);
            this.StartingFolder.Margin = new System.Windows.Forms.Padding(4);
            this.StartingFolder.Name = "StartingFolder";
            this.StartingFolder.Size = new System.Drawing.Size(287, 59);
            this.StartingFolder.TabIndex = 5;
            this.StartingFolder.Text = "Choose Folder";
            this.StartingFolder.UseVisualStyleBackColor = false;
            this.StartingFolder.Click += new System.EventHandler(this.chooseStartingFolder_Click);
            // 
            // SearchFile
            // 
            this.SearchFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchFile.FlatAppearance.BorderSize = 0;
            this.SearchFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SearchFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchFile.Location = new System.Drawing.Point(77, 640);
            this.SearchFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchFile.Name = "SearchFile";
            this.SearchFile.Size = new System.Drawing.Size(295, 69);
            this.SearchFile.TabIndex = 7;
            this.SearchFile.Text = "Search";
            this.SearchFile.UseVisualStyleBackColor = false;
            this.SearchFile.Click += new System.EventHandler(this.searchFile_Click);
            // 
            // Visualize
            // 
            this.Visualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Visualize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Visualize.FlatAppearance.BorderSize = 0;
            this.Visualize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.Visualize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.Visualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Visualize.Location = new System.Drawing.Point(740, 714);
            this.Visualize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Visualize.Name = "Visualize";
            this.Visualize.Size = new System.Drawing.Size(295, 69);
            this.Visualize.TabIndex = 32;
            this.Visualize.Text = "Visualize";
            this.Visualize.UseVisualStyleBackColor = false;
            this.Visualize.Click += new System.EventHandler(this.visualize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input File Name";
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.Black;
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.Color.LightGray;
            this.FileName.Location = new System.Drawing.Point(76, 249);
            this.FileName.Margin = new System.Windows.Forms.Padding(0);
            this.FileName.Multiline = true;
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(259, 34);
            this.FileName.TabIndex = 9;
            this.FileName.Text = "Your text here";
            this.FileName.TextChanged += new System.EventHandler(this.label_Click);
            this.FileName.GotFocus += new System.EventHandler(this.FileName_GotFocus);
            this.FileName.LostFocus += new System.EventHandler(this.FileName_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(72, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Starting Directory/Folder";
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(71, 528);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Algorithm";
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // BFS
            // 
            this.BFS.AutoSize = true;
            this.BFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BFS.Cursor = System.Windows.Forms.Cursors.Default;
            this.BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.BFS.Location = new System.Drawing.Point(76, 559);
            this.BFS.Margin = new System.Windows.Forms.Padding(4);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(67, 28);
            this.BFS.TabIndex = 12;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.CheckedChanged += new System.EventHandler(this.label_Click);
            // 
            // DFS
            // 
            this.DFS.AutoSize = true;
            this.DFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.DFS.Location = new System.Drawing.Point(76, 586);
            this.DFS.Margin = new System.Windows.Forms.Padding(4);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(68, 28);
            this.DFS.TabIndex = 13;
            this.DFS.TabStop = true;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.CheckedChanged += new System.EventHandler(this.label_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(836, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Your favorite Maze Problem Solver";
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(72, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "No File Chosen";
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1395, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Route:";
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1395, 689);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nodes:";
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1395, 720);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Steps:";
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.filePath.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filePath.Location = new System.Drawing.Point(647, 191);
            this.filePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 26);
            this.filePath.TabIndex = 18;
            this.filePath.Click += new System.EventHandler(this.label_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1395, 754);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(151, 25);
            this.time.TabIndex = 19;
            this.time.Text = "Elapsed Time:";
            this.time.Click += new System.EventHandler(this.label_Click);
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elapsedTime.Location = new System.Drawing.Point(695, 640);
            this.elapsedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(0, 26);
            this.elapsedTime.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.placeholder);
            this.panel1.Location = new System.Drawing.Point(500, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 492);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.label_Click);
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.placeholder.Location = new System.Drawing.Point(173, 235);
            this.placeholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(464, 46);
            this.placeholder.TabIndex = 27;
            this.placeholder.Text = "Path will be shown here";
            this.placeholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.placeholder.Click += new System.EventHandler(this.label_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(451, 108);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1427, 705);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.label_Click);
            // 
            // curTime
            // 
            this.curTime.AutoSize = true;
            this.curTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.curTime.Location = new System.Drawing.Point(1571, 754);
            this.curTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(20, 25);
            this.curTime.TabIndex = 24;
            this.curTime.Text = "-";
            this.curTime.Click += new System.EventHandler(this.label_Click);
            // 
            // curNodes
            // 
            this.curNodes.AutoSize = true;
            this.curNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curNodes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.curNodes.Location = new System.Drawing.Point(1500, 689);
            this.curNodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curNodes.Name = "curNodes";
            this.curNodes.Size = new System.Drawing.Size(20, 25);
            this.curNodes.TabIndex = 24;
            this.curNodes.Text = "-";
            this.curNodes.Click += new System.EventHandler(this.label_Click);
            // 
            // curSteps
            // 
            this.curSteps.AutoSize = true;
            this.curSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curSteps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.curSteps.Location = new System.Drawing.Point(1500, 720);
            this.curSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curSteps.Name = "curSteps";
            this.curSteps.Size = new System.Drawing.Size(20, 25);
            this.curSteps.TabIndex = 24;
            this.curSteps.Text = "-";
            this.curSteps.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(760, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "All rights reserved @ dicarryVieridanZaki 2023";
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-27, -41);
            this.listView4.Margin = new System.Windows.Forms.Padding(4);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1904, 154);
            this.listView4.TabIndex = 27;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(493, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 505);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1880, 4);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(453, 108);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 693);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(-1, 801);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1881, 69);
            this.panel5.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "Maze Grids";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 492);
            this.dataGridView1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1857, 863);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.curTime);
            this.Controls.Add(this.curNodes);
            this.Controls.Add(this.curSteps);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.time);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchFile);
            this.Controls.Add(this.Visualize);
            this.Controls.Add(this.StartingFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView4);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treasure Hunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button StartingFolder;
        private System.Windows.Forms.Button SearchFile;
        private System.Windows.Forms.Button Visualize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton BFS;
        private System.Windows.Forms.RadioButton DFS;
        public System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Label curNodes;
        private System.Windows.Forms.Label curSteps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

