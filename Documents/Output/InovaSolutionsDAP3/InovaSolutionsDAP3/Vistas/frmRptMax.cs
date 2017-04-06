using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3
{
    public partial class frmRptMax : Form
    {
        public frmRptMax()
        {
            InitializeComponent();
            using (DtContext ctx = new DtContext())
            {
                cbxMunicipio.DataSource = ctx.municipios.ToList();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            RPT1 rpt = new RPT1();
            using (DtContext ctx = new DtContext())
            {
                int max = ctx.votos.Max(x => x.sVoto);
                Voto morra = ctx.votos.Include("Candidato").Where(x => x.sVoto == max).FirstOrDefault();
                int id = Convert.ToInt32(morra.Candidato.pkCandidata);

                rpt.SetDataSource(ctx.candidatos.Where(z => z.pkCandidata == id && z.municipios.sNombre.Contains(cbxMunicipio.Text)).ToList());
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();

            }
        }
    }
}
