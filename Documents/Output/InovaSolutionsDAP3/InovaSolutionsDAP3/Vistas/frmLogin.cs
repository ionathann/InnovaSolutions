using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InovaSolutionsDAP3.Metodos;

namespace InovaSolutionsDAP3
{
    public partial class frmLogin : Form
    {
        SessionHelper objSession;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objSession = ManejoSesion.Login(txtUsuario.Text, txtPassword.Text);
            if (!objSession.isValid)
            {
                errorProvider1.SetError(txtUsuario, objSession.msgError);
                txtUsuario.Focus();

            }
            else
            {

                frmEnu.SessionActiva = objSession;
                this.Close();
              
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!frmEnu.SessionActiva.isValid)
            {
                Application.Exit();
            }
        }
    }
}
