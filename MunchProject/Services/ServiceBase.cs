using MunchProject.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MunchProject.Services
{
    public abstract class ServiceBase
    {
        protected MunchContext _db { get; set; }

        public ServiceBase()
            : this(new MunchContext())
        {
        }

        protected ServiceBase(MunchContext db)
        {
            _db = db;
        }
    }
}
