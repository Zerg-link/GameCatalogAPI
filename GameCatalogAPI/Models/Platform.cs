// Models/Platforms.cs


using System.ComponentModel.DataAnnotations;

namespace GameCatalogAPI.Models
{

    /// <summary>
    /// Class describes platforms, what can runs games.
    /// </summary>
    public class Platform
    {
        /// <summary>
        /// ID of the game platform in DataBase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the game platform.
        /// </summary>
        [StringLength(35)]
        public required string Name { get; set; }

        /// <summary>
        /// Description of game platform.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Collection of games of connection in EF Core.
        /// </summary>
        public ICollection<Game> Games { get; set; } = [];
    }
}
