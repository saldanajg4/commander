using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        List<Command> commands = new List<Command>{
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Rezar el Rosario", Line="Juntar gente", Platform="La recompenza lo vale todo"},
                new Command{Id=2, HowTo="Viajar a Mex", Line="Checa la Van", Platform="Documents"}
            };
        public IEnumerable<Command> GetAppCommands()
        {
            // var commands = new List<Command>{
            //     new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
            //     new Command{Id=1, HowTo="Rezar el Rosario", Line="Juntar gente", Platform="La recompenza lo vale todo"},
            //     new Command{Id=2, HowTo="Viajar a Mex", Line="Checa la Van", Platform="Documents"}
            // }; 
            return commands;
        }

        public Command GetCommandById(int id)
        {
            //  var commands = new List<Command>{
            //     new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
            //     new Command{Id=1, HowTo="Rezar el Rosario", Line="Juntar gente", Platform="La recompenza lo vale todo"},
            //     new Command{Id=2, HowTo="Viajar a Mex", Line="Checa la Van", Platform="Documents"}
            // };
            
            return commands.Find(cmd => cmd.Id == id);
            // return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"};
        }

        // public List<Command> PostCommand(Command command)
        // {
        //     commands.Add(command);
        //     return commands;
        // }
        public int PostCommand(Command command)
        {
            //  _context.Commands.Add(command);
            // await _context.SaveChangesAsync();

            // return command;

              commands.Add(command);
    
           
            return 1;

        }
    }
}