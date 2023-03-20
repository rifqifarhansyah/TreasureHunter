using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using TreasureHunterAlgo;

namespace TreasureHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#242629");

            listView1.BackColor = System.Drawing.ColorTranslator.FromHtml("#242629");
            listView2.BackColor = System.Drawing.ColorTranslator.FromHtml("#242629");
            listView4.BackColor = System.Drawing.ColorTranslator.FromHtml("#242629");

            FileName.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");
            FileName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A1B2");

            StartingFolder.BackColor = System.Drawing.ColorTranslator.FromHtml("#242629");
            StartingFolder.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7F5AF0");

            label10.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");

            SearchFile.BackColor = System.Drawing.ColorTranslator.FromHtml("#7F5AF0");
            Visualize.BackColor = System.Drawing.ColorTranslator.FromHtml("#7F5AF0");

            listView1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#010101");
            listView2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#010101");

            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#7F5AF0");

            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");
            panel5.BackColor = System.Drawing.ColorTranslator.FromHtml("#16161A");
            placeholder.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A1B2");

            label7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A1B2");
        }
        private void FileName_GotFocus(object sender, EventArgs e)
        {
            if (FileName.Text == "Your text here")
            {
                FileName.Text = "";
                FileName.ForeColor = System.Drawing.Color.White;
            }
        }

        private void FileName_LostFocus(object sender, EventArgs e)
        {
            if (FileName.Text == "")
            {
                FileName.Text = "Your text here";
                FileName.ForeColor = System.Drawing.Color.LightGray;
            }
        }
        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void chooseStartingFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void searchFile_Click(object sender, EventArgs e)
        {
            string path = filePath.Text + "\\" + FileName.Text;
            if (File.Exists(path))
            {
                label8.Text = "File loaded";
            } 
            else
            {
                label8.Text = "File not found";
            }
        }
        private void visualize_Click(object sender, EventArgs e)
        {
            if (!this.BFS.Checked && !this.DFS.Checked)
            {
                this.placeholder.Text = "Please choose an algorithm to implement!";
            }
            else if (this.BFS.Checked)
            {
                this.placeholder.Text = "";
                string path = filePath.Text + "\\" + FileName.Text;
                Maze m = new Maze(path);
                dataGridView1.ColumnCount = m.Length;
                dataGridView1.RowCount = m.Width;
                dataGridView1.
            }
            else
            {

            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Click(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
