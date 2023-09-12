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
    public partial class frmUserPasswordChange : Form
    {
        public frmUserPasswordChange()
        {
            InitializeComponent();
        }

        private void btnUserNewPasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserNewPasswordAcept_Click(object sender, EventArgs e)
        {
            string username = Convert.ToString(txtUserName.Text);
            int id = Convert.ToInt32(txtUserIdPerson.Text);
            string pass = Convert.ToString(txtUserNewPassword.Text);

            Negocio.Users u = new Negocio.Users();
            int rta = u.ChangePassword(username, id, pass);
            if (rta != 0)
            {
                MessageBox.Show("Se guardó la contraseña correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ingresado no existe.");
            }


        }
    }
}
