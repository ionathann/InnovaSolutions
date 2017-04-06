using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InovaSolutionsDAP3.Data;
using InovaSolutionsDAP3.Context;

namespace InovaSolutionsDAP3.Metodos
{
    public class CsUsuarios
    {
       
        public static List<Rol> ListarRoles()
        {
            try
            {
                var ctx = new DtContext();
                return ctx.roles.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Usuario> BuscarUsuarios(string buscale)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.usuarios.Include("Rol").Where(x => x.sEmail.Contains(buscale) && x.rol.pkRol == 2).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void Actualizar(int idUser, string nombre, string password)
        {
            using (var ctx = new DtContext())
            {
                Rol rl = ctx.roles.Where(x => x.pkRol == 2).FirstOrDefault();
                ctx.roles.Attach(rl);
                var user = ctx.usuarios.Find(idUser);
                user.sEmail = nombre;
                user.sPassword = password;
                user.rol = rl;
                ctx.SaveChanges();
            }




        }

        public static void Guardar(string email, string password)
        {
            var ctx = new DtContext();

            Rol rl = ctx.roles.Where(x => x.pkRol == 2).FirstOrDefault();
            ctx.roles.Attach(rl);

            var User = new Usuario() { sEmail = email, sPassword = password, rol = rl };
            ctx.usuarios.Add(User);
            ctx.SaveChanges();

        }





        public static List<Usuario> ListarTODOS()
        {
            try
            {
                var ctx = new DtContext();
                return ctx.usuarios.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Usuario obtenerUsuario(int id)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.usuarios.Include("Rol").Where(r => r.pkUsuario == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
