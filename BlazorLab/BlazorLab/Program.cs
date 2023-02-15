using BlazorLab;
using BlazorLab.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorLab
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }

        public static List<Movie> GenerateMovies()
        {
            return new List<Movie>
            {
                new Movie()
                {
                    Id = 1,
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Genres = new Genre[] { Genre.Drama },
                    Director = "Frank Darabont",
                    Rating = Rating.R,
                    Stars = 4.55f
                },
                new Movie()
                {
                    Id = 2,
                    Title = "The Godfather",
                    Year = 1972,
                    Genres = new Genre[] { Genre.Crime, Genre.Drama },
                    Director = "Francis Ford Coppola",
                    Rating = Rating.R,
                    Stars = 4.6f
                },
                new Movie()
                {
                    Id = 3,
                    Title = "The Godfather: Part II",
                    Year = 1974,
                    Genres = new Genre[] { Genre.Crime, Genre.Drama },
                    Director = "Francis Ford Coppola",
                    Rating = Rating.R,
                    Stars = 4.8f
                },
                new Movie()
                {
                    Id = 4,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Genres = new Genre[] { Genre.Action, Genre.Thriller },
                    Director = "Christopher Nolan",
                    Rating = Rating.PG13,
                    Stars = 5
                },
                new Movie()
                {
                    Id = 5,
                    Title = "The Hangover",
                    Year = 2009,
                    Genres = new Genre[] { Genre.Comedy },
                    Director = "Todd Phillips",
                    Rating = Rating.R,
                    Stars = 4
                },
                new Movie()
                {
                    Id = 6,
                    Title = "The Devil Wears Prada",
                    Year = 2006,
                    Genres = new Genre[] { Genre.Comedy, Genre.Drama },
                    Director = "Todd Phillips",
                    Rating = Rating.PG13,
                    Stars = 3.7f
                },
                new Movie()
                {
                    Id = 7,
                    Title = "The Hangover Part II",
                    Year = 2011,
                    Genres = new Genre[] { Genre.Comedy },
                    Director = "Todd Phillips",
                    Rating = Rating.R,
                    Stars = 3.5f
                },
                new Movie()
                {
                    Id = 8,
                    Title = "The Hangover Part III",
                    Year = 2013,
                    Genres = new Genre[] { Genre.Comedy, Genre.Crime },
                    Director = "Todd Phillips",
                    Rating = Rating.R,
                    Stars = 3.2f
                },
                new Movie()
                {
                    Id = 9,
                    Title = "The Babadook",
                    Year = 2014,
                    Genres = new Genre[] { Genre.Horror },
                    Director = "Jennifer Kent",
                    Rating = Rating.R,
                    Stars = 4.9f
                },
                new Movie()
                {
                    Id = 10,
                    Title = "The Conjuring",
                    Year = 2013,
                    Genres = new Genre[] { Genre.Horror },
                    Director = "James Wan",
                    Rating = Rating.R,
                    Stars = 4.3f
                },
                new Movie()
                {
                    Id = 11,
                    Title = "Toy Story",
                    Year = 1995,
                    Genres = new Genre[] { Genre.Adventure, Genre.Animation, Genre.Comedy },
                    Director = "John Lasseter",
                    Rating = Rating.G,
                    Stars = 4.92f
                },
                new Movie()
                {
                    Id = 12,
                    Title = "Toy Story 2",
                    Year = 1999,
                    Genres = new Genre[] { Genre.Adventure, Genre.Animation, Genre.Comedy },
                    Director = "John Lasseter",
                    Rating = Rating.G,
                    Stars = 4.9f
                },
                new Movie()
                {
                    Id = 13,
                    Title = "Coraline",
                    Year = 2009,
                    Genres = new Genre[] { Genre.Horror, Genre.Animation, Genre.Fantasy },
                    Director = "Henry Selick",
                    Rating = Rating.PG,
                    Stars = 4.75f
                },
                new Movie()
                {
                    Id = 14,
                    Title = "The Nightmare Before Christmas",
                    Year = 1993,
                    Genres = new Genre[] { Genre.Horror, Genre.Animation, Genre.Fantasy },
                    Director = "Henry Selick",
                    Rating = Rating.PG,
                    Stars = 4.75f
                },
                new Movie()
                {
                    Id = 15,
                    Title = "The Lion King",
                    Year = 1994,
                    Genres = new Genre[] { Genre.Animation, Genre.Drama },
                    Director = "Roger Allers",
                    Rating = Rating.G,
                    Stars = 4.8f
                },
                new Movie()
                {
                    Id = 16,
                    Title = "The Lion King 2: Simba's Pride",
                    Year = 1998,
                    Genres = new Genre[] { Genre.Animation, Genre.Drama },
                    Director = "Darrell Rooney",
                    Rating = Rating.G,
                    Stars = 4.7f
                },
                new Movie()
                {
                    Id = 17,
                    Title = "The Incredibles",
                    Year = 2004,
                    Genres = new Genre[] { Genre.Animation, Genre.Action, Genre.Adventure },
                    Director = "Brad Bird",
                    Rating = Rating.PG,
                    Stars = 4.8f
                },
                new Movie()
                {
                    Id = 18,
                    Title = "The Incredibles 2",
                    Year = 2018,
                    Genres = new Genre[] { Genre.Animation, Genre.Action, Genre.Adventure },
                    Director = "Brad Bird",
                    Rating = Rating.PG,
                    Stars = 4.7f
                },
            };
        }
    }
}