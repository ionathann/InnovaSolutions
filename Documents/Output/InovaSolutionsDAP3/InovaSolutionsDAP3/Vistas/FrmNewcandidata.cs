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
using System.Text.RegularExpressions;

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
            label8.Text = frmEnu.SessionActiva.usuario.pkUsuario.ToString();
            var getlvl = CsHerramientas.getEstudios();
            txtNivelEstudios.AutoCompleteMode = AutoCompleteMode.Append;
            AutoCompleteStringCollection acscl = new AutoCompleteStringCollection();
            acscl.AddRange(getlvl.ToArray());
            txtNivelEstudios.AutoCompleteCustomSource = acscl;
            txtNivelEstudios.AutoCompleteSource = AutoCompleteSource.CustomSource;

            using (DtContext ctx = new DtContext())
            {

                cbxConvocatorias.DataSource = ctx.convocatorias.ToList();
                cbxMunicipios.DataSource = ctx.municipios.Where(x => x.bStatus).ToList();

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
                        pbxFoto.Image.Save(@"C:\Users\ionathann\Documents\Output\InovaSolutionsDAP3\inovaWEBdap3\imagenes\" + filename, ImageFormat.Jpeg);
                        
                        ruta = @"\Imagenes\" + filename;
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }

                CsCandidatas.Modificar(id, txtnombre.Text, dtpFDN.Value, txtCURp.Text, txtNivelEstudios.Text, ruta, Convert.ToInt32(cbxConvocatorias.SelectedValue), Convert.ToInt32(cbxMunicipios.SelectedValue), txtcorreo.Text);
                lblvariable.Text = "OK";


            }
            else if (modi == false)
            {
                if (CsCandidatas.comprobar(Convert.ToInt32(cbxConvocatorias.SelectedValue), Convert.ToInt32(cbxMunicipios.SelectedValue),txtnombre.Text) == false)
                {
                    CsCandidatas.Guardar(txtnombre.Text, dtpFDN.Value, txtCURp.Text, txtNivelEstudios.Text, @"\imagenes\" + filename, Convert.ToInt32(cbxConvocatorias.SelectedValue), Convert.ToInt32(cbxMunicipios.SelectedValue), txtcorreo.Text,frmEnu.SessionActiva.usuario.pkUsuario);
                    CsVotos.registrar(txtdescrip.Text);
                    lblvariable.Text = "OK";
                    pbxFoto.Image.Save(@"C:\Users\ionathann\Documents\Output\InovaSolutionsDAP3\inovaWEBdap3\imagenes\" + filename, ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("NO se permite registrar la misma candidata en más de un municipio en el mismo año.");


                }

            }

        }


        public static bool validarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else { return false; }
            }

            return false;
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txtcorreo.Text) == false)
            {
                MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CsCandidatas.BORRAR(id);
            CsVotos.borrar(id);
            lblvariable.Text = "Eliminada";
        }


    }

}