using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPIDummyJSON.Base
{
    public class RestBuilder : IRestBuilder //RestBuilder allows building the request.
    //Builder pattern is used to beautify the request creation process
    /* This is a class that allows to build API requests step by step. 
     * It helps encapsulate the complex logic of creating requests and reduces the need 
     * to repeat code in tests. Using the Builder Pattern, you can configure request 
     * parameters (such as URL, headers, query parameters) before the request is executed.*/
    {
        private readonly IRestLibrary _restLibrary;
        public RestBuilder(IRestLibrary restLibrary)
        {
            _restLibrary = restLibrary;
        }

        private RestRequest RestRequest { get; set; } = null!; //Means that vakue is not null

        public IRestBuilder WithRequest(string request)
        {
            RestRequest = new RestRequest(request);
            return this; //after such operations all neededobjects will be the same type RestBuilder, it will be easy to create the chain of actions
        }

        public IRestBuilder WithHeader(string name, string value)
        {
            RestRequest.AddHeader(name, value);
            return this; //after such operations all neededobjects will be the same type RestBuilder, it will be easy to create the chain of actions
        }

        public IRestBuilder WithQueryParameter(string name, string value)
        {
            RestRequest.AddQueryParameter(name, value);
            return this;
        }

        public IRestBuilder WithUrlSegment(string name, string value)
        {
            RestRequest.AddUrlSegment(name, value);
            return this;
        }

        public IRestBuilder WithBody(object body)
        {
            RestRequest.AddBody(body);
            return this;
        }

        public Task<T?> WithGet<T>()
        {
            return _restLibrary.RestClient.GetAsync<T>(RestRequest);
        }

        public Task<T?> WithPost<T>()
        {
            return _restLibrary.RestClient.PostAsync<T>(RestRequest);
        }

        public Task<RestResponse> WithPost()
        {
            return _restLibrary.RestClient.PostAsync(RestRequest);
        }

        public Task<T?> WithPut<T>()
        {
            return _restLibrary.RestClient.PutAsync<T>(RestRequest);
        }

        public Task<T?> WithDelete<T>()
        {
            return _restLibrary.RestClient.DeleteAsync<T>(RestRequest);
        }

        public Task<RestResponse> WithDelete()
        {
            return _restLibrary.RestClient.DeleteAsync(RestRequest);
        }

        public Task<T?> WithPatch<T>()
        {
            return _restLibrary.RestClient.PatchAsync<T>(RestRequest);
        }
    }
}
