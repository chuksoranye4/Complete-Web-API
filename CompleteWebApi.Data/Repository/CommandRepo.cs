using CompleteWebApi.Data.Interface;
using CompleteWebApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteWebApi.Data.Repository
{
    public class CommandRepo<T> : ICommand<T> where T : class
    {
        private CommandContext _commandContext = null;
        private DbSet<T> _dbSet;

        public CommandRepo(CommandContext commandContext)
        {
            _commandContext = commandContext;
            _dbSet = commandContext.Set<T>();
        }

        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            _commandContext.Add(t);
        }

        public void Delete(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            _commandContext.Remove(t);
        }

      
        public IEnumerable<T> GetAll()
        {
            return _commandContext.Set<T>().ToList();
        }

     
        public T GetById(int id)
        {
           return _commandContext.Set<T>().Find(id);
        }

        public void SaveChanges()
        {
             _commandContext.SaveChanges();
        }

        public void Update(T t)
        {
           
        }
    }
}