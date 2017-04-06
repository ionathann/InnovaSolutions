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
    public partial class rptXmUnicipio : Form
    {
        public rptXmUnicipio()
        {
            InitializeComponent();
             using(DtContext ctx = new DtContext())
            {
                cbxMunicipio.DataSource = ctx.municipios.ToList();
            }
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            RPT1 rpt = new RPT1();
            using (DtContext ctx = new DtContext())
            {
                rpt.SetDataSource(ctx.candidatos.Where(z => z.municipios.sNombre.Contains(cbxMunicipio.Text)).ToList());
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
        }
    }
}
