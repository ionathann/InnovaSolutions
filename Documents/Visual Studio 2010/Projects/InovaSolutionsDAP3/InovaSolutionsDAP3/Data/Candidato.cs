using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Candidatos")]
    public class Candidato
    {
        [Key]
        public int pkCandidata { get; set; }
        public Convocatoria convocatoria { get; set; }
        [Required(ErrorMessage = "Nombre Completo")]
        [StringLength(50)]
        public String sNombreCompleto { get; set; }
        [Column(TypeName = "Date")]
        [Required(ErrorMessage = "Se requiere fecha")]
        public DateTime sFechaNac { get; set; }
        [Required(ErrorMessage = "curp Obligatorio")]
        [StringLength(18)]
        public String sCurp { get; set; }
        [Required(ErrorMessage = "correo Obligatorio")]
        [StringLength(30)]
        public String sCorreo { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(100)]
        public String sNivelEstudios { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(100)]
        public String sFotografia { get; set; }
        public Municipio municipios { get; set; }
        public Boolean bStatus { get; set; }

        public Candidato()
        {
            this.bStatus = true;
        }


    }
}
