using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository.IdIRepository

{
    internal class IdIRepository : IRepository<Student>
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        List<Student> idlist= new List<Student>();

        public void Add(Student obj)
        {
            idlist.Add(obj);
        }

        public IEnumerable<Student> GetAll()
        {
            return idlist;
        }

        //public Student GetById(int id)
        //{
        //    if (idlist.Contains(Student.Id))
        //}

        public void Remove(Student obj)
        {
            idlist.Remove(obj);
        }

        public void save()
        {
            //No operation
            return;
        }
    }
}

