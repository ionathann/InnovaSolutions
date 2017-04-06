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
        [StringLength(150)]
        public virtual String sDescrip { get; set; }
        public virtual Candidato Candidato { get; set; }
        public Convocatoria convocatorias { get; set; }
        [NotMapped]
        public string sFotografia { get { return Candidato.sFotografia; } }
        [NotMapped]
        public string sNombreCompleto { get { return Candidato.sNombreCompleto; } }
        [NotMapped]
        public string sNivelEstudios  { get { return Candidato.sNivelEstudios; } }
        [NotMapped]
        public int pkCandidata { get { return Candidato.pkCandidata; } }
        [NotMapped]
        public DateTime sFechaNac { get { return Candidato.sFechaNac; } }
        
        [NotMapped]
        public int edad { get { return DateTime.Today.AddTicks(-sFechaNac.Ticks).Year - 1; } }
        
        [NotMapped]
        public int Totalvotos { get { return sVoto; } }
        public Boolean bStatus { get; set; }
        [NotMapped]
        public int Candidato_pkCandidata { get { return Candidato == null ? 0 : Candidato.pkCandidata; } }
        public Voto()
        {
            this.bStatus = true;
        }


    }
}
