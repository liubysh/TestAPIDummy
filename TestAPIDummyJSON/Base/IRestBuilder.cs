
using RestSharp;

namespace TestAPIDummyJSON.Base
{
    public interface IRestBuilder
    {
        IRestBuilder WithBody(object body);
        IRestBuilder WithHeader(string name, string value);
        IRestBuilder WithQueryParameter(string name, string value);
        IRestBuilder WithRequest(string request);
        IRestBuilder WithUrlSegment(string name, string value);
        Task<T?> WithDelete<T>();
        Task<T?> WithGet<T>();
        Task<T?> WithPatch<T>();
        Task<T?> WithPost<T>();
        Task<T?> WithPut<T>();
        Task<RestResponse> WithPost();
        Task<RestResponse> WithDelete();
    }
}