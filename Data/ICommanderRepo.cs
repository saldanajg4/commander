using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Data{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
        int PostCommand(Command command);
    }
}