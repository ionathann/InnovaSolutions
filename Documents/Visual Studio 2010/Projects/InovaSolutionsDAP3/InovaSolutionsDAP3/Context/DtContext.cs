using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using InovaSolutionsDAP3.Data;

namespace InovaSolutionsDAP3.Context
{
    public class DtContext : DbContext
    {
        public DtContext()
            : base("DtContext")
        {
            
        }
        public virtual DbSet<Candidato> candidatos { get; set; }
        public virtual DbSet<Convocatoria> convocatorias { get; set; }
        public virtual DbSet<Municipio> municipios { get; set; }
        public virtual DbSet<Voto> votos { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Rol> roles { get; set; }
        public virtual DbSet<Permiso> permisos { get; set; }
        public virtual DbSet<PermisoNegadoRol> permisosnegadosrol { get; set; }
    }
}
