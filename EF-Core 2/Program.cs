using EF_Core_2.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDatabaseContext iTIDatabaseContext = new ITIDatabaseContext();
            iTIDatabaseContext.Database.Migrate();

            using AirLineDatabaseContext airLineDatabaseContext = new AirLineDatabaseContext();
            airLineDatabaseContext.Database.Migrate();




        }
    }
}
