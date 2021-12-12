using Core.DAL;
using Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repo
{
    public class CourseRepo : ICourseRepo
    {
        private readonly ApplicationDBContext _db;

        public CourseRepo(ApplicationDBContext db)
        {
            _db = db;
        }
        public bool Delete(Course course)
        {
            try
            {
                _db.Courses.Remove(course);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ICollection<Course> GetAll()
        {
            try
            {
                return _db.Courses.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Course GetById(int ID)
        {
            try
            {
                return _db.Courses.FirstOrDefault(S => S.ID == ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Course insert(Course entity)
        {
            try
            {
                var InsertProcess = _db.Courses.Add(entity);
                _db.SaveChanges();
                return InsertProcess.Entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Course Update(Course entity)
        {
            try
            {
                var process = _db.Courses.Update(entity);
                _db.SaveChanges();
                return process.Entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
