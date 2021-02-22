using PruebaPWC.Api.API;
using PruebaPWC.API.ApiClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPWC.API
{
    public static class Extension
    {
        public static async Task<HttpClient> Autenticar(this HttpClient httpC)
        {
            try
            {
                const string name = "Authorization";
                if (httpC.DefaultRequestHeaders.Contains(name))
                    httpC.DefaultRequestHeaders.Remove(name);

                var cl1 = new UserClient(WSCommon.HttpAPIClient);
                var session = await cl1.LoginAsync(new RequestLogger {Email = WSCommon.Session.EmailUsuario, Password = WSCommon.Session.Password });

                if (session.Token != null)
                {
                    httpC.DefaultRequestHeaders.TryAddWithoutValidation(name, $"Bearer {session.Token}");
                }
                else
                    throw new Exception("No se pudo loggear");

                return httpC;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
