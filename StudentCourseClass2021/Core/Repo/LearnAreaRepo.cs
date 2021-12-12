using Core.DAL;
using Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repo
{
    public class LearnAreaRepo : ILearnAreaRepo
    {
        private readonly ApplicationDBContext _db;

        public LearnAreaRepo(ApplicationDBContext db)
        {
            _db = db;
        }
        public bool Delete(LearnArea learnArea)
        {
            try
            {
                _db.LearnAreas.Remove(learnArea);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ICollection<LearnArea> GetAll()
        {
            try
            {
                return _db.LearnAreas.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public LearnArea GetById(int ID)
        {
            try
            {
                return _db.LearnAreas.FirstOrDefault(S => S.ID == ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public LearnArea insert(LearnArea entity)
        {
            try
            {
                var InsertProcess = _db.LearnAreas.Add(entity);
                _db.SaveChanges();
                return InsertProcess.Entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public LearnArea Update(LearnArea entity)
        {
            try
            {
                var process = _db.LearnAreas.Update(entity);
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
