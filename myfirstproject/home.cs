﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstproject
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void showbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello impoter ...." + nametextBox1.Text);
            output.Text = nametextBox1.Text;

        }

    }
}
