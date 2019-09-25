using Refit;
using System;
using System.Net.Http;

namespace DiawiApi
{
    public class ApiFactory
    {
        public IApi GetApi(HttpClient client, string baseAddress = "https://upload.diawi.com/")
        {
            client.BaseAddress = new Uri(baseAddress);
            return RestService.For<IApi>(client);
        }
    }
}
