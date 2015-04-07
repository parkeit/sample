using System.Web.Http;
using sample.Core.Data;

namespace sample.Controllers
{
    public class BaseDbApiController : ApiController
    {
        protected readonly SampleParksContext Db;

        public BaseDbApiController()
        {
            Db = new SampleParksContext();
        }
    }
}