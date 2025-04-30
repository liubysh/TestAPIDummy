using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPIDummyJSON.Base
{
    public class RestLibrary : IRestLibrary //RestLibrary provides core methods for executing requests and working with responses.
    /*
     * This is a general class that contains core functions for working with APIs, such as executing 
     * requests, checking response status, and processing response data. RestLibrary provides an 
     * abstraction for handling different types of requests (GET, POST, PUT, DELETE) and convenient 
     * methods for testing APIs.???*/
    {
        public RestLibrary()
        {
            var _restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri("https://petstore.swagger.io/v2/")//Uri("https://dummyjson.com/")
            };

            //Rest Client is created here
            RestClient = new RestClient(_restClientOptions);
        }

        public RestClient RestClient { get; }
    }
}
