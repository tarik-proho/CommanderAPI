using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="boil an egg", Line="Boli water", Platform="kettle n pan"},
                new Command{Id=1, HowTo="an egg", Line="water", Platform="pan"},
                new Command{Id=2, HowTo="boil", Line="Boill water", Platform="kettle"}
            };

            return commands;
        }
           

        public Command GetCommandbyId(int id)
        {
            return new Command{Id=0, HowTo="boil an egg", Line="Boli water", Platform="kettle n pan"};
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
           // throw new System.NotImplementedException();
        }
    }   
}