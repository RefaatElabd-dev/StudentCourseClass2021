using Core.DAL.Entities;
using Core.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repo
{
    public interface IStudentRepo : IRepository<Student, int>
    {
        StdDTO GetWithCourceDetails(int ID);
    }
}
