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
using System.Net;
using System.IO;

namespace InovaSolutionsDAP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMunicipios.AutoGenerateColumns = false;
            
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "Introducir NOMBRE...")
            {

                TxtBuscar.Text = "";
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            dgvMunicipios.Rows.Clear();
            using (DtContext ctx = new DtContext())
            {
                foreach (var item in ctx.municipios.Where(r => r.sNombre.Contains(TxtBuscar.Text) == r.bStatus).ToList())
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Csmunicipios.obtenerMunicipio(item.pkMunicipio).sLogotipo.ToString(), System.IO.FileMode.Open);

                   Image.FromStream(fs);
                   


                    dgvMunicipios.Rows.Add(item.pkMunicipio.ToString(), item.sNombre, Image.FromStream(fs), item.sDescripcion);
                    fs.Close();
                }
            }
            

        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmNewMunicipio abri = new FrmNewMunicipio();
            abri.ShowDialog();
        }

        private void dgvMunicipios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FrmNewMunicipio abri = new FrmNewMunicipio();
            abri.lblVariableUsuario.Text = "MODIFICAR MUNICIPIO";
            abri.txtnombre.Text = Csmunicipios.obtenerMunicipio(CsHerramientas.gridvg(dgvMunicipios)).sNombre.ToString();
            abri.txtdescripcion.Text = Csmunicipios.obtenerMunicipio(CsHerramientas.gridvg(dgvMunicipios)).sDescripcion.ToString();
            System.IO.FileStream fs = new System.IO.FileStream(Csmunicipios.obtenerMunicipio(CsHerramientas.gridvg(dgvMunicipios)).sLogotipo.ToString(), System.IO.FileMode.Open);
            
            abri.pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
            abri.lblruta.Text = Csmunicipios.obtenerMunicipio(CsHerramientas.gridvg(dgvMunicipios)).sLogotipo.ToString();
            abri.ruta = Csmunicipios.obtenerMunicipio(CsHerramientas.gridvg(dgvMunicipios)).sLogotipo.ToString();
            abri.modi = true;
            abri.id = CsHerramientas.gridvg(dgvMunicipios);
            dgvMunicipios.Rows.Clear();
            abri.ShowDialog();
        

        }
    }
}
