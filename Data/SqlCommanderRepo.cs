﻿using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
             return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandbyId(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
                throw new ArgumentException(nameof(cmd));

            _context.Commands.Add(cmd);
        }

        public void UpdateCommand(Command cmd)
        {
            //throw new NotImplementedException();
        }
    }
}