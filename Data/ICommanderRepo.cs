using CommanderWebAPI.Models;
using System.Collections.Generic;

namespace CommanderWebAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id); 
    }
}
