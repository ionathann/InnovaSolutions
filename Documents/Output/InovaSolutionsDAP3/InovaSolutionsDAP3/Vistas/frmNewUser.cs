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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        public bool modi = false;
        public int id;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text == string.Empty)
                {
                    errorsito.SetError(_textbox, "Campo obligatorio");
                    valido = false;
                }

            }



            if (modi && valido)
            {
                CsUsuarios.Actualizar(id, txtEmail.Text, txtPassword.Text);
                lblmensaje.Text = "Registro modificado";
                lblmensaje.ForeColor = Color.FromName("green");
                
             }
            else if (modi == false && valido)
            {
                CsUsuarios.Guardar(txtEmail.Text, txtPassword.Text);
                lblmensaje.Text = "Registro guardado";
                lblmensaje.ForeColor = Color.FromName("green");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
