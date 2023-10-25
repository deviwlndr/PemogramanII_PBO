﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_2_714220054
{
    public partial class ChildForm : Form
    {
        private string outputText = ""; // Deklarasikan dan inisialisasi variabel outputText
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {

            OutputLabel.Text = outputText;
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }
    }
}
