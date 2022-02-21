using NetAtlas.Models;
using Microsoft.EntityFrameworkCore;

namespace NetAtlas.Data
{
    public class DataContext: DbContext
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

        public DbSet<Membre> Membres { get; set; }
    }

}
