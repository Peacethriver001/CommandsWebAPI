using CommanderWebAPI.Data;
using CommanderWebAPI.Data.Implementation;
using CommanderWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CommanderWebAPI.Controllers
{
    [Route("api/command")]
    [ApiController]
    public class CommandsController : Controller
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
            
        //private readonly MockCommanderRepo _mockCommanderRepo = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            return Ok(command);
        }
    }
}
