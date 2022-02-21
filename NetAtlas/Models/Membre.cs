using System.ComponentModel.DataAnnotations;

namespace NetAtlas.Models
{
    public class Membre
    {
        [Key]
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Ad_email { get; set; }

        public Membre(int id, string nom, string prenom, string ad_email)
        {
            Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Ad_email = ad_email;
        }
    }
    
}
