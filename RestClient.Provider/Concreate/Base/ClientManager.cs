using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Provider.Concreate.Base
{
    public class ClientManager
    {
        public Task<HttpClient> GetClient()
        {
            return Task.Run(() =>
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                return client;
            });
        }
    }
}
