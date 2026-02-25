using System.ComponentModel.DataAnnotations;

namespace GameCatalogAPI.Models
{
    /// <summary>
    /// Class describes computer games.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// ID of the game in DataBase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the game.
        /// </summary>
        [StringLength(35)]
        public required string Name { get; set; }

        /// <summary>
        /// Description of game.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Date of releasing of the game.
        /// </summary>
        [Range(typeof(DateTime), "01/01/1900", "31/12/2099", ErrorMessage = "Дата вне диапазона")]
        public DateTime? DateReleased { get; set; }

        /// <summary>
        /// Array of platforms, what can launch the game.
        /// </summary>
        public ICollection<Platform>? Platforms { get; set; } = [];

        /// <summary>
        /// Array of game genres, what describes the game.
        /// </summary>
        public ICollection<Genre>? Genres { get; set; } = [];

        /// <summary>
        /// Array of game reviews from the observers.
        /// </summary>
        public ICollection<Review>? Reviews { get; set; } = [];
    }
}
