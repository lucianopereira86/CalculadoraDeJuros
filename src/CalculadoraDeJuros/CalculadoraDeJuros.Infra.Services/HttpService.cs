using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Infra.Services
{
    public class HttpService : IHttpService
    {
        private readonly ILogger<HttpService> _logger;

        public HttpService(ILogger<HttpService> logger)
        {
            _logger = logger;
        }
        public async Task<T> Connect<T>(string url, string method, dynamic obj = null)
        {
            _logger.LogInformation($"CONECTANDO COM API = {url}");

            Uri uri = new Uri(url);
            var request = WebRequest.Create(uri) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Method = method;
            request.Timeout = 30000;
            request.PreAuthenticate = true;

            if (request.Method.Equals("POST") || request.Method.Equals("PUT"))
            {
                byte[] byteArray = obj == null ? new byte[0] : Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(obj));
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }
            return await GetResult<T>(request);
        }

        private async Task<T> GetResult<T>(HttpWebRequest request)
        {
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            var isOk = response.StatusCode == HttpStatusCode.OK;
            var encoding = Encoding.UTF8;
            using (var reader = new StreamReader(response.GetResponseStream(), encoding))
            {
                _logger.LogInformation("CONEXAO COM API REALIZADA COM SUCESSO");
                string retorno = reader.ReadToEnd();
                _logger.LogInformation($"RETORNO DA API\n{retorno}");
                return JsonConvert.DeserializeObject<T>(retorno);
            }
        }
    }
}
