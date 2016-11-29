﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_tutorial
{
    public partial class WinApp : Form
    {
        public WinApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtFirstName.Text + " " + txtLastName.Text +
                " Welcome to the Windows Application", "Welcome", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }
    }
}
