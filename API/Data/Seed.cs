using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedArchers(DataContext context)
        {
            if (await context.Archers.AnyAsync()) return;

            var archerData = await System.IO.File.ReadAllTextAsync("Data/ArcherSeedData.json");
            var archers = JsonSerializer.Deserialize<List<Archer>>(archerData);
            foreach (var archer in archers)
            {
                context.Archers.Add(archer);
            }

            await context.SaveChangesAsync();
        }
    }
}