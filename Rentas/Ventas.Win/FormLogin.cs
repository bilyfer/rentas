﻿using System;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas.Win
{
    public partial class FormLogin : Form
    {
        bool puedeCerrar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puedeCerrar = true;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seguridadBL = new SeguridadBL();

            var usuario = textBox1.Text;
            var password = textBox2.Text;

            if (seguridadBL.Autenticar(usuario, password) == true)
            {
                puedeCerrar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puedeCerrar == false)
            {
                e.Cancel = true;
            }
        }
    }
}
