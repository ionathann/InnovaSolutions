using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InovaSolutionsDAP3
{
    public partial class frmMenuRpts : Form
    {
        public frmMenuRpts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rptXmUnicipio abri = new rptXmUnicipio();
            abri.ShowDialog();
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
                    btn.Enabled = frmEnu.SessionActiva.TienePermisos(permiso);

                }
            }


        }
        private void frmMenuRpts_Load(object sender, EventArgs e)
        {
            procesarPermisos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptxConvocatoria abri = new RptxConvocatoria();
            abri.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rptXcapturista abri = new rptXcapturista();
            abri.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRptMax abri = new frmRptMax();
            abri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rpt3candidatas abri = new rpt3candidatas();
            abri.ShowDialog();
        }
    }
}
