using Core.Common.interfaces.DSL;
using Core.DAL.Entities;
using Core.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DSL
{
    public class LearnAreaDataService : ILearnAreaDataService
    {
        private readonly ILearnAreaRepo _repo;

        public LearnAreaDataService(ILearnAreaRepo repo)
        {
            _repo = repo;
        }

        public bool Delete(LearnArea entity)
        {
            return _repo.Delete(entity);
        }

        public ICollection<LearnArea> GetAll()
        {
            return _repo.GetAll();
        }

        public LearnArea GetById(int ID)
        {
            return _repo.GetById(ID);
        }

        public LearnArea insert(LearnArea entity)
        {
            return _repo.insert(entity);
        }

        public LearnArea Update(LearnArea entity)
        {
            return _repo.Update(entity);
        }
    }
}
