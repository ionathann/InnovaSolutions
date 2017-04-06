using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Metodos;

namespace InovaSolutionsDAP3
{
    public partial class FrmCandidatas : Form
    {
        public FrmCandidatas()
        {
            InitializeComponent();
        }

        public bool upd = true;

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "Introducir NOMBRE...")
            {

                TxtBuscar.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmNewcandidata abri = new FrmNewcandidata();
            abri.ShowDialog();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            dgvCandidatas.Rows.Clear();
            using (DtContext ctx = new DtContext())
            {
                foreach (var item in ctx.candidatos.Where(r => r.sNombreCompleto.Contains(TxtBuscar.Text) == r.bStatus).ToList())
                {
                    System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\ionathann\Documents\Output\InovaSolutionsDAP3\inovaWEBdap3\"+ CsCandidatas.obtenerCandi(item.pkCandidata).sFotografia.ToString(), System.IO.FileMode.Open);

                    Image.FromStream(fs);



                    dgvCandidatas.Rows.Add(item.pkCandidata.ToString(), item.sNombreCompleto,item.sFechaNac,item.sCurp, Image.FromStream(fs));
                    fs.Close();
                }
            }


        }

        private void dgvCandidatas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (upd)
            {
                FrmNewcandidata abri = new FrmNewcandidata();
                abri.lblVariableUsuario.Text = "MODIFICAR CANDIDATA";
                abri.txtnombre.Text = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sNombreCompleto.ToString();
                abri.dtpFDN.Value = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sFechaNac;
                abri.txtCURp.Text = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sCurp.ToString();
                abri.txtNivelEstudios.Text = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sNivelEstudios.ToString();
                abri.cbxConvocatorias.SelectedValue = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).convocatoria;
                abri.cbxMunicipios.SelectedValue = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).municipios;
                System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\ionathann\Documents\Output\InovaSolutionsDAP3\inovaWEBdap3\" + CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sFotografia.ToString(), System.IO.FileMode.Open);
                abri.ruta = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sFotografia.ToString();
                abri.pbxFoto.Image = Image.FromStream(fs);
             
                fs.Close();

                abri.txtcorreo.Text = CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sCorreo.ToString();
                abri.modi = true;
                abri.id = CsHerramientas.gridvg(dgvCandidatas);
                dgvCandidatas.Rows.Clear();
                abri.ShowDialog();
            }
            else
            {
                
                if (MessageBox.Show("Desea eliminar el registro de " + CsCandidatas.obtenerCandi(CsHerramientas.gridvg(dgvCandidatas)).sNombreCompleto.ToString() + "?","Aviso.!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    
                {
                    CsCandidatas.BORRAR(CsHerramientas.gridvg(dgvCandidatas));
                    CsVotos.borrar(CsHerramientas.gridvg(dgvCandidatas));                   
                    dgvCandidatas.Rows.Clear();
                }
                else
                {
                
                }
            }


        }

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.Controls)
            {
                if (obj is PictureBox)
                {
                    PictureBox btn = (PictureBox)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    btn.Visible = frmEnu.SessionActiva.TienePermisos(permiso);

                }
            }


        }

        private void FrmCandidatas_Load(object sender, EventArgs e)
        {
            procesarPermisos();

            if (frmEnu.SessionActiva.usuario.rol.pkRol == 1)
            {
                upd = false;
            }
        }
    }
}
