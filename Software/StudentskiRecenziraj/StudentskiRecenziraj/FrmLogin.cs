﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiRecenziraj
{
    public partial class FrmLogin : Form

    {
        string username = "student";
        string password = "menza";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!");
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                   FrmRecenzije  frmRecenzije = new FrmRecenzije();
                    Hide();
                    frmRecenzije.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi korisnički podaci!");
                }

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_atikvan22_DB", "PI2324_atikvan22_User", "X9(+kNUO");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
