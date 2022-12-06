using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SuperCoolProject_919vb.Models {
    internal class Parser {
        private RestClient client;
        private RestRequest restRequest;
        public Parser(KadArbitrClass body) {
            client = new("http://kad.arbitr.ru");
            restRequest = new RestRequest();
            var b = client.Get(restRequest);
            restRequest = new RestRequest("Kad/SearchInstances");
            restRequest.AddJsonBody(body);
            var a = client.Post(restRequest);
            return;
        }
    }
}
