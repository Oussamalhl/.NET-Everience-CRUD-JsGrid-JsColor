using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Eve.Domain
{
    public class Quittance
    {
        [Key]
        public int idQuittance { get; set; }
        public string matricule { get; set; }
        public string numSinistre { get; set; }
        public int numeroQuittance { get; set; }
        public string prenomPrestataire { get; set; }
        public string qualitePrestataire { get; set; }
        public DateTime dateBordeau { get; set; }
        public DateTime dateSoins { get; set; }
        public float fraisEngage { get; set; }
        public float totalFraisEngage { get; set; }
        [DataType(DataType.MultilineText)]
        public string commentaire { get; set; }

        public int employeFK { get; set; }
        [ForeignKey("employeFK")]
        public virtual Employe Employe { get; set; }



    }
}
