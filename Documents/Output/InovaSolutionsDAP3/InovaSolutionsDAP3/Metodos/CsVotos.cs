using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3.Metodos
{
    public class CsVotos
    {


        public static bool consultarvoto(int id)
        {
         using(DtContext ctx = new DtContext())
         {
             // si existen votos entonces modifica, si da else que haga un insert
             if (ctx.votos.Where(x => x.Candidato.pkCandidata == id).Count() > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }
                    
         }
           
      
        }




        public static int consulta2(int id)
        {
            using (DtContext ctx = new DtContext())
            {
                Voto voto = ctx.votos.Where(x => x.Candidato.pkCandidata == id).FirstOrDefault();
                int vo = voto.sVoto;

                return vo;


            }
        
        }

        public static void modificar(int id)
        {
            using (DtContext ctx = new DtContext())
            {

                var voto = ctx.votos.Where(x => x.Candidato.pkCandidata == id).FirstOrDefault();

                voto.sVoto = consulta2(id)+1;


                ctx.SaveChanges();
            }
        
        }

        public static void borrar(int id)
        {
            using (DtContext ctx = new DtContext())
            {

                var voto = ctx.votos.Where(x => x.Candidato.pkCandidata == id).FirstOrDefault();

                voto.bStatus = false;


                ctx.SaveChanges();
            }

        }

        public static void registrar(string descrip)
        {
            using (DtContext ctx = new DtContext())
            {
                int max = ctx.convocatorias.Max(p => p.pkConvocatoria);
                int max2 = ctx.candidatos.Max(w => w.pkCandidata);
                Candidato candi = ctx.candidatos.Where(x => x.pkCandidata == max2).FirstOrDefault();
                Convocatoria convo = ctx.convocatorias.Where(x => x.pkConvocatoria == max).FirstOrDefault();

                ctx.candidatos.Attach(candi);
                ctx.convocatorias.Attach(convo);

                var Voto = new Voto { sVoto = 0, Candidato = candi, convocatorias = convo,sDescrip = descrip };
                ctx.votos.Add(Voto);
                ctx.SaveChanges();
            }
        
        
        }

    }
}
