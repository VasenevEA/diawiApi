using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;

namespace DiawiApi.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public async Task Upload_Valid()
        {
            var api = RestService.For<IApi>(new HttpClient() { BaseAddress = new Uri("https://upload.diawi.com/") });
            var stream = new FileStream("example.apk", FileMode.Open);
            var jobResult = await api.Upload("token", new StreamPart(stream, "example.apk",""));

            var status = await api.GetStatus("token", "job");
        }
    }
}
