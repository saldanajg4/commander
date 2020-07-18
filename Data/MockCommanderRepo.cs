using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Rezar el Rosario", Line="Juntar gente", Platform="La recompenza lo vale todo"},
                new Command{Id=2, HowTo="Viajar a Mex", Line="Checa la Van", Platform="Documents"}
            }; 
            return commands;
        }

        public Command GetCommandById(int id)
        {
             var commands = new List<Command>{
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Rezar el Rosario", Line="Juntar gente", Platform="La recompenza lo vale todo"},
                new Command{Id=1, HowTo="Viajar a Mex", Line="Checa la Van", Platform="Documents"}
            };
            var commnadItem = commands.Find(cmd => cmd.Id == id);
            return commnadItem;
            // return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"};
        }
    }
}