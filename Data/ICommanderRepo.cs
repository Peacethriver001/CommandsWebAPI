using CommanderWebAPI.Models;
using System.Collections.Generic;

namespace CommanderWebAPI.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        
        //Interface to get all the commands as a list.
        IEnumerable<Command> GetAllCommands();

        //Call this interface to get individual command. You'd need to know the id of the command to use this interface.
        Command GetCommandById(int id); 

        void CreateCommand(Command command);

        void UpdateCommand(Command command);

        void DeleteCommand(Command command);
    }
}
