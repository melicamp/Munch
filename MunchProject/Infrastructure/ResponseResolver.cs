using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace MunchProject.Infrastructure
{
    public static class ResponseResolver
    {
        public static HttpResponseMessage GetResponseMessage<T>(this T obj, HttpRequestMessage request)
        {
            if (obj == null)
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.OK, obj);
            }

            return request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}