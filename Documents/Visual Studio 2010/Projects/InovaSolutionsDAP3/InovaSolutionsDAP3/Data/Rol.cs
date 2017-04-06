using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{

    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int pkRol { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        public String sNombre { get; set; }
        public Boolean bStatus { get; set; }
        public String sDescripcion { get; set; }

        public Rol()
        {
            this.bStatus = true;
        }

        public virtual ICollection<Usuario> usuarios { get; set; }
        public virtual ICollection<PermisoNegadoRol> permisosnegadosrol { get; set; }
    }
}
