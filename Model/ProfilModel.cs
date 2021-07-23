using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ktr_msc_ls.Model
{

    /// <summary>
    /// Classe qui caracterise la table de la base et les attributs
    /// </summary>
    [Table("Profiles")]
    public class ProfilModel
    {

        /// <summary>
        /// ID est auto-incremment
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string CompanyName { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public int Telephone { get; set; }
    }
}
