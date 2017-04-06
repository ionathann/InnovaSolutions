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
    public partial class frmCapturistas : Form
    {
        public frmCapturistas()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = CsUsuarios.BuscarUsuarios(TxtBuscar.Text);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNewUser abri = new frmNewUser();
            abri.lblVariableUsuario.Text = "MODIFICAR USUARIO";
            abri.txtEmail.Text = CsUsuarios.obtenerUsuario(CsHerramientas.gridvg(dgvUsuarios)).sEmail.ToString();
            abri.txtPassword.Text = CsUsuarios.obtenerUsuario(CsHerramientas.gridvg(dgvUsuarios)).sPassword.ToString();
            abri.modi = true;
            abri.id = CsHerramientas.gridvg(dgvUsuarios);
            abri.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmNewUser abri = new frmNewUser();
            abri.ShowDialog();

        }
    }
}
