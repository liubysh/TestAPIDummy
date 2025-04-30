using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPIDummyJSON.Base
{
    public class RestFactory : IRestFactory
    //RestFactory creates specific requests or objects for tests depending on the situation.
    /*This is a factory class that creates different types of requests or objects for API 
     * testing depending on the needs. For example, you can create requests for different 
     * endpoints or specific request methods (e.g., for testing authentication or particular functionality).    */
    {
        private readonly IRestBuilder _restBuilder;
        public RestFactory(IRestBuilder restBuilder)
        {
            _restBuilder = restBuilder;
        }

        public IRestBuilder Create()
        {
            return _restBuilder;
        }
    }
}
