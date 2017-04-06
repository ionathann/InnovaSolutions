using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3.Metodos
{
    public class Csmunicipios
    {


        public static void Guardar(string nombre, string foto, string descripcion)
         {
        using (DtContext ctx = new DtContext())
        {

            Municipio muni = new Municipio() { sNombre = nombre, sLogotipo = foto, sDescripcion = descripcion };
            ctx.municipios.Add(muni);
           ctx.SaveChanges();                          
        }      
          }


        public static void Modificar(int id,string nombre, string foto, string descripcion)
        {
            using (DtContext ctx = new DtContext())
            {

                var mun = ctx.municipios.Find(id);
                mun.sNombre = nombre;
                mun.sLogotipo = foto;
                mun.sDescripcion = descripcion;
                ctx.SaveChanges();
            
            }
        
        }

        public static void Borrar(int id)
        {
        
            using (DtContext ctx = new DtContext())
            {

                Municipio mun = ctx.municipios.Find(id);
                ctx.municipios.Remove(mun);
                ctx.SaveChanges();
           
            }
        
        
        
        }

        public static List<Municipio> Buscar(string nombre)
        {
            using (DtContext ctx = new DtContext())
            {

                return ctx.municipios.Where(x => x.sNombre == nombre).ToList();
            }
        
        
        }

        public static Municipio obtenerMunicipio(int id)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.municipios.Where(r => r.pkMunicipio == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
