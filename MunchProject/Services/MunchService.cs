using MunchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MunchProject.Services
{
    public class MunchService : IMunchServiceContract
    {
        List<MunchModel> munches = new List<MunchModel>
        {
            new MunchModel{
                Id = 1,
                PlayerName = "Łukaszek"
            }
        };

        public MunchModel GetMunchById(int id)
        {
            return munches.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}