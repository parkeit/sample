using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using sample.Core;
using sample.Core.Data;
using sample.Models;

namespace sample.Controllers
{
    public class ParksController : BaseDbApiController
    {

        // GET api/<controller>
        public IEnumerable<ParkViewModel> Get()
        {
            var parks = (from p in Db.Parks
                         from t in p.Tags
                         orderby p.Name
                         select p).Distinct();
            return ParkViewModel.GetParkViewModelList(parks);
        }

        // GET api/<controller>/5
        public ParkViewModel Get(int id)
        {
            var park = (from b in Db.Parks
                        where b.Id == id
                        select b).FirstOrDefault();
            return new ParkViewModel(park);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}