using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using MunchProject.Models;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;

namespace MunchProject.Tests.Controllers
{
    [TestClass]
    public class MunchControllerTests
    {
        [TestMethod]
        public void Get()
        {
            //TODO: Extract client to separate class
            var id = 1;
            var url = string.Format("http://localhost:22699/api/munch/{0}", id);

            var client = new HttpClient();
            MunchModel munch = null;

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetAsync(url).ContinueWith(t =>
            {
                HttpResponseMessage response;

                response = t.Result;
                response.EnsureSuccessStatusCode();

                var readTask = response.Content.ReadAsAsync<MunchModel>();
                readTask.Wait();
                munch = readTask.Result;
            });

            task.Wait();

            Assert.IsNotNull(munch);
        }
    }
}
