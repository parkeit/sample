using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sample.Core.Data;
using sample.Models;

namespace sample.Controllers
{
    public class TagsController : BaseDbApiController
    {
        // GET api/<controller>
        public IEnumerable<TagViewModel> Get()
        {
            var tags = (from p in Db.Tags
                        orderby p.Name
                        select p).Distinct();
            return TagViewModel.GetTagViewModelList(tags);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return (from p in Db.Tags
                    where p.Id == id
                    select p.Name).FirstOrDefault();
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