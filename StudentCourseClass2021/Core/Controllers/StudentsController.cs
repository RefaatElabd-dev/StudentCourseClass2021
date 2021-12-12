using Core.Common.interfaces.DSL;
using Core.DAL.Entities;
using Core.DSL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase, IStudentDataService
    {
        private readonly IStudentDataService _service;
        public StudentsController(IStudentDataService service)
        {
            _service = service;
        }

        [HttpDelete]
        [Route("Delete")]
        public bool Delete(Student entity)
        {
            return _service.Delete(entity);
        }

        [HttpGet]
        [Route("GetAll")]
        public ICollection<Student> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("Get/{ID}")]
        public Student GetById(int ID)
        {
            return _service.GetById(ID);
        }

        [HttpGet]
        [Route("GetWithCourceDetails/{ID}")]
        public StdDTO GetWithCourceDetails(int ID)
        {
            return _service.GetWithCourceDetails(ID);
        }

        [HttpPost]
        [Route("insert")]
        public Student insert(Student entity)
        {
            return _service.insert(entity);
        }

        [HttpPatch]
        [Route("Update")]
        public Student Update(Student entity)
        {
            return _service.Update(entity);
        }
    }
}
