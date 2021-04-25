using Microsoft.EntityFrameworkCore;

namespace GerasPokedex_API.Models
{
    public class GerasPokedexContext : DbContext
    {
        public GerasPokedexContext(DbContextOptions<GerasPokedexContext> options) : base(options)
        {
        }

        public DbSet<UserItem> Users { get; set; }
        public DbSet<UserFavoriteItem> UsersFavorites { get; set; }
        public DbSet<FavoriteItem> Favorites { get; set; }
    }
}