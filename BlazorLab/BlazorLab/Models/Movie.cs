using System.ComponentModel.DataAnnotations;

namespace BlazorLab.Models
{
    public enum Genre
    {
        Action,
        Adventure,
        Animation,
        Comedy,
        Crime,
        Drama,
        Fantasy,
        Horror,
        Romance,
        Thriller
    }

    public enum Rating
    {
        G,
        PG,
        PG13,
        R
    }

    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public String Director { get; set; } = String.Empty;
        public Rating Rating { get; set; }
        [Range(1, 5)]
        public float Stars { get; set; }
    }
}
