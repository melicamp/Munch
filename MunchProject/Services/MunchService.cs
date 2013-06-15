using MunchProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MunchProject.Services
{
    public class MunchService : ServiceBase, IMunchServiceContract
    {
        public MunchModel GetMunchById(int id)
        {
            return _db.Munches.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<MunchModel> AddMunch(MunchModel munch)
        {
            _db.Munches.Add(munch);
            _db.SaveChanges();
            return _db.Munches;
        }
    }
}