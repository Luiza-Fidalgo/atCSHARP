using LuizaWebApp.Controller1;
using Microsoft.EntityFrameworkCore;

namespace LuizaWebApp.DadosFlores
{
    public class FloresDbContext : DbContext
    {
        public FloresDbContext(DbContextOptions<FloresDbContext> options)
        {

        }

        public static implicit operator FloresDbContext(FloresControllers v)
        {
            throw new NotImplementedException();
        }
    }
}
