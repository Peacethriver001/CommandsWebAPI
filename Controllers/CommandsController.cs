﻿using AutoMapper;
using CommanderWebAPI.Data;
using CommanderWebAPI.Data.Implementation;
using CommanderWebAPI.DTOs;
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
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
            
        //private readonly MockCommanderRepo _mockCommanderRepo = new MockCommanderRepo();
        //GET api/commands/
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();
            return Ok(_mapper.Map<CommandReadDTO>(commands));
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDTO> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            if(command == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommandReadDTO>(command));
        }

        //POST api/commands
        public ActionResult<CommandCreateDTO> CreateCommands (CommandCreateDTO commandCreateDTO)
        {
           var commandModel = _mapper.Map<Command>(commandCreateDTO);
            _repository.CreateCommand(commandModel);
            return Ok(commandModel);
        }

        //POST api/commands/{id}

    }
}