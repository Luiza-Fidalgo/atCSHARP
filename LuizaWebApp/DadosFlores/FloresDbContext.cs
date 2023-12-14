using Microsoft.EntityFrameworkCore;

namespace LuizaWebApp.DadosFlores
{
    public class FloresDbContext : DbContext
    {
        public FloresDbContext(DbContextOptions<FloresDbContext> options)
        {

        }
    }
}
