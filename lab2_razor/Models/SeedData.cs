
using Microsoft.EntityFrameworkCore;
using lab2_razor.Data;
using System.ComponentModel.DataAnnotations;
using lab2_razor.Pages.Models;
using System.Globalization;
using System;

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
                    Title = "Dive into the Digital Adventure: Exploring the World of Computer Games",
                    Description = "Embark on a thrilling journey through the vast landscapes of virtual realms. Join me, Mark Anderson, as we uncover the exhilaration, creativity, and immersive experiences that await in the realm of computer games. Get ready to level up your gaming knowledge and discover new horizons in this captivating digital adventure.",
                    Author = "Adam Stevens",
                },

                new Post
                {
                    Title = "The Artistry of Gaming: A Visual Masterpiece",
                    Description = "Immerse yourself in the stunning world of visual artistry within computer games. In this blog, I, Lily Martinez, will showcase the breathtaking graphics, intricate details, and awe-inspiring landscapes that make gaming a true visual masterpiece. Prepare to be amazed as we explore the extraordinary blend of technology and creativity that brings these virtual worlds to life.",
                    Author = "Lily Martinez",
                },

                new Post
                {
                    Title = "Beyond Entertainment: Exploring the Impact of Gaming",
                    Description = "Join me, David Thompson, as we delve into the profound impact of gaming beyond mere entertainment. In this blog, we'll examine the positive influence games have on cognitive abilities, problem-solving skills, and even social connections. Discover how gaming is transforming education, healthcare, and various industries, unlocking new possibilities and reshaping our understanding of interactive experiences.",
                    Author = "David Thompson",
                },

                new Post
                {
                    Title = "Creating Worlds: The Magic of Game Development",
                    Description = "Step into the shoes of a game developer and unlock the secrets behind creating immersive worlds. In this blog, I, Alex Reynolds, will take you on a behind-the-scenes journey, exploring the intricate process of game development. From concept art to coding, we'll unravel the magic that goes into bringing characters, stories, and gameplay to life. Get ready to appreciate the dedication and creativity poured into crafting the games we love.",
                    Author = "Alex Reynolds",
                }
            );
            context.SaveChanges();
        }
    }
}