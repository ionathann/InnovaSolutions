using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;
using InovaSolutionsDAP3.Metodos;

namespace inovaWEBdap3
{
    public partial class Confiltro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (DtContext ctx = new DtContext())
                {
                    List<Voto> votos = ctx.votos.Include("Candidato").Where(a => a.Candidato.bStatus).OrderByDescending(x => x.sVoto).ToList();
                    DropDownList1.DataSource = ctx.municipios.Where(x => x.bStatus).ToList();
                    DropDownList1.DataTextField = "sNombre";
                    DropDownList1.DataValueField = "pkMunicipio";
                        DropDownList1.DataBind();
                    GridView1.DataSource = votos;
                    GridView1.DataBind();


                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ctx = new DtContext();
            List<Voto> votos = ctx.votos.Include("Candidato").Where(a => a.Candidato.sNombreCompleto.Contains(TextBox2.Text) && a.Candidato.bStatus).ToList();


            GridView1.DataSource = votos;
                GridView1.DataBind();
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            DataControlFieldCell f = (DataControlFieldCell)((Control)sender).Parent;
            string cod = (f.FindControl("lblid") as Label).Text;

            CsVotos.modificar(Convert.ToInt32(cod));

            var ctx = new DtContext();

            List<Voto> votos = ctx.votos.Include("Candidato").Where(a => a.Candidato.bStatus).OrderByDescending(x => x.sVoto).ToList();
            GridView1.DataSource = votos;
            GridView1.DataBind();



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        protected void btbBuscar2_Click(object sender, EventArgs e)
        {
            var ctx = new DtContext();
            List<Voto> votos = ctx.votos.Include("Candidato").Where(a => a.Candidato.municipios.sNombre == DropDownList1.SelectedItem.Text && a.Candidato.bStatus).OrderByDescending(x => x.sVoto).ToList();


            GridView1.DataSource = votos;
            GridView1.DataBind();
        }
    }
}