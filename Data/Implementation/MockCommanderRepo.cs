using CommanderWebAPI.Models;
using System.Collections.Generic;

namespace CommanderWebAPI.Data.Implementation
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Initiate git in a folder", Line = "git init", Platform = "Windows PC/Linux using git bash"},
                new Command {Id = 1, HowTo = "Clone a repository to PC", Line = "git clone URL", Platform = "Windows PC/Linux using git bash"},
                new Command {Id = 2, HowTo = "Add a new file to git working directory", Line = "git add FILE_NAME", Platform = "Windows PC/Linux using git bash"},
                new Command {Id = 2, HowTo = "Add a new migration", Line = "dotnet ef migrations add NAME", Platform = "Windows PC/Linux using git bash"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Initiate git in a folder", Line = "git init", Platform = "Windows PC/Linux using git bash" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
