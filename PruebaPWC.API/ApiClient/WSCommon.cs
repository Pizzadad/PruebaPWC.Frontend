using PruebaPWC.API.ApiClient.Resource;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PruebaPWC.API
{
    public static class WSCommon
    {
        public static HttpClient HttpAPIClient { get; set; }
        public static ClientSesion Session { get; set; }
    }
}
