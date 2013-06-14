using MunchProject.Models;
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
        public static HttpResponseMessage GetResponseMessage<T>(this T obj, 
            HttpRequestMessage request, string notFoundMsg = "") where T : ModelBase
        {
            if (obj == null)
            {
                return request.CreateResponse(HttpStatusCode.NotFound, notFoundMsg);
            }

            return request.CreateResponse(HttpStatusCode.OK, obj);

        }

        public static HttpResponseMessage PostResponseMessage<T>(this IEnumerable<T> objs, 
            T obj, HttpRequestMessage request) where T : ModelBase
        {
            HttpResponseMessage msg;
            if(objs.Contains(obj))
            {
                msg = request.CreateResponse(HttpStatusCode.Created);
                msg.Headers.Location = new Uri(request.RequestUri + obj.Id.ToString());
                return msg;
            }

            //TODO: Provide with proper message code
            return request.CreateResponse(HttpStatusCode.BadRequest);
            
        }
    }
}