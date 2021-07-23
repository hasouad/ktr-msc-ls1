using Microsoft.EntityFrameworkCore;

namespace ktr_msc_ls.Model
{
    /// <summary>
    /// Le lien avec la base de donnée, cette classe s'occupe de la connexion
    /// </summary>

    public class MyDbContext : DbContext
    {
        /// <summary>
        /// Les profils présentes dans la base de données
        /// </summary>
        public DbSet<ProfilModel> Profils { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <param name="options">le moyen de se connecter a la base</param>
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
