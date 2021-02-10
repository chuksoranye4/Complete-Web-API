using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteWebApi.Data.Interface
{
    public interface ICommand<T> where T : class
    {
        void SaveChanges();
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T t);

        void Update(T t);

        void Delete(T t);
    }
}
