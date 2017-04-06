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
using System.Collections;

namespace InovaSolutionsDAP3
{
    public partial class rpt3candidatas : Form
    {
        public rpt3candidatas()
        {
            InitializeComponent();

            using (DtContext ctx = new DtContext())
            {
                cbxMunicipio.DataSource = ctx.municipios.ToList();
            }
        }

     
   

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            rptTop3 rpt = new rptTop3();
            using (DtContext ctx = new DtContext())
            {
                List<Voto> votos = ctx.votos.Where(a => a.Candidato.municipios.sNombre == cbxMunicipio.Text).OrderByDescending(x => x.sVoto).Take(3).ToList();
                List<Candidato> candidatos = ctx.candidatos.Where(a => a.municipios.sNombre == cbxMunicipio.Text).ToList();
                rpt.Database.Tables["votos"].SetDataSource(votos);
                rpt.Database.Tables["candidatos"].SetDataSource(candidatos);
                crystalReportViewer1.ReportSource = rpt;
                //crystalReportViewer1.RefreshReport();

            }


        }
    }
}
