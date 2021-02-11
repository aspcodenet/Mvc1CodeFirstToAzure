using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mvc1CodeFirstToAzure.Data
{
    public class DataInitializer
    {
        public void InitializeDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();
            SeedPlayers(context);
        }

        private void SeedPlayers(ApplicationDbContext context)
        {
            AddIfNotExists(context,"Mats Sundin",13,"Toronto");
            AddIfNotExists(context, "Peter Forsberg", 21, "Colorado");
            context.SaveChanges();
        }

        private void AddIfNotExists(ApplicationDbContext context, string playerName, int age, string team)
        {
            var p = context.Players.FirstOrDefault(r => r.Namn == playerName);
            if (p != null ) return;
            context.Players.Add(new Player { Namn = playerName, Jersey = age, Team = team});
        }
    }
}