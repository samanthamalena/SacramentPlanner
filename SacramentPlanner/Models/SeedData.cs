using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentPlannerContext>>()))
            {
                // Look for any movies.
                if (context.Sacrament.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sacrament.AddRange(
                    new Sacrament
                    {
                        Date = DateTime.Parse("2015-5-29"),
                        Conducting = "Bishop Morris",
                        OpenHymn = "70",
                        OpenPrayer= "Lynnette Warnberg",
                        SacramentHymn = "203",
                        Speaker = "Sarah Smith",
                        Subject = "Atonement",
                        CloseHymn = "302",
                        ClosePrayer = "Connor Taylor"
                     },

                    new Sacrament
                    {
                        Date = DateTime.Parse("2001-2-12"),
                        Conducting = "Brother Jones",
                        OpenHymn = "72",
                        OpenPrayer = "Lynnette Hemsworth",
                        SacramentHymn = "103",
                        Speaker = "Katelyn Wilson",
                        Subject = "Faith",
                        CloseHymn = "14",
                        ClosePrayer = "Samantha Hancock"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}