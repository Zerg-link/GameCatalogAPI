// Models/Genre.cs


using System.ComponentModel.DataAnnotations;

namespace GameCatalogAPI.Models
{
    /// <summary>
    /// Class describes computer game genre.
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// ID of genre in DataBase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of game genre.
        /// </summary>
        [StringLength(35)]
        public required string Name { get; set; }

        /// <summary>
        /// Description of game genre.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

    }
}
