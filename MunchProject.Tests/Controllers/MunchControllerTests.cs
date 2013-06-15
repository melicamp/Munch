using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using MunchProject.Models;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;

namespace MunchProject.Tests.Controllers
{
    [TestClass]
    public class MunchControllerTests : TestBase
    {
        [TestMethod]
        public void Get()
        {
            MunchModel munch = null;
            int id = 1;
            baseUrl += id.ToString();

            client.GetAsync(baseUrl)
                .ContinueWith(t =>
                {
                    HttpResponseMessage response;

                    response = t.Result;
                    response.EnsureSuccessStatusCode();

                    var readTask = response.Content.ReadAsAsync<MunchModel>();
                    readTask.Wait();
                    munch = readTask.Result;
                })
                .Wait();

            Assert.IsNotNull(munch);
        }

        [TestMethod]
        public void Post()
        {
            var munch = new MunchModel
            {
                PlayerName = "Łukaszek",
                LifeCount = 1
            };

            client.PostAsync<MunchModel>(baseUrl, munch, formatter.First())
                .ContinueWith(PostAsyncTask())
                .Wait();
        }
    }
}
