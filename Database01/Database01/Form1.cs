﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer01 customer01 = new Customer01();
            customer01.MdiParent = this;
            customer01.Show();
        }
    }
}
