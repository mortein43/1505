﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void gobutton_Click(object sender, EventArgs e, KeyEventArgs e1)
        {
            string httpPattern = @"^http(s)?://[a-z0-9_-]+(\.[a-z0-9_-]*\.[a-z-\d]{2,9})";
            Regex regex = new Regex(httpPattern);
            string text = textBox1.Text;
            if (regex.IsMatch(text))
            {
                label1.Text = "";
                webBrowser1.Navigate(new Uri(text));
            } else
            {
                label1.Text = "Невірно введена адреса.";
            }
        }


    }
}
