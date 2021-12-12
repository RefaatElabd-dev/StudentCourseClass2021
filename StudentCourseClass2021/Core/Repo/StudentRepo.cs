using Core.Common.Logging;
using Core.DAL;
using Core.DAL.Entities;
using Core.DSL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repo
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDBContext _db;

        public StudentRepo(ApplicationDBContext db)
        {
            _db = db;
        }
        public bool Delete(Student student)
        {
            try
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ICollection<Student> GetAll()
        {
            try
            {
                    return _db.Students.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Student GetById(int ID)
        {
            try
            {
                return _db.Students.FirstOrDefault(S => S.ID == ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public StdDTO GetWithCourceDetails(int ID)
        {
            StdDTO std = new StdDTO();
            Student student = _db.Students.FirstOrDefault(s=>s.ID == ID);

            std.ID = student.ID;
            std.Name = student.Name;
            std.CourseDto = new List<CourseDto>();

            List<StudentCourse> studentCourses = _db.StudentCourses.Where(sc => sc.StudentID == ID).ToList();


            List<Course> CoursesLearnArea = _db.Courses.Where(c=> studentCourses.Select(s=>s.CourseID).Contains(c.ID)).ToList();

            foreach (Course course in CoursesLearnArea)
            {
                string learnAreaCode = _db.LearnAreas.Where(L => L.ID == course.LearnAreaID).Select(l=> l.Code).FirstOrDefault();
                std.CourseDto.Add(new CourseDto(){ CourseName = course.Name, LearnAreaCode = learnAreaCode });
            }

            return std;
        }

        public Student insert(Student entity)
        {
            try
            {
                var InsertProcess = _db.Students.Add(entity);
                _db.SaveChanges();
                return InsertProcess.Entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Student Update(Student entity)
        {
            try
            {
                var process = _db.Students.Update(entity);
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
