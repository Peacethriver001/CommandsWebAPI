using CommanderWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderWebAPI.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
