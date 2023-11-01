using Microsoft.EntityFrameworkCore;
using Tarea6.Shared;
namespace Tarea6.Server.DAL
{
    public class Context : DbContext
    {
        public  DbSet<Prioridades> Prioridades  { get; set; }
        public  DbSet<Clientes> Clientes { get; set; }
        public  DbSet<Tickets> Tickets { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }

    }
}
