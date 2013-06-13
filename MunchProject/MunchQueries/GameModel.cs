using MunchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MunchProject.MunchQueries
{
    public class GameModel
    {
        public int Id { get; set; }
        public IQueryable<MunchModel> Munches { get; set; }
    }
}
