using MunchProject.Infrastructure;
using MunchProject.Models;
using MunchProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MunchProject.Controllers
{
    public class MunchController : ApiController
    {
        private readonly IMunchServiceContract _munchService;

        public MunchController(IMunchServiceContract munchService)
        {
            _munchService = munchService;
        }

        // GET api/munch
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/munch/5
        public HttpResponseMessage Get(int id)
        {
            return _munchService.GetMunchById(id).GetResponseMessage(Request, "Munch not found!");
        }

        // POST api/munch
        public HttpResponseMessage Post([FromBody]MunchModel munch)
        {
            return _munchService.AddMunch(munch).PostResponseMessage(munch, Request);
        }

        // PUT api/munch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/munch/5
        public void Delete(int id)
        {
        }
    }
}
