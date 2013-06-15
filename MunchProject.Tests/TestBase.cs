using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MunchProject.Tests
{
    public abstract class TestBase
    {
        private static string port = "22699";
        private static string address = "localhost";
        protected string baseUrl = string.Format("http://{0}:{1}/api/munch/", address, port);
        protected HttpClient client;
        protected MediaTypeFormatter[] formatter = new MediaTypeFormatter[] { new JsonMediaTypeFormatter() };

        public TestBase()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected static Action<Task<HttpResponseMessage>> GetAsyncTask<T>(T munch)
        {
            return t =>
            {
                HttpResponseMessage response;

                response = t.Result;
                response.EnsureSuccessStatusCode();

                var readTask = response.Content.ReadAsAsync<T>();
                readTask.Wait();
                munch = readTask.Result;
            };
        }

        protected static Action<Task<HttpResponseMessage>> PostAsyncTask()
        {
            return t =>
            {
                HttpResponseMessage response;

                response = t.Result;
                response.EnsureSuccessStatusCode();

                var readTask = response.Content;
            };
        }
    }
}
