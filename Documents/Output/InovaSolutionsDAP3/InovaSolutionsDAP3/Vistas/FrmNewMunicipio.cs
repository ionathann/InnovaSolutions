using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using InovaSolutionsDAP3.Metodos;
using InovaSolutionsDAP3.Context;
using System.IO;

namespace InovaSolutionsDAP3
{
    public partial class FrmNewMunicipio : Form
    {
        public FrmNewMunicipio()
        {
            InitializeComponent();
        }
        public bool modi = false;
        public bool foti = false;
        public int id;
        public string ruta;
        string filename;       

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dSelFichero =
                    new System.Windows.Forms.OpenFileDialog();
            dSelFichero.Filter = "Ficheros de imagen (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*";
            dSelFichero.Title = "Fichero de imagen";
            dSelFichero.DefaultExt = "jpg" + "png";
            if (dSelFichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = null;
                
                if (System.IO.File.Exists(dSelFichero.FileName))
                {
                    
                    foti = true;
                    pictureBox1.Image = Image.FromFile(dSelFichero.FileName);
                    filename = System.IO.Path.GetFileName(dSelFichero.FileName);
                    lblruta.Text = System.IO.Path.GetFileName(dSelFichero.FileName);
                   
                    
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
                        File.Delete(Csmunicipios.obtenerMunicipio(id).sLogotipo.ToString());
                        pictureBox1.Image.Save(@"C:\Imagenes\" + filename, ImageFormat.Jpeg);
                        ruta = @"C:\Imagenes\" + filename;
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                                   
                }
                lblvariable.Text = "OK";
                Csmunicipios.Modificar(id, txtnombre.Text, ruta, txtdescripcion.Text);
                
            }
            else if (modi == false)
            {
                         
                Csmunicipios.Guardar(txtnombre.Text, @"C:\Imagenes\" + filename, txtdescripcion.Text);
                pictureBox1.Image.Save(@"C:\Imagenes\" + filename, ImageFormat.Jpeg);
                lblvariable.Text = "OK";
            }
        }

        private void FrmNewMunicipio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Csmunicipios.borradorlogico(id);
            this.Close();
        }
    }
}