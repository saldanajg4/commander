using System.Collections.Generic;
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

    }
}