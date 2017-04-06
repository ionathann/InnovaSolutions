using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3.Metodos
{
    public class CsCandidatas
    {


        public static void Guardar(string nombre,DateTime fecha, string curp, string nivelstu, string foto,int idconvo,int idmuni,string correo)
        {

            try
            {

                using (DtContext ctx = new DtContext())
                {

                    Candidato candi = new Candidato();

                    candi.sNombreCompleto = nombre;
                    candi.sCorreo = correo;
                    candi.sFechaNac = fecha;
                    candi.sCurp = curp;
                    candi.sNivelEstudios = nivelstu;
                    candi.sFotografia = foto;


                    Municipio mn = ctx.municipios.Where(x => x.pkMunicipio == idmuni).FirstOrDefault();
                    Convocatoria cvn = ctx.convocatorias.Where(x => x.pkConvocatoria == idconvo).FirstOrDefault();
                    ctx.convocatorias.Attach(cvn);
                    ctx.municipios.Attach(mn);

                    candi.convocatoria = cvn;
                    candi.municipios = mn;

                    ctx.candidatos.Add(candi);
                    ctx.SaveChanges();
                
                
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        
        
        }

        public static void Modificar(int id,string nombre, DateTime fecha, string curp, string nivelstu, string foto, int idconvo, int idmuni, string correo)
        {

            try
            {

                using (DtContext ctx = new DtContext())
                {

                    var candi = ctx.candidatos.Find(id);
                    candi.sNombreCompleto = nombre;
                    candi.sCorreo = correo;
                    candi.sFechaNac = fecha;
                    candi.sCurp = curp;
                    candi.sNivelEstudios = nivelstu;
                    candi.sFotografia = foto;


                    Municipio mn = ctx.municipios.Where(x => x.pkMunicipio == idmuni).FirstOrDefault();
                    Convocatoria cvn = ctx.convocatorias.Where(x => x.pkConvocatoria == idconvo).FirstOrDefault();
                    ctx.convocatorias.Attach(cvn);
                    ctx.municipios.Attach(mn);

                    candi.convocatoria = cvn;
                    candi.municipios = mn;

                   
                    ctx.SaveChanges();


                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        public static Candidato obtenerCandi(int id)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.candidatos.Where(r => r.pkCandidata == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
