﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
        {
            public Form1()
            {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

            label1.Text = "OK";
            Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = Convert.ToString(Cursor.Position.X);
        }
    }
}
