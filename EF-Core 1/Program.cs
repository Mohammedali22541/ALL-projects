using EF_Core_1.DataBaseDbContext;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItiDbContext itiDbContext = new ItiDbContext();
            itiDbContext.Database.Migrate();

            using AirLineDbContext airLineDbContext = new AirLineDbContext();
            airLineDbContext.Database.Migrate();

        }
    }
}
