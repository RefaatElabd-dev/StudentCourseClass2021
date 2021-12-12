using Core.DAL.Entities;
using Core.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Common.interfaces.DSL
{
    public interface IStudentDataService : ICRUDDataService<Student, int>
    {
        StdDTO GetWithCourceDetails(int ID);
    }
}
