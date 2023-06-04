
using Microsoft.EntityFrameworkCore;
using lab2_razor.Data;
using System.ComponentModel.DataAnnotations;
using lab2_razor.Pages.Models;

namespace lab2_razor.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new lab2_razorContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<lab2_razorContext>>()))
        {
            if (context == null || context.Post == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Post.Any())
            {
                return;   // DB has been seeded
            }

            context.Post.AddRange(
                new Post
                {
                    Title = "Next Post",
                    Description = "This is description of the new post",
                    Author = "Rafaello Buanito",
                    PublicDate = DateTime.Parse("2023-06.04").ToString(),
                },

                new Post
                {
                    Title = "Next Post Again",
                    Description = "This is description of the new post",
                    Author = "Rafaello Buanito",
                    PublicDate = DateTime.Parse("2023-06.04").ToString(),
                },

                new Post
                {
                    Title = "Next Post and Again",
                    Description = "This is description of the new post",
                    Author = "Rafaello Buanito",
                    PublicDate = DateTime.Parse("2023-06.04").ToString(),
                },

                new Post
                {
                    Title = "Next Post Masterpiece",
                    Description = "This is description of the new post",
                    Author = "Rafaello Buanito",
                    PublicDate = DateTime.Parse("2023-06.04").ToString(),
                }
            );
            context.SaveChanges();
        }
    }
}