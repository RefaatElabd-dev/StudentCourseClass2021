using Core.Common.interfaces.DSL;
using Core.DAL.Entities;
using Core.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DSL
{
    public class StudentDataService : IStudentDataService
    {
        private readonly IStudentRepo _repo;

        public StudentDataService(IStudentRepo repo)
        {
            _repo = repo;
        }

        public bool Delete(Student entity)
        {
            return _repo.Delete(entity);
        }

        public ICollection<Student> GetAll()
        {
            return _repo.GetAll();
        }

        public Student GetById(int ID)
        {
            return _repo.GetById(ID);
        }

        public Student insert(Student entity)
        {
            return _repo.insert(entity);
        }

        public Student Update(Student entity)
        {
            return _repo.Update(entity);
        }

        public StdDTO GetWithCourceDetails(int ID)
        {
            StdDTO student = _repo.GetWithCourceDetails(ID);
            return student;
        }
    }
}
