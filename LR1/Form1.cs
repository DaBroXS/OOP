﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = double.Parse(TextBox_X.Text);
            var y = double.Parse(TextBox_Y.Text);
            var result = (x * Math.Log10(x)) + y / (Math.Cos(x) - (x / 3));
            Label_Result.Text = result.ToString();
                }

      
    }
}
