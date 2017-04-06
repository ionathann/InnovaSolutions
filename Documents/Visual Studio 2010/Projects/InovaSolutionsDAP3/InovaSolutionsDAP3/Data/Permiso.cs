using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }
        [Required(ErrorMessage = "Modulo requerido")]
        [StringLength(50)]
        public string sModulo { get; set; }
        [StringLength(250)]
        public string sDescripcion { get; set; }

        public virtual ICollection<PermisoNegadoRol> permisosnegadosrol { get; set; }
    }
}
