using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data{
    public class CommanderContext : DbContext{
        public CommanderContext(DbContextOptions<CommanderContext> options) : 
            base(options){

            }
                // services.AddDbContext<CommanderContext>(opt =>
            //    opt.UseInMemoryDatabase("CommaderList"));
        public DbSet<Command> Commands { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        //     optionsBuilder.UseInMemoryDatabase("CommanderList");
        // }

    }
}