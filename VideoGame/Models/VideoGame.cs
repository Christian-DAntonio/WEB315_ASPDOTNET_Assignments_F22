using System.ComponentModel.DataAnnotations;

namespace RazorPagesVideoGame.Models
{
    public class VideoGame
    {
        public int ID { get; set; }
        public string Game { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Company { get; set; }
        public decimal ReviewScore { get; set; }
    }
}