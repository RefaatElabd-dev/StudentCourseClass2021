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
    public class LearnAreasController : ControllerBase, ILearnAreaDataService
    {
        private readonly ILearnAreaDataService _service;

        public LearnAreasController(ILearnAreaDataService service)
        {
            _service = service;
        }

        [HttpDelete]
        [Route("Delete")]
        public bool Delete(LearnArea entity)
        {
            return _service.Delete(entity);
        }

        [HttpGet]
        [Route("GetAll")]
        public ICollection<LearnArea> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("Get/{ID}")]
        public LearnArea GetById(int ID)
        {
            return _service.GetById(ID);
        }

        [HttpPost]
        [Route("insert")]
        public LearnArea insert(LearnArea entity)
        {
            return _service.insert(entity);
        }

        [HttpPatch]
        [Route("Update")]
        public LearnArea Update(LearnArea entity)
        {
            return _service.Update(entity);
        }
    }
}
