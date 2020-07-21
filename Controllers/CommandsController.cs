using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers{
    
    //api/commands for Route definition below  
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase{
        
        private readonly ICommanderRepo _repo;
        //dependency injected value
        public CommandsController(ICommanderRepo repo){
            _repo = repo;
        }
        //api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repo.GetAppCommands();
            return Ok(commandItems);
            
        }

        //uri is GET api/commands/{id} api/commands/1
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id){
            var commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);
        }
        //  public class Command{
        // public int Id { get; set; }
        // public string HowTo { get; set; }
        // public string  Line { get; set; }
        // public string  Platform { get; set; }
        [HttpPost]
        public ActionResult<Command> PostCommand(Command command){
            var cmd =  _repo.PostCommand(command);
            // return Ok(CreatedAtAction(nameof(GetCommandById), new {id = command.Id}, command));
            return Ok(cmd + " row inserted.");
        }
    }
}