using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MilitariaWPFGus.Data
{
    public class BaseApi
    {
        private readonly HttpClient _HttpClient;
        protected string Url { get; set; } = "https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area";

        public BaseApi()
        {
            _HttpClient = new HttpClient();
            _HttpClient.BaseAddress = new Uri(Url);
        }
        public HttpClient GetHttpClient()
        {
            return _HttpClient;
        }

    }
}
