using RestSharp;

namespace TestAPIDummyJSON.Base
{
    public interface IRestLibrary
    {
        RestClient RestClient { get; }
    }
}