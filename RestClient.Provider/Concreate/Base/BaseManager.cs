using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RestClient.Provider.Concreate.Base
{
    public class BaseManager : ClientManager
    {
        public HttpClient _httpClient;
        public BaseManager()
        {
            _httpClient = _ = GetClient().Result;
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
    }
}
