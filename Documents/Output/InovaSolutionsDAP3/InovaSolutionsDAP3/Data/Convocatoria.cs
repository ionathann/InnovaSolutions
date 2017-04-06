using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Convocatorias")]
    public class Convocatoria
    {
        [Key]
        public int pkConvocatoria { get; set; }
        [Required(ErrorMessage = "Introducir año")]
        [StringLength(50)]
        public String sAnio { get; set; }
        [Required(ErrorMessage = "Descripción obligatoria")]        
        [StringLength(100)]
        public String sDescripcion { get; set; }
        public Boolean bStatus { get; set; }

        public Convocatoria()
        {
            this.bStatus = true;
        }


    }
}
