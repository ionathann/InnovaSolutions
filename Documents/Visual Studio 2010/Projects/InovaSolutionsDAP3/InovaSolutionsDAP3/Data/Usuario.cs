using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }
        [Required(ErrorMessage = "Introducir email")]
        [StringLength(50)]
        public String sEmail { get; set; }
        [Required(ErrorMessage = "Contraseña obligatoria")]
        [StringLength(128)]
        public String sPassword { get; set; }
        public Boolean bStatus { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }

        public virtual Rol rol { get; set; }
    }
}
