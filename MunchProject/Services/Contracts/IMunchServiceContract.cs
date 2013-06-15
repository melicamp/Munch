using MunchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MunchProject.Services
{
    public interface IMunchServiceContract
    {
        MunchModel GetMunchById(int id);
        IEnumerable<MunchModel> AddMunch(MunchModel munch);
    }
}
