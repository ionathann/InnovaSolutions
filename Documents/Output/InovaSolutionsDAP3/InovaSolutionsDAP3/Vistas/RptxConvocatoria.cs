using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InovaSolutionsDAP3.Context;

namespace InovaSolutionsDAP3
{
    public partial class RptxConvocatoria : Form
    {
        public RptxConvocatoria()
        {
            InitializeComponent();

            using(DtContext ctx = new DtContext())
            {
                cbxConvocatoria.DataSource = ctx.convocatorias.ToList();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            RPT1 rpt = new RPT1();
            using (DtContext ctx = new DtContext())
            {
                rpt.SetDataSource(ctx.candidatos.Where(z => z.convocatoria.sAnio.Contains(cbxConvocatoria.Text)).ToList());
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxConvocatoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
