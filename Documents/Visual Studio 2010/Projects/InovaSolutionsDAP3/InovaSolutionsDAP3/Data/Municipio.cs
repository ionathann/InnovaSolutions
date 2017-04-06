using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key]
        public int pkMunicipio { get; set; }
        [Required(ErrorMessage = "Introducir municipio")]
        [StringLength(50)]
        public String sNombre { get; set; }
        [Required(ErrorMessage = "Logotipo Obligatorio")]
        [StringLength(100)]
        public String sLogotipo { get; set; }
        [Required(ErrorMessage = "Descripcion Obligatoria")]
        [StringLength(100)]
        public String sDescripcion { get; set; }
        public Boolean bStatus { get; set; }

        public Municipio()
        {
            this.bStatus = true;
        }

       
    }
}
