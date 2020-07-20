using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Commander.data{
    public class DbCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public DbCommanderRepo(CommanderContext ctx)
        {
            _context = ctx;
        }
        public IEnumerable<Command> GetAppCommands()
        {
            return _context.Commands;
        }

        public  Command  GetCommandById(int id)
        {
            return _context.Commands
                .Where(cmd => cmd.Id == id)
                .FirstOrDefault();
        }

        public Command PostCommand(Command command)
        {
            _context.Commands.Add(command);
            _context.SaveChangesAsync();

            return command;

        }
    }
}