using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AryaSock.Data;
using System;
using System.Linq;

namespace AryaSock.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SockContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SockContext>>()))
            {
                // Look for any socks.
                if (context.Socks.Any())
                {
                    return;   // DB has been seeded
                }

                context.Socks.AddRange(
                    new Sock
                    {
                        Title = "Cotton Socks 1",
                        ReleaseDate = DateTime.Parse("2023-01-15"),
                        Material = "Cotton",
                        Size = "Medium",
                        Color = "White",
                        Price = 5M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Woolen Socks 1",
                        ReleaseDate = DateTime.Parse("2023-02-20"),
                        Material = "Wool",
                        Size = "Large",
                        Color = "Gray",
                        Price = 8.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Cotton Socks 2",
                        ReleaseDate = DateTime.Parse("2023-03-10"),
                        Material = "Cotton",
                        Size = "Small",
                        Color = "Black",
                        Price = 6.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Woolen Socks 2",
                        ReleaseDate = DateTime.Parse("2023-04-05"),
                        Material = "Wool",
                        Size = "Medium",
                        Color = "Blue",
                        Price = 7.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Silk Socks 1",
                        ReleaseDate = DateTime.Parse("2023-05-12"),
                        Material = "Silk",
                        Size = "Medium",
                        Color = "Red",
                        Price = 9.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Cotton Socks 3",
                        ReleaseDate = DateTime.Parse("2023-06-18"),
                        Material = "Cotton",
                        Size = "Large",
                        Color = "Green",
                        Price = 6.49M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Woolen Socks 3",
                        ReleaseDate = DateTime.Parse("2023-07-22"),
                        Material = "Wool",
                        Size = "Medium",
                        Color = "Brown",
                        Price = 8.49M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Silk Socks 2",
                        ReleaseDate = DateTime.Parse("2023-08-30"),
                        Material = "Silk",
                        Size = "Small",
                        Color = "Purple",
                        Price = 10.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Cotton Socks 4",
                        ReleaseDate = DateTime.Parse("2023-09-14"),
                        Material = "Cotton",
                        Size = "Medium",
                        Color = "Yellow",
                        Price = 6.99M,
                        Rating = CustomRatingScale.Three
                    },

                    new Sock
                    {
                        Title = "Woolen Socks 4",
                        ReleaseDate = DateTime.Parse("2023-10-01"),
                        Material = "Wool",
                        Size = "Large",
                        Color = "Black",
                        Price = 8.99M,
                        Rating = CustomRatingScale.Two
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
