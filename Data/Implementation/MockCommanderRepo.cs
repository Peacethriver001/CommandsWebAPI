using CommanderWebAPI.Models;
using System.Collections.Generic;

namespace CommanderWebAPI.Data.Implementation
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command {Id = 1, HowTo = "Break a nut", Line = "Break gently", Platform = "Knife and hard surface"},
                new Command {Id = 2, HowTo = "Dance to a song", Line = "Play favorite music", Platform = "Music from phone or PC"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }
    }
}
