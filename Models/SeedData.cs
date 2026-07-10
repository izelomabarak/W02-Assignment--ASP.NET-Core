using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Pacific Rim",
                    ReleaseDate = DateTime.Parse("2013-07-12"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "The Prince of Egypt",
                    ReleaseDate = DateTime.Parse("1998-12-18"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Transformers",
                    ReleaseDate = DateTime.Parse("2007-07-03"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 12.99M
                }
            );
            context.SaveChanges();
        }
    }
}