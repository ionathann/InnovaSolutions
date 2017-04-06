using
System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InovaSolutionsDAP3.Context;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3.Metodos
{
    public class ManejoSesion
    {
        public static SessionHelper Login(String User, String Password)
        {
            SessionHelper objSession = new SessionHelper();
            try
            {
                using (var ctx = new DtContext())
                {
                    Usuario user = ctx.usuarios.Include("Rol").Include("Rol.permisosnegadosrol").Where(r => r.sEmail == User && r.bStatus).FirstOrDefault();
                   
                    if (user != null)
                    {
                        if (user.sPassword == Password)
                        {
                            objSession.isValid = true;
                            objSession.usuario = user;
                        }
                    }
                }
                return objSession;
            }
            catch (Exception)
            {
                throw;
            }
        }

   

    }

    public class SessionHelper
    {
        public Boolean isValid { get; set; }
        public Usuario usuario { get; set; }
        public String msgError { get; set; }
          public SessionHelper()
        {
            this.isValid = false;
            this.usuario = null;
            this.msgError = "Datos incorrectos, favor de intentar de nuevo";
        }

        public Boolean TienePermisos(int ValidarPermiso)
            {
                Boolean tiene = true;
                if (isValid)
                {
                    try
                    {
                        using (var ctx = new DtContext())
                        {                             
                             if (ctx.permisosnegadosrol.Where(x => x.permiso.pkPermiso == ValidarPermiso && x.bStatus && x.rol.pkRol == usuario.rol.pkRol).Count() > 0)
                                tiene = false;
                        }
                        return tiene;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else { return tiene; }
            }
        }      
    }

