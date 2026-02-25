using System.ComponentModel.DataAnnotations;

namespace GameCatalogAPI.Models
{
    /// <summary>
    /// Class describes review of the game.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// ID of the game in DataBase.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Rating of the game from 1 to 10.
        /// </summary>
        [Range(1, 10)]
        public int Rating { get; set; }

        /// <summary>
        /// ID of the game, what has been observed.
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// Name of the author of review.
        /// </summary>
        [StringLength(35)]
        public string? AuthorName { get; set; }

        /// <summary>
        /// Date of review.
        /// </summary>
        [Range(typeof(DateTime), "01/01/1900", "31/12/2099", ErrorMessage = "Дата вне диапазона")]
        public DateTime? DateReleased { get; set; } 
    }
}
