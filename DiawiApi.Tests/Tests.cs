using DiawiApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiawiApi.Tests
{
    [TestClass]
    public class Tests
    {
        string token = "diawi token";

        IApi api;
        ApiFactory factory;

        public Tests()
        {
            factory = new ApiFactory();
            api = factory.GetApi(new HttpClient());
        }

        [TestMethod]
        public async Task Upload_Check()
        {
            var stream = new FileStream("example.apk", FileMode.Open);
            var result = await api.Upload(token, new StreamPart(stream, stream.Name, ""));

            Assert.IsNotNull(result);
            Assert.IsFalse(string.IsNullOrEmpty(result.JobKey));
        }

        [TestMethod]
        public async Task GetStatus_Check()
        {
            var stream = new FileStream("example.apk", FileMode.Open);
            var result = await api.Upload(token, new StreamPart(stream, stream.Name, ""));

            var status = await api.GetStatus(token, result.JobKey);
            Assert.AreNotEqual(StatusCode.Undefined, status.Status);
        }

        [TestMethod]
        public async Task Upload_CheckTokenException()
        {
            await Assert.ThrowsExceptionAsync<ApiException>(() => api.Upload(token, null));
        }


        [TestMethod]
        public async Task Upload_CheckRequestException()
        {
            var api = factory.GetApi(new HttpClient(), "http://noway");
            await Assert.ThrowsExceptionAsync<HttpRequestException>(() => api.Upload(token, null));
        }
    }
}
