﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Calc
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void learnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
