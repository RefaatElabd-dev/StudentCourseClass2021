using Core.Common.interfaces.DSL;
using Core.DAL.Entities;
using Core.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DSL
{
    public class CourseDataService : ICourseDataService
    {
        private readonly ICourseRepo _repo;

        public CourseDataService(ICourseRepo repo)
        {
            _repo = repo;
        }
        public bool Delete(Course entity)
        {
            return _repo.Delete(entity);
        }

        public ICollection<Course> GetAll()
        {
            return _repo.GetAll();
        }

        public Course GetById(int ID)
        {
            return _repo.GetById(ID);
        }

        public Course insert(Course entity)
        {
            return _repo.insert(entity);
        }

        public Course Update(Course entity)
        {
            return _repo.Update(entity);
        }
    }
}
