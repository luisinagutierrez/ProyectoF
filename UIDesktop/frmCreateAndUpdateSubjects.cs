﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmCreateAndUpdateSubjects : Form
    {
        public frmCreateAndUpdateSubjects()
        {
            InitializeComponent();
        }

        private void frmCreateAndUpdateSubjects_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}