using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InovaSolutionsDAP3.Metodos;
using InovaSolutionsDAP3.Context;
using System.Drawing.Imaging;
using System.IO;

namespace InovaSolutionsDAP3
{
    public partial class FrmNewcandidata : Form
    {
        public FrmNewcandidata()
        {
            InitializeComponent();
        }

        public bool modi = false;
        public bool foti = false;
        public int id;
        public string ruta;
        string filename;

        private void FrmNewcandidata_Load(object sender, EventArgs e)
        {
            var getlvl = CsHerramientas.getEstudios();
            txtNivelEstudios.AutoCompleteMode = AutoCompleteMode.Append;
            AutoCompleteStringCollection acscl = new AutoCompleteStringCollection();
            acscl.AddRange(getlvl.ToArray());
            txtNivelEstudios.AutoCompleteCustomSource = acscl;
            txtNivelEstudios.AutoCompleteSource = AutoCompleteSource.CustomSource;

            using (DtContext ctx = new DtContext())
            {

                cbxConvocatorias.DataSource = ctx.convocatorias.ToList();
                cbxMunicipios.DataSource = ctx.municipios.ToList();

            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dSelFichero =
                    new System.Windows.Forms.OpenFileDialog();
            dSelFichero.Filter = "Ficheros de imagen (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*";
            dSelFichero.Title = "Fichero de imagen";
            dSelFichero.DefaultExt = "jpg" + "png";
            if (dSelFichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                if (System.IO.File.Exists(dSelFichero.FileName))
                {

                    foti = true;
                    pbxFoto.Image = Image.FromFile(dSelFichero.FileName);
                    filename = System.IO.Path.GetFileName(dSelFichero.FileName);
                    

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (modi)
            {
                if (foti)
                {

                    try
                    {
                        File.Delete(CsCandidatas.obtenerCandi(id).sFotografia.ToString());
                        pbxFoto.Image.Save(@"C:\Imagenes\" + filename, ImageFormat.Jpeg);

                        ruta = @"C:\Imagenes\" + filename;
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }

                CsCandidatas.Modificar(id, txtnombre.Text, dtpFDN.Value, txtCURp.Text, txtNivelEstudios.Text, ruta, Convert.ToInt32(cbxConvocatorias.SelectedValue), Convert.ToInt32(cbxMunicipios.SelectedValue),txtcorreo.Text);
                

               
            }
            else if (modi == false)
            {

                CsCandidatas.Guardar(txtnombre.Text, dtpFDN.Value, txtCURp.Text, txtNivelEstudios.Text, @"C:\Imagenes\" + filename, Convert.ToInt32(cbxConvocatorias.SelectedValue), Convert.ToInt32(cbxMunicipios.SelectedValue),txtcorreo.Text);
                pbxFoto.Image.Save(@"C:\Imagenes\" + filename, ImageFormat.Jpeg);
            }

        }
    }
}
