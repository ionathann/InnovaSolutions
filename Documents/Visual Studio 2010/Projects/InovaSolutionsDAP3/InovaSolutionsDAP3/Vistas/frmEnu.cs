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
    public partial class frmEnu : Form
    {
        public static SessionHelper SessionActiva;

        public frmEnu()
        {
            InitializeComponent();
            SessionActiva = new SessionHelper();
        }

        private void frmEnu_Load(object sender, EventArgs e)
        {
            if (!frmEnu.SessionActiva.isValid)
            {
                //frmLogin nVentana = new frmLogin();
                //nVentana.ShowDialog();
            }


        }

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.TienePermisos(permiso);

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCandidatas abri = new FrmCandidatas();
            abri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 abri = new Form1();
            abri.Show();
        }

        private void frmEnu_Activated(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCapturistas abri = new frmCapturistas();
            abri.Show();
        }
    }
}
