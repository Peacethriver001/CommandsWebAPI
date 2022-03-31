using AutoMapper;
using CommanderWebAPI.DTOs;
using CommanderWebAPI.Models;

namespace CommanderWebAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
            CreateMap<CommandUpdateDTO, Command>();
            CreateMap<Command, CommandUpdateDTO>();
        }
    }
}
