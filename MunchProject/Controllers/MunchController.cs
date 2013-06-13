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
        //TODO: Add dependency resolver
        IMunchServiceContract munchService = new MunchService();

        // GET api/munch
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/munch/5
        public HttpResponseMessage Get(int id)
        {
            return munchService.GetMunchById(id).GetResponseMessage(Request);
        }

        // POST api/munch
        public void Post([FromBody]string value)
        {
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
