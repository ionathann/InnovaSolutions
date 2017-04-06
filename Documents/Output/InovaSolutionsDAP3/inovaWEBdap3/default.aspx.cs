using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Metodos;
using InovaSolutionsDAP3.Data;

namespace inovaWEBdap3
{
    public partial class _default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (DtContext ctx = new DtContext())
                {
                    List<Voto> votos = ctx.votos.Include("Candidato").OrderByDescending(x => x.sVoto).ToList();

                    DataList1.DataSource = votos;
                    DataList1.DataBind();                  
                                                          
                
                }
            
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            //using (DtContext ctx = new DtContext())
            //{
            //    GridView1.PageIndex = e.NewPageIndex;
            //    GridView1.DataSource = ctx.candidatos.ToList();
            //    GridView1.DataBind();

            //}
           
            
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                DataListItem f = (DataListItem)((Control)sender).Parent;
                string cod = (f.FindControl("lblid") as Label).Text;
                                
                    CsVotos.modificar(Convert.ToInt32(cod));
                    

                
               
            }
        }
             
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem it = (DataListItem)((Control)(e.CommandSource)).Parent;

            string cod = (it.FindControl("lblid") as Label).Text;

            if (CsVotos.consultarvoto(Convert.ToInt32(cod)))
            {
                CsVotos.modificar(Convert.ToInt32(cod));
                using (DtContext ctx = new DtContext())
                {

                    List<Voto> votos = ctx.votos.Include("Candidato").OrderByDescending(x => x.sVoto).ToList();

                    DataList1.DataSource = votos;
                    DataList1.DataBind();
                   
                    
                }

            }
            else
            {
                

                using (DtContext ctx = new DtContext())
                {

                    List<Voto> votos = ctx.votos.Include("Candidato").OrderByDescending(x => x.sVoto).ToList();

                    DataList1.DataSource = votos;
                    DataList1.DataBind();
                   
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ctx = new DtContext();

                List<Voto> votos = ctx.votos.Include("Candidato").Where(a => a.Candidato.sNombreCompleto == (txtBuscar.Text)).OrderByDescending(x => x.sVoto).ToList();

                DataList1.DataSource = votos;
                DataList1.DataBind();

            

        }
    }
}