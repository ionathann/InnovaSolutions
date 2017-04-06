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


        public static void Guardar(string nombre,DateTime fecha, string curp, string nivelstu, string foto,int idconvo,int idmuni,string correo,int capturista)
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

                    Usuario cap = ctx.usuarios.Where(x => x.pkUsuario == capturista).FirstOrDefault();
                    Municipio mn = ctx.municipios.Where(x => x.pkMunicipio == idmuni).FirstOrDefault();
                    Convocatoria cvn = ctx.convocatorias.Where(x => x.pkConvocatoria == idconvo).FirstOrDefault();
                    ctx.convocatorias.Attach(cvn);
                    ctx.municipios.Attach(mn);
                    ctx.usuarios.Attach(cap);

                    candi.usuario = cap;
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

        public static bool comprobar(int idconv,int idmuni, string nombre)
        {
            try
            {
                using(DtContext ctx = new DtContext())
                {

                    if (ctx.candidatos.Where(x => x.sNombreCompleto == nombre && x.municipios.pkMunicipio == idmuni && x.convocatoria.pkConvocatoria == idconv).Count() > 0)
                {
                return true;
                
                }
                
                else
                {
                
                return false;

                }
                
                }                             
                    

            }
            catch (Exception)
            {
                
                throw;
            }


            
        
        }

        public static void BORRAR(int id)
        {

            try
            {

                using (DtContext ctx = new DtContext())
                {

                    var candi = ctx.candidatos.Find(id);
                    candi.bStatus = false;
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
