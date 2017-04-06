using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InovaSolutionsDAP3.Data
{
    [Table("Votos")]
    public class Voto
    {
        [Key]
        public int pkVoto { get; set; }
        [Required(ErrorMessage = "Introducir municipio")]
         public int sVoto {get;set;}
        public Candidato Candidato { get; set; }
        public Convocatoria convocatorias { get; set; }
        public Boolean bStatus { get; set; }

        public Voto()
        {
            this.bStatus = true;
        }


    }
}
