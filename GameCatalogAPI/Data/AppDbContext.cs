// Data/AppDbContext.cs

using GameCatalogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameCatalogAPI.Data
{
    /// <summary>
    /// Class describes how to connect, edit models with tables in database.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Table of games from DataBase.
        /// </summary>
        public DbSet<Game> Games { get; set; }

        /// <summary>
        /// Table of reviews from DataBase.
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Table of platforms from DataBase.
        /// </summary>
        public DbSet<Platform> Platforms { get; set; }

        /// <summary>
        /// Table of genres from DataBase.
        /// </summary>
        public DbSet<Genre> Genres { get; set; }
        

        /// <summary>
        /// Connection DataBase options to the DBContext.
        /// </summary>
        /// <param name="options"> DataBase information tables.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
    }
}
