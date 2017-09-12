using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WodScore.Data.DbAccess;
using WodScore.Models;

namespace WodScore.Data.DbInitialize
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {

            using (var context = new WodScoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<WodScoreDbContext>>()))
            {
                if (context.Scores.Any())
                    return;

                context.Scores.AddRange(
                    new Score { Place = 1, Points = 100 },
                    new Score { Place = 2, Points = 94 },
                    new Score { Place = 3, Points = 88 },
                    new Score { Place = 4, Points = 84 },
                    new Score { Place = 5, Points = 80 },
                    new Score { Place = 6, Points = 76 },
                    new Score { Place = 7, Points = 72 },
                    new Score { Place = 8, Points = 68 },
                    new Score { Place = 9, Points = 64 },
                    new Score { Place = 10, Points = 60 },
                    new Score { Place = 11, Points = 58 },
                    new Score { Place = 12, Points = 56 },
                    new Score { Place = 13, Points = 54 },
                    new Score { Place = 14, Points = 52 },
                    new Score { Place = 15, Points = 50 },
                    new Score { Place = 16, Points = 48 },
                    new Score { Place = 17, Points = 46 },
                    new Score { Place = 18, Points = 44 },
                    new Score { Place = 19, Points = 42 },
                    new Score { Place = 20, Points = 40 },
                    new Score { Place = 21, Points = 38 },
                    new Score { Place = 22, Points = 36 });
                               
                context.SaveChanges();
            }
        }
    }
}
