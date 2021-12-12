using Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) :base(options)
        {

        }

        public ApplicationDBContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<LearnArea> LearnAreas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(SC => new { SC.StudentID, SC.CourseID });

                entity.HasOne(Sc => Sc.Student)
                      .WithMany(S => S.StudentCourses)
                      .HasForeignKey(SC => SC.StudentID);

                entity.HasOne(Sc => Sc.Course)
                      .WithMany(C => C.CourseStudents)
                      .HasForeignKey(SC => SC.CourseID);
            });

            builder.Entity<Course>(entity =>
            {
                entity.HasOne(C => C.LearnArea)
                      .WithMany(L => L.Courses)
                      .HasForeignKey(C => C.LearnAreaID);
            });
                
        }
    }
}
