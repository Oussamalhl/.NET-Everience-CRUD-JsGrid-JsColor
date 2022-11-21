using System.ComponentModel.DataAnnotations;


namespace Eve.Domain
{
    public enum CategorieAssurance {
        VIP=1,
        Normal=0
    }
    public class Employe
    {
        [Key]
        public int empId { get; set; }
        public CategorieAssurance categorieAssurance { get; set; }
        public string matricule { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateNaissance {get; set;}
        public int numInscAssur { get; set;}
        public int plafondAssur { get; set; }

        public virtual IList<Quittance> quittances { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
