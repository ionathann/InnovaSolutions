using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("PermisosNegadosRol")]
    public class PermisoNegadoRol
    {
        [Key]
        public int pkPermisoNegadoRol { get; set; }
        public Boolean bStatus { get; set; }

        public PermisoNegadoRol()
        {
            this.bStatus = true;
        }

        public virtual Rol rol { get; set; }
        public virtual Permiso permiso { get; set; }
    }
}
