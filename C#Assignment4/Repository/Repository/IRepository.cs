using System;
using System.Collections.Generic;
//For sql server
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Repository.IRepository
{
	public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Remove(T obj);
        void save();
        IEnumerable<T> GetAll();
        T GetById(int id);

    }




}



