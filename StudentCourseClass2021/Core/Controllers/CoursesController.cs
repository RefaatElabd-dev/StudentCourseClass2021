using Core.Common.interfaces.DSL;
using Core.DAL.Entities;
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
    public class CoursesController : ControllerBase, ICourseDataService
    {
        private readonly ICourseDataService _service;
        public CoursesController(ICourseDataService service)
        {
            _service = service;
        }

        [HttpDelete]
        [Route("Delete")]
        public bool Delete(Course entity)
        {
            return _service.Delete(entity);
        }

        [HttpGet]
        [Route("GetAll")]
        public ICollection<Course> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("Get/{ID}")]
        public Course GetById(int ID)
        {
            return _service.GetById(ID);
        }

        [HttpPost]
        [Route("insert")]
        public Course insert(Course entity)
        {
            return _service.insert(entity);
        }

        [HttpPatch]
        [Route("Update")]
        public Course Update(Course entity)
        {
            return _service.Update(entity);
        }
    }
}
