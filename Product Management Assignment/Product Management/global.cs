using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Product_Management
{
    public class global
    {
        public static HttpClient WepApiClient = new HttpClient();
       global()
        {
            WepApiClient.BaseAddress = new Uri("https://localhost:44301/api/");
            WepApiClient.DefaultRequestHeaders.Clear();
            WepApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}